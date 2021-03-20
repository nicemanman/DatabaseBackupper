using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Services
{
    public interface IBackupService
    {
        Task<string> BackupDatabases(BackupModel backupModel, IProgress<string> successProgress, IProgress<string> percentProgress, string ServerName = "");
        void DisconnectFromCurrentSqlServer();
        string GetCurrentSQLServerInstanceName();
        List<string> GetAllDatabases();
    }
}
