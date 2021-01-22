using DomainModel;
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
