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
            logger.Info("GO GO GO");
            return Task.CompletedTask;
        }
    }
}
