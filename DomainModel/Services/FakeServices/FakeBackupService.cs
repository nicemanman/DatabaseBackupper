using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services.FakeServices
{
    public class FakeBackupService : IBackupService
    {
        public Task<string> BackupDatabases(BackupModel backupModel, IProgress<string> successProgress, IProgress<string> percentProgress, string ServerName = "")
        {
            throw new NotImplementedException();
        }

        public void DisconnectFromCurrentSqlServer()
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllDatabases()
        {
            throw new NotImplementedException();
        }

        public string GetCurrentSQLServerInstanceName()
        {
            throw new NotImplementedException();
        }
    }
}
