using DomainModel.Components.DatabaseRepository;
using DomainModel.Components.DatabaseRepository.DatabaseModels;
using DomainModel.Models;
using System;
using System.Collections.Generic;
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
        public async Task<bool> BackupDatabases(BackupModel backupModel, IProgress<string> progress)
        {
            var path = databaseController.pathRepository.Find(x => x.PathString == backupModel.PathToBackup).FirstOrDefault();
            if (path == null) 
            {
                databaseController.pathRepository.Add(new BackupPath() { PathString = backupModel.PathToBackup});
                await databaseController.Complete();
            }
            var connectionString = Context.GetDBConnectionString();
            if (!string.IsNullOrWhiteSpace(connectionString)) 
            {
                for (int i = 0; i < 100; i++)
                    progress.Report("бам бам");
            }
            return false;
        }

        public List<string> GetDatabaseBackupPaths()
        {
            var paths = databaseController.pathRepository.GetAll().Select(x => x.PathString).ToList<string>();
            return paths;
        }

        public void DisconnectFromCurrentSqlServer()
        {
            Context.RemoveDatabaseConnectionString();
        }
    }
}
