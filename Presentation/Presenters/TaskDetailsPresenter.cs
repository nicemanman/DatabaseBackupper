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
        private readonly IScheduleService scheduleService;
        private readonly IPathService pathService;
        private readonly IEmailService emailService;
        public TaskDetailsPresenter(IApplicationController controller, ITaskDetailsView view, IScheduleService scheduleService, IPathService pathService, IEmailService emailService) : base(controller, view)
        {
            this.scheduleService = scheduleService;
            this.pathService = pathService;
            this.emailService = emailService;
        }

        public override void Run(TaskModel model)
        {
            View.SchedulesList = scheduleService.GetAllSchedulesNames();
            View.EmailsList = emailService.GetRecentEmails();
            View.PathsToBackup = pathService.GetBackupPaths();
            View.Reload += View_Reload;
            View.AddNewSchedule += View_AddNewSchedule;
            View.TimeTaskFired += View_TimeTaskFired;
            View.SaveTask += View_SaveTask;
            if (model != null && !string.IsNullOrWhiteSpace(model.Name))
                View.Caption = model.Name;
            else
                View.Caption = "Новая задача";
            View.Show();
        }

        private async void View_SaveTask()
        {
            var messages = "";
            if (View.NotifyAboutFinish && !emailService.IsValidEmail(View.SelectedEmail))
                messages += "Укажите валидный адрес электронной почты!\n";
            bool pathIsNull;
            if ((pathIsNull = string.IsNullOrWhiteSpace(View.SelectedPath))) messages += "Не заполнен путь для бэкапа!\n";
            if (!pathIsNull && !Directory.Exists(View.SelectedPath)) messages += "Такого путь не найден в системе!";
            if (!string.IsNullOrWhiteSpace(messages))
            {
                View.ShowError(messages);
                return;
            }
            await pathService.SaveBackupPath(View.SelectedPath);
            if (View.NotifyAboutFinish)
                await emailService.SaveEmail(View.SelectedEmail);

        }

        private void View_TimeTaskFired()
        {
            var times = scheduleService.GetNextValidTimesAfter(View.SelectedSchedule);
            var timesString = string.Join("\n", times);
            View.ShowMessage(timesString);
        }

        private void View_AddNewSchedule()
        {
            Controller.Run<ScheduleDetailsPresenter, ScheduleDetailsModel>(new ScheduleDetailsModel());
        }

        private void View_Reload()
        {
            View.SchedulesList = scheduleService.GetAllSchedulesNames();
        }
    }
}
