
using NLog;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Services;
using DomainModel.Models;

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
            
            var tasks = (List<TaskModel>)context.JobDetail.JobDataMap["tasks"];
            var backupService = (BackupService)context.JobDetail.JobDataMap["backupService"];
            foreach (var task in tasks)
            {
                BackupModel model = new BackupModel()
                {
                    PathToBackup = task.SelectedPath,
                    DatabasesToBackup = task.SelectedDatabases
                };
                //DatabasesManager dbManager = new DatabasesManager(task.LoginData.ServerName, item.LoginData.UserName, item.LoginData.Password);
                backupService.BackupDatabases(model, progress, progress, task.SQLServer).Wait();
            }
            return Task.CompletedTask;
        }
    }
}
