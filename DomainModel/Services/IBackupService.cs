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
        Task<bool> BackupDatabases(BackupModel backupModel, IProgress<string> progress);
        List<string> GetDatabaseBackupPaths();
        void DisconnectFromCurrentSqlServer();
    }
}
