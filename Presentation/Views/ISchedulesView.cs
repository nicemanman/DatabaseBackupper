using DomainModel.Models;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface ISchedulesView : IView
    {
        List<ScheduleDetailsModel> Schedules { set; }
        
        event Action Reload;
        event Func<int,Task> RemoveSchedule;
        event Action<int> OpenSchedule;
        event Action CreateNewScheduleAction;
    }
    
}
