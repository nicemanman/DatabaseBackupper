using DomainModel;
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
        public ScheduleDetailsPresenter(IApplicationController controller, IScheduleDetailsView view) : base(controller, view)
        {
            View.SchedulePeriodics = Constants.GetListOfSchedulePeriodics();
            
        }

        public override void Run(string argument)
        {
            View.Caption = argument;
            View.Show();
        }
    }
}
