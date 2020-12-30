using DomainModel.Models;
using DomainModel.Services;
using Presentation.Common;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class BackupPresenter : BasePresenter<IBackupView, BackupModel>
    {
        private BackupModel model;
        private readonly IBackupService backupService;
        public BackupPresenter(IApplicationController controller, IBackupView view, IBackupService backupService) : base(controller, view)
        {
            this.backupService = backupService;
        }

        public override void Run(BackupModel argument)
        {
            model = argument;
            View.AllDatabases = model.AllDatabases;
            View.Show();
            View.Logout += View_Logout;
            View.Backup += View_Backup;
            View.CreateNewSchedule += View_CreateNewSchedule;
            View.CreateNewTask += View_CreateNewTask;
            View.CreateTaskByTemplate += View_CreateTaskByTemplate;
            View.OpenAllSchedules += View_OpenAllSchedules;
            View.OpenAllTasks += View_OpenAllTasks;
            
        }

        private void View_OpenAllTasks()
        {
            throw new NotImplementedException();
        }

        private void View_OpenAllSchedules()
        {
            throw new NotImplementedException();
        }

        private void View_CreateTaskByTemplate()
        {
            throw new NotImplementedException();
        }

        private void View_CreateNewTask()
        {
            throw new NotImplementedException();
        }

        private void View_CreateNewSchedule()
        {
            throw new NotImplementedException();
        }

        private void View_Backup()
        {
            var backupModel = new BackupModel()
            {
                PathToBackup = View.PathToBackup,
                AllDatabases = View.AllDatabases,
                DatabasesToBackup = View.DatabasesToBackup
            };
        }

        private void View_Logout()
        {
            backupService.BackupDatabases(null);
            Controller.Run<LoginPresenter>();
            View.Close();
        }
    }
}
