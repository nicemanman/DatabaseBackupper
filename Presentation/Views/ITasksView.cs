using DomainModel.Models;
using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface ITasksView : IView
    {
        List<TaskModel> Tasks { set; }

        event Action Reload;
        event Func<int, Task> RemoveTask;
        event Action<int> OpenTask;
        event Action CreateNewJobAction;
    }
}
