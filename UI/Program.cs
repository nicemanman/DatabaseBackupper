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

            var controller = ApplicationController.Instance;
            controller.RegisterView<ILoginView, ConnectForm>()
            .RegisterView<IBackupView, BackupDatabaseForm>()
            .RegisterView<IScheduleDetailsView, ScheduleDetails>()
            .RegisterView<ISchedulesView, Schedules>()
            .RegisterView<ITasksView, Tasks>()
            .RegisterView<ITaskDetailsView, TaskDetail>();
                
                
            controller.Run<LoginPresenter>();
        }
    }
}
