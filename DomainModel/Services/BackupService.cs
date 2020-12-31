using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public class BackupService : IBackupService
    {
        IDatabaseController databaseController;
        public BackupService(IDatabaseController databaseController)
        {
            this.databaseController = databaseController;
        }
        public async Task<string> BackupDatabases(BackupModel backupModel, IProgress<string> progress)
        {
            await AddBackupPathToMemory(backupModel);
            var connectionString = Context.GetDBConnectionString();
            if (!string.IsNullOrWhiteSpace(connectionString)) 
            {
                foreach (var database in backupModel.DatabasesToBackup)
                {
                    var dateNow = DateTime.Now.ToShortDateString();
                    var timeNow = DateTime.Now.ToLongTimeString();
                    string path = backupModel.PathToBackup + "\\" + dateNow + "\\" + database;
                    var databaseFileName = database + " " + timeNow.Replace(":", ".");
                    try
                    {
                        Directory.CreateDirectory(path);
                    }
                    catch (NotSupportedException ex) 
                    {
                        progress.Report($"{database} - {ex.Message}");
                        throw ex;
                    }
                    await Task.Run(() =>
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            try
                            {
                                con.Open();
                                using (SqlCommand cmd = new SqlCommand($"BACKUP DATABASE [{database}] TO  DISK = '{path}\\{databaseFileName}.bak'", con))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                progress.Report($"{database} - OK");
                            }
                            catch (Exception ex)
                            {
                                progress.Report($"{database} - {ex.Message}");
                                throw ex;
                            }
                        }
                    });
                }
            }
            return "Бэкап удачно завершен!";
        }

        public async Task<List<string>> GetDatabaseBackupPaths()
        {
            await RemoveAllBut_N_Newest();
            var paths = databaseController.pathRepository.GetAll().OrderByDescending(x=>x.dateTime).Select(x => x.PathString).ToList<string>();
            return paths;
        }

        public void DisconnectFromCurrentSqlServer()
        {
            Context.RemoveDatabaseConnectionString();
        }

        public async Task AddBackupPathToMemory(BackupModel backupModel)
        {
            await RemoveAllBut_N_Newest();
            var path = databaseController.pathRepository.Find(x => x.PathString == backupModel.PathToBackup).FirstOrDefault();
            if (path == null)
            {
                databaseController.pathRepository.Add(new BackupPath() { PathString = backupModel.PathToBackup, dateTime = DateTime.Now });
            }
            else
            {
                path.dateTime = DateTime.Now;
            }
            await databaseController.Complete();
        }

        public void ClearBackupPathsFromMemory()
        {
            databaseController.pathRepository.RemoveRange(databaseController.pathRepository.GetAll());
            databaseController.Complete();
        }

        private async Task RemoveAllBut_N_Newest() 
        {
            var count = databaseController.pathRepository.GetAll().Count();
            if (count > Constants.PathsCountRememberValue)
            {
                var theOldestPath = databaseController.pathRepository.GetAll().OrderBy(x => x.dateTime).FirstOrDefault();
                databaseController.pathRepository.Remove(theOldestPath);
                await databaseController.Complete();
            }
        }
    }
}
