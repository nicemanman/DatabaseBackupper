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
    public class TaskDetailsPresenter : BasePresenter<ITaskDetailsView, TaskModel>
    {
        private readonly ITaskService taskService;
        private readonly IScheduleService scheduleService;
        private readonly IPathService pathService;
        private readonly IEmailService emailService;
        
        public TaskDetailsPresenter(
            IApplicationController controller, 
            ITaskDetailsView view,
            IScheduleService scheduleService, 
            IPathService pathService,
            IEmailService emailService, 
            ITaskService taskService) : base(controller, view)
        {
            this.scheduleService = scheduleService;
            this.pathService = pathService;
            this.emailService = emailService;
            this.taskService = taskService;
            
        }

        public override async Task Run(TaskModel model)
        {
            View.SQLServer = model.SQLServer;
            View.DatabasesList = model.AllDatabases;
            View.SelectedDatabasesList = model.SelectedDatabases;
            View.SchedulesList = scheduleService.GetAllSchedulesNames();
            View.EmailsList = emailService.GetRecentEmails();
            View.PathsToBackup = await pathService.GetBackupPaths();
            View.Reload += View_Reload;
            View.AddNewSchedule += View_AddNewSchedule;
            View.TimeTaskFired += View_TimeTaskFired;
            View.SaveTask += View_SaveTask;
            View.Caption = model.Name;
            View.SelectedSchedule = model.SelectedSchedule?.Name ?? "";
            View.Id = model.Id;
            View.TaskIsEnables = model.Enabled;
            View.NotifyAboutFinish = model.NotifyAboutFinish;
            View.Show();
        }

        private async void View_SaveTask()
        {
            //var messages = "";
            //if (View.NotifyAboutFinish && !emailService.IsValidEmail(View.SelectedEmail))
            //    messages += "Укажите валидный адрес электронной почты!\n";
            //bool pathIsNull;
            //if ((pathIsNull = string.IsNullOrWhiteSpace(View.SelectedPath))) messages += "Не заполнен путь для бэкапа!\n";
            //if (!pathIsNull && !Directory.Exists(View.SelectedPath)) messages += "Такого путь не найден в системе!\n";
            //if (View.SelectedDatabasesList.Count == 0) messages += "Необходимо выбрать хотя бы одну базу данных!\n";
            //if (string.IsNullOrWhiteSpace(View.Caption)) messages += "Не задано название задачи!\n";
            //if (!string.IsNullOrWhiteSpace(messages))
            //{
            //    View.ShowError(messages);
            //    return;
            //}
            await pathService.SaveBackupPath(View.SelectedPath);
            if (View.NotifyAboutFinish)
                await emailService.SaveEmail(View.SelectedEmail);
            var schedules = scheduleService.GetAllSchedules();
            var selectedSchedule = schedules.Where(x => x.Name == View.SelectedSchedule).FirstOrDefault() ;
            var taskModel = new TaskModel()
            {
                Id = View.Id,
                Name = View.Caption,
                SelectedDatabases = View.SelectedDatabasesList,
                SelectedEmail = View.SelectedEmail,
                SelectedPath = View.SelectedPath,
                NotifyAboutFinish = View.NotifyAboutFinish,
                Enabled = View.TaskIsEnables,
                SQLServer = View.SQLServer,
                SelectedSchedule = selectedSchedule
            };
            await taskService.SaveTask(taskModel);
            View.Close();
        }

        private void View_TimeTaskFired()
        {
            var times = scheduleService.GetNextValidTimesAfter(View.SelectedSchedule);
            var timesString = string.Join("\n", times);
            View.ShowMessage(timesString);
        }

        private void View_AddNewSchedule()
        {
            Controller.Run<ScheduleDetailsPresenter, ScheduleModel>(new ScheduleModel());
        }

        private void View_Reload()
        {
            View.SchedulesList = scheduleService.GetAllSchedulesNames();
        }
    }
}
