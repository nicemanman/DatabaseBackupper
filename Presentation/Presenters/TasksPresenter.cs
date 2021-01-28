using Presentation.Common;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class TasksPresenter : BasePresenter<ITasksView>
    {
        public TasksPresenter(IApplicationController controller, ITasksView view) : base(controller, view)
        {
            View.Show();
        }
    }
}
