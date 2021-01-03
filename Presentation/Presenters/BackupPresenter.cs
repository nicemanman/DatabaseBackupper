﻿using DomainModel.Models;
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
        public BackupPresenter(IApplicationController controller, IBackupView view, IBackupService backupService) : base(controller, view)
        {
            this.backupService = backupService;
        }

        public override void Run(BackupModel argument)
        {
            model = argument;
            View.AllDatabases = model.AllDatabases;
            View.PathsToBackup = Task.Run(async () => await backupService.GetDatabaseBackupPaths()).Result;
            View.Show();
            
            View.Logout += View_Logout;
            View.Backup += async () => await View_Backup();
            View.CreateNewSchedule += View_CreateNewSchedule;
            View.CreateNewTask += View_CreateNewTask;
            View.CreateTaskByTemplate += View_CreateTaskByTemplate;
            View.OpenAllSchedules += View_OpenAllSchedules;
            View.OpenAllTasks += View_OpenAllTasks;
            
        }

        private void View_OpenAllTasks()
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

        private void View_OpenAllSchedules()
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

        private void View_CreateTaskByTemplate()
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

        private void View_CreateNewTask()
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

        private void View_CreateNewSchedule()
        {
            try
            {
                Controller.Run<ScheduleDetailsPresenter,string>("Создать новое расписание");
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
            
                var progress = new Progress<string>();
                View.StartBackupProcess(progress);
                var result = await backupService.BackupDatabases(backupModel, progress);
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
