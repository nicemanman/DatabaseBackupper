using UI;
using DomainModel.Services;
using Presentation.Common;
using Presentation.Presenters;
using Presentation.Views;
using System;
using System.Windows.Forms;
using DomainModel.Components.DatabaseRepository;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var controller = new ApplicationController(new LightInjectAdapder())
                .RegisterView<ILoginView, ConnectForm>()
                .RegisterService<ILoginService, LoginService>()
                .RegisterView<IBackupView, BackupDatabaseForm>()
                .RegisterService<IBackupService, BackupService>()
                .RegisterView<IScheduleDetailsView, ScheduleDetails>()
                .RegisterService<IScheduleDetailsService, ScheduleDetailsService>()
                .RegisterInstance(new ApplicationContext())
                .RegisterInstance<IDatabaseController>(new DatabaseController());
                
                
            controller.Run<LoginPresenter>();
        }
    }
}
