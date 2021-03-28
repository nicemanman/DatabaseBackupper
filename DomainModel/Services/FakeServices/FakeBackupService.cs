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
        public async Task<string> BackupDatabases(BackupModel backupModel, IProgress<string> successProgress, IProgress<string> percentProgress, string ServerName = "")
        {
            foreach (var item in backupModel.DatabasesToBackup)
            {
                percentProgress.Report(item);
                successProgress.Report(item + " - Успех");
                await Task.Delay(100);
            }
            return "Бэкап удачно завершен!";
        }

        public void DisconnectFromCurrentSqlServer()
        {
            return;
        }

        public List<string> GetAllDatabases()
        {
            return new List<string>() { "База данных 1", "База данных 2", "База данных 3", "База данных 4" };
        }

        public string GetCurrentSQLServerInstanceName()
        {
            return "Текущий SQL сервер";
        }
    }
}
