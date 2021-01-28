using DomainModel.Models;
using Presentation.Common;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Presenters
{
    public class TaskDetailsPresenter : BasePresenter<ITaskDetailsView, TaskModel>
    {
        public TaskDetailsPresenter(IApplicationController controller, ITaskDetailsView view) : base(controller, view)
        {
        }

        public override void Run(TaskModel model)
        {
            View.Show();
        }
    }
}
