using DatabaseBackupperWindowsLibrary.Managers;
using DatabaseBackupperWindowsLibrary;
using NLog;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsService
{
    public class BackupJob : IJob
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public Task Execute(IJobExecutionContext context)
        {
            var progress = new Progress<string>(status =>
            {
                logger.Info(status);
            });
            TasksManager manager = new TasksManager();
            var tasksId = (List<int>)context.JobDetail.JobDataMap["tasks"];
            foreach (var taskId in tasksId)
            {
                var item = manager.GetTask(taskId);
                DatabasesManager dbManager = new DatabasesManager(item.LoginData.ServerName, item.LoginData.UserName, item.LoginData.Password);
                foreach (var database in item.BackupData.DatabasesToBackup)
                {
                    logger.Info("Начинаем делать бэкапы - ");
                    dbManager.Backup(database, item.BackupData.Path, progress);
                }
            }
            return Task.CompletedTask;
        }
    }
}
