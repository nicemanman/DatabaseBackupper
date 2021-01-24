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
    public class ScheduleDetailsPresenter : BasePresenter<IScheduleDetailsView, string>
    {
        private readonly IScheduleDetailsService scheduleDetailsService;
        public ScheduleDetailsPresenter(IApplicationController controller, IScheduleDetailsView view, IScheduleDetailsService scheduleDetailsService) : base(controller, view)
        {
            this.scheduleDetailsService = scheduleDetailsService;
            View.SchedulePeriodics = scheduleDetailsService.GetListOfPeriodics();
            View.days = scheduleDetailsService.GetListOfDays();
            View.OnPeriodicChanged += View_OnPeriodicChanged;
            View.SaveButtonPressed += View_SaveButtonPressed;
        }

        private void View_SaveButtonPressed()
        {
            
            try
            {
                var selectedPeriodicEnum = scheduleDetailsService.GetCronTypeByName(View.SelectedPeriodic);
                ScheduleDetailsModel model = new ScheduleDetailsModel()
                {
                    Name = View.Caption,
                    CronExpressionType = selectedPeriodicEnum,
                    Minutes = View.Minutes,
                    Hours = View.Hours,
                    SelectedDays = View.selectedDays
                };
                scheduleDetailsService.SaveCronExpression(model);
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

        public override void Run(string argument)
        {
            View.Caption = argument;
            View.Show();
        }
    }
}
