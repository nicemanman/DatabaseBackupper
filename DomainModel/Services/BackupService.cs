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
        public bool BackupDatabases(BackupModel backupModel)
        {
            databaseController.jobRepository.Add(new Job() {Name = "Test",Path="Path",schedule=new Schedule() { Name = "TestName",Cron = "Cron"},ServerName="Server",Databases="Databases" });
            databaseController.Complete();
            var connectionString = Context.GetDBConnectionString();
            if (string.IsNullOrWhiteSpace(connectionString)) 
            {
                
            }
            return false;
        }

        public void DisconnectFromCurrentSqlServer()
        {
            Context.RemoveDatabaseConnectionString();
        }
    }
}
