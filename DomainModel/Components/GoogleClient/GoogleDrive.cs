using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Drive.v3.Data;
using File = Google.Apis.Drive.v3.Data.File;
using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2.Flows;

namespace DomainModel.Components.GoogleClient
{
    /// <summary>
    /// При создании экземпляра автоматически проверяется наличие токена
    /// </summary>
    public class GoogleDrive
    {
        private string folderType = "application/vnd.google-apps.folder";
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        private string[] Scopes = { DriveService.Scope.Drive };
        private string ApplicationName = "Drive API .NET Quickstart";
        private UserCredential credential;
        private DriveService service;

        public GoogleDrive()
        {
            try
            {
                Authorize();
            }
            catch (Google.GoogleApiException ex) 
            {
                throw ex;
            }
        }
       
        public void Authorize() 
        {
            using (var stream =
                new FileStream("C:\\0Repository\\DatabaseBackupper\\DomainModel\\Components\\GoogleClient\\credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                
            }
            // Create Drive API service.
            service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            
        }
        public async Task Reauthorize() 
        {
            await GoogleWebAuthorizationBroker.ReauthorizeAsync(credential, CancellationToken.None);
        }
        private async Task<string> FolderExists(string name) 
        {
            var filesAndFoldersRequest = service.Files.List();
            filesAndFoldersRequest.Q = $"mimeType = 'application/vnd.google-apps.folder' and trashed = false and name = '{name}'";
            var folders = await filesAndFoldersRequest.ExecuteAsync();
            if (folders.Files.FirstOrDefault() == null)
                return "";
            else
                return folders.Files.FirstOrDefault().Id;
        }
        private async Task<string> CreateFolderIfNotExists(string name, string parentFolderId = null)
        {
            try
            {
                var folder = new File();
                folder.Name = name;
                folder.MimeType = folderType;
                if (!string.IsNullOrWhiteSpace(parentFolderId))
                    folder.Parents = new List<string>() { parentFolderId };
                var id = await FolderExists(folder.Name);
                if (string.IsNullOrWhiteSpace(id)) 
                {
                    var result = await service.Files.Create(folder).ExecuteAsync();
                    return result.Id;
                }
                else
                    return id;
            }
            catch (Google.GoogleApiException ex) 
            {
                throw ex;
            }
        }
        /// <summary>
        /// https://developers.google.com/drive/api/v3/manage-uploads
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public async Task UploadFile(string folderName, File file = null) 
        {
            try
            {
                var parentFolderId = await CreateFolderIfNotExists(folderName);
                var subfolderId = await CreateFolderIfNotExists(DateTime.Now.ToString("dd.MM.yyyy"), parentFolderId);
            }
            catch (Google.GoogleApiException ex) 
            {
                throw ex;
            }
        }
    }
}
