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
            View.PathsToBackup = backupService.GetDatabaseBackupPaths();
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

        private async void View_Backup()
        {
            string messages = "";
            if (string.IsNullOrWhiteSpace(View.PathToBackup)) messages += "Не заполнен путь для бэкапа!\n";
            if (View.DatabasesToBackup.Count == 0) messages+="Должна быть выбрана хотя бы одна база данных!\n";
            if (!string.IsNullOrWhiteSpace(messages)) 
            {
                View.ShowError(messages);
                return;
            }
            var backupModel = new BackupModel()
            {
                PathToBackup = View.PathToBackup,
                AllDatabases = View.AllDatabases,
                DatabasesToBackup = View.DatabasesToBackup
            };
            var progress = new Progress<string>();
            View.StartBackupProcess(progress);
            await backupService.BackupDatabases(backupModel, progress);
            View.EndBackupProcess();
        }

        private void View_Logout()
        {
            Controller.Run<LoginPresenter>();
            View.Close();
        }
    }
}
