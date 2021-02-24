using DomainModel.Components.DatabaseRepository;
using DomainModel.Services;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using UI;

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
            var container = ApplicationController.ContainerInstance;
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
