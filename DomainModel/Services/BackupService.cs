using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Components.GoogleClient;
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
        public async Task<string> BackupDatabases(BackupModel backupModel, IProgress<string> stagesProgress, IProgress<string> detailProgress, string ServerName = "")
        {
            string connectionString = "";
            if (string.IsNullOrWhiteSpace(ServerName))
                connectionString = Context.GetDBConnectionString();
            else
                connectionString = $"Data Source={ServerName}; Integrated Security=True;";
            int stepCount = backupModel.DatabasesToBackup.Count();
            if (detailProgress != null)
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
                        if (!string.IsNullOrWhiteSpace(backupModel.BackupResult)) backupModel.BackupResult += "<br />";
                        backupModel.BackupResult += $"База {database} - {ex.Message}";
                        throw ex;
                    }
                    await Task.Run(() =>
                    {
                        try
                        {
                            if (!string.IsNullOrWhiteSpace(Context.GetServerInstanceName()))
                                ServerName = Context.GetServerInstanceName();
                            BackupDatabase(ServerName, database, path, detailProgress);
                            stagesProgress.Report($"База {database} - успех");
                            if (!string.IsNullOrWhiteSpace(backupModel.BackupResult)) backupModel.BackupResult += "<br />";
                            backupModel.BackupResult += $"База {database} - успех";
                        }
                        catch (Exception ex) 
                        {
                            stagesProgress.Report($"База {database} - {ex.Message}");
                            if (!string.IsNullOrWhiteSpace(backupModel.BackupResult)) backupModel.BackupResult += "<br />";
                            backupModel.BackupResult += $"База {database} - {ex.Message}";
                            throw ex;
                        }
                    });
                }
            }
            return "Бэкап удачно завершен!";
        }


        private void BackupDatabase(string InstanceName, string DatabaseName, string pathToBackp, IProgress<string> progress)
        {
            string fileName = string.Format("{0}_{1}.bak", DatabaseName, DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss"));
            Server dbServer = new Server(new ServerConnection(InstanceName));
            Backup dbBackup = new Backup()
            {
                Action = BackupActionType.Database,
                Database = DatabaseName
                 
            };
            dbBackup.PercentCompleteNotification = 1;

            if (progress != null)
                dbBackup.PercentComplete += (s,e) => progress.Report(DatabaseName + " : " + e.Percent.ToString() + "%");

            dbBackup.Devices.AddDevice(pathToBackp + "\\" + fileName, DeviceType.File);
            dbBackup.Initialize = true;
            dbBackup.SqlBackup(dbServer);
        }

        public void DisconnectFromCurrentSqlServer()
        {
            Context.RemoveDatabaseConnectionString();
            Context.backupModel = null;
        }

        public string GetCurrentSQLServerInstanceName()
        {
            return Context.GetServerInstanceName();
        }

        public List<string> GetAllDatabases()
        {
            return Context.backupModel.AllDatabases;
        }
    }
}
