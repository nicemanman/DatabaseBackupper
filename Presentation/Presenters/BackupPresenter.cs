using DomainModel.Models;
using DomainModel.Services;
using Presentation.Common;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class BackupPresenter : BasePresenter<IBackupView, BackupModel>
    {
        private BackupModel model;
        private readonly IBackupService backupService;
        private readonly IPathService pathService;
       
        public BackupPresenter(IApplicationController controller, IBackupView view, IBackupService backupService, IPathService pathService) : base(controller, view)
        {
            this.backupService = backupService;
            this.pathService = pathService;
        }

        public override void Run(BackupModel argument)
        {
            model = argument;
            View.AllDatabases = model.AllDatabases;
            View.PathsToBackup = pathService.GetBackupPaths();
            View.Show();
            
            View.Logout += View_Logout;
            View.Backup += async () => await View_Backup();
            View.BackupGoogle += async () => await View_BackupGoogle();
            View.GoogleReauthorize += async () => await View_GoogleReauthorize();
            View.CreateNewSchedule += View_CreateNewSchedule;
            View.CreateNewTask += View_CreateNewTask;
            View.CreateTaskByTemplate += View_CreateTaskByTemplate;
            View.OpenAllSchedules += View_OpenAllSchedules;
            View.OpenAllTasks += View_OpenAllTasks;
            View.OpenAboutAuthor += View_OpenAboutAuthor;
            View.OpenAboutProgram += View_OpenAboutProgram;
        }
        private async Task View_GoogleReauthorize() 
        {
            try
            {
                await backupService.ReauthorizeAndBackup(null, null, null);
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }
        private async Task View_BackupGoogle()
        {
            try
            {
                await backupService.BackupGoogle(null, null, null);
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }

        private void View_OpenAboutProgram()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }

        private void View_OpenAboutAuthor()
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }

        private void View_OpenAllTasks()
        {
            try
            {
                Controller.Run<TasksPresenter>();
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }

        private void View_OpenAllSchedules()
        {
            try
            {
                Controller.Run<SchedulesPresenter>();
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }

        private async void View_CreateTaskByTemplate()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(View.PathToBackup))
                    await pathService.SaveBackupPath(View.PathToBackup);
                var model = new TaskModel()
                {
                    AllDatabases = View.AllDatabases,
                    SelectedDatabases = View.DatabasesToBackup,
                    Name = "Создать новую задачу",
                    SQLServer = backupService.GetCurrentSQLServerInstanceName()
                };
                Controller.Run<TaskDetailsPresenter, TaskModel>(model);
            }
            catch (Exception ex) 
            {
                View.ShowError(ex.Message);
            }

        }

        private void View_CreateNewTask()
        {
            try
            {
                var model = new TaskModel()
                {
                    AllDatabases = View.AllDatabases,
                    SelectedDatabases = new List<string>(),
                    Name = "Создать новую задачу",
                    SQLServer = backupService.GetCurrentSQLServerInstanceName()
                };
                Controller.Run<TaskDetailsPresenter, TaskModel>(model);
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }

        private void View_CreateNewSchedule()
        {
            try
            {
                Controller.Run<ScheduleDetailsPresenter, ScheduleModel>(new ScheduleModel());
            }
            catch (Exception ex)
            {
                View.ShowError(ex.Message);
            }
        }

        private async Task View_Backup()
        {
            try
            {
                string messages = "";
                bool pathIsNull;
                if ((pathIsNull = string.IsNullOrWhiteSpace(View.PathToBackup))) messages += "Не заполнен путь для бэкапа!\n";
                if (View.DatabasesToBackup.Count == 0) messages+="Должна быть выбрана хотя бы одна база данных!\n";
                var backupModel = new BackupModel()
                {
                    PathToBackup = View.PathToBackup,
                    AllDatabases = View.AllDatabases,
                    DatabasesToBackup = View.DatabasesToBackup
                };
                if (!pathIsNull && !Directory.Exists(backupModel.PathToBackup)) messages += "Такого путь не найден в системе!";
                if (!string.IsNullOrWhiteSpace(messages)) 
                {
                    View.ShowError(messages);
                    return;
                }
                
                var successProgress = new Progress<string>();
                var detailsProgress = new Progress<string>();
                View.StartBackupProcess(successProgress, detailsProgress);
                await pathService.SaveBackupPath(View.PathToBackup);
                var result = await backupService.BackupDatabases(backupModel, successProgress, detailsProgress);
                View.ShowSuccess(result);
            }
            catch (Exception ex) 
            {
                View.ShowError("Произошла ошибка при бэкапе: "+ex.Message);
            }
            View.EndBackupProcess();
        }

        private void View_Logout()
        {
            Controller.Run<LoginPresenter>();
            View.Close();
        }
    }
}
