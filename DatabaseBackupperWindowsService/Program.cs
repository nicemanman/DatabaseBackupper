using DomainModel.Components.DatabaseRepository;
using DomainModel.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBackupperWindowsService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            var container = new LightInjectAdapder();
            container.Register<IScheduleService, ScheduleService>();
            container.Register<IDatabaseController, DatabaseController>();
            container.Register<ITaskService, TaskService>();
            container.Register<IBackupService, BackupService>();
            container.Register<DatabaseBackupperService>();
            container.Register<BackupJob>();
            ServicesToRun = new ServiceBase[]
            {
                container.Resolve<DatabaseBackupperService>()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
