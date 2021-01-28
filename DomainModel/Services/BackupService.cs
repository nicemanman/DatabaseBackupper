using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Models;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="backupModel"></param>
        /// <param name="stagesProgress">Этапы, которые попадают в лог</param>
        /// <param name="detailProgress">Детальная информация о выполнении бэкапа</param>
        /// <returns></returns>
        public async Task<string> BackupDatabases(BackupModel backupModel, IProgress<string> stagesProgress, IProgress<string> detailProgress)
        {
            await AddBackupPathToMemory(backupModel);
            var connectionString = Context.GetDBConnectionString();
            int stepCount = backupModel.DatabasesToBackup.Count();
 
            detailProgress.Report($"Всего баз данных - {stepCount}. Начали...");
            if (!string.IsNullOrWhiteSpace(connectionString)) 
            {
                foreach (var database in backupModel.DatabasesToBackup)
                {
                    var dateNow = DateTime.Now.ToString("dd'.'MM'.'yyyy");
                    var timeNow = DateTime.Now.ToLongTimeString();
                    string path = backupModel.PathToBackup + "\\" + dateNow + "\\" + database;
                    var databaseFileName = database + " " + timeNow.Replace(":", ".");
                    try
                    {
                        Directory.CreateDirectory(path);
                    }
                    catch (NotSupportedException ex) 
                    {
                        stagesProgress.Report($"{database} - {ex.Message}");
                        throw ex;
                    }
                    await Task.Run(() =>
                    {
                        try
                        {
                            BackupDatabase(Context.GetServerInstanceName(), database, path, detailProgress);
                            stagesProgress.Report($"База {database} - успех");
                        }
                        catch (Exception ex) 
                        {
                            stagesProgress.Report($"База {database} - {ex.Message}");
                            throw ex;
                        }
                    });
                }
            }
            return "Бэкап удачно завершен!";
        }


        private void BackupDatabase(string InstanceName, string DatabaseName, string pathToBackp, IProgress<string> progress)
        {
            string fileName = string.Format("{0}_{1}.bak", DatabaseName, DateTime.Now.ToString("h_mm_tt"));
            Server dbServer = new Server(new ServerConnection(InstanceName));
            Backup dbBackup = new Backup()
            {
                Action = BackupActionType.Database,
                Database = DatabaseName
                 
            };
            dbBackup.PercentCompleteNotification = 1;
            dbBackup.PercentComplete += (s,e) => progress.Report(DatabaseName + " : " + e.Percent.ToString() + "%");
            dbBackup.Devices.AddDevice(pathToBackp + "\\" + fileName, DeviceType.File);
            dbBackup.Initialize = true;
            dbBackup.SqlBackup(dbServer);
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
