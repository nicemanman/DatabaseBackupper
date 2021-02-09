using DomainModel;
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
    public class ScheduleDetailsPresenter : BasePresenter<IScheduleDetailsView, ScheduleModel>
    {
        private readonly IScheduleService scheduleDetailsService;
        public ScheduleDetailsPresenter(IApplicationController controller, IScheduleDetailsView view, IScheduleService scheduleDetailsService) : base(controller, view)
        {
            this.scheduleDetailsService = scheduleDetailsService;
            
        }

        private async void View_SaveButtonPressed()
        {
            try
            {
                var selectedPeriodicEnum = scheduleDetailsService.GetCronTypeByName(View.SelectedPeriodic);
                ScheduleModel model = new ScheduleModel()
                {
                    Name = View.Caption,
                    CronExpressionType = selectedPeriodicEnum,
                    Minutes = View.Minutes,
                    Hours = View.Hours,
                    SelectedDays = View.selectedDays,
                    Id = View.Id
                };
                await scheduleDetailsService.SaveCronExpression(model);
                View.Close();
            }
            catch (Exception ex) 
            {
                View.ShowError(ex.Message);
            }
        }

        private void View_OnPeriodicChanged()
        {
            var cronType = scheduleDetailsService.GetCronTypeByName(View.SelectedPeriodic);
            View.SetSchedule(cronType);
        }

        public override void Run(ScheduleModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name))
                model.Name = "Создать новое расписание";
            View.OnPeriodicChanged += View_OnPeriodicChanged;
            View.Caption = model.Name;
            View.SchedulePeriodics = scheduleDetailsService.GetListOfPeriodics();
            View.days = scheduleDetailsService.GetListOfDays();
            View.SaveButtonPressed += View_SaveButtonPressed;
            View.selectedDays = model.SelectedDays;
            var CronName = scheduleDetailsService.GetNameByCronType(model.CronExpressionType);
            View.SelectedPeriodic = CronName;
            View.Id = model.Id;
            if (model.Minutes != 0) 
            {
                View.Minutes = model.Minutes;
            }
            if (model.Hours != 0) 
            {
                View.Hours = model.Hours;
            }
            View.Show();
        }
    }
}
