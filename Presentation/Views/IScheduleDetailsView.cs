using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface IScheduleDetailsView : IView
    {
        string Caption { get; set; }
        List<string> SchedulePeriodics { get; set; }
        string SelectedPeriodic { get; set; }
        void SetSchedule(string selectedPeriodic);
    }
}
