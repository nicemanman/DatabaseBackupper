using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public static class WindowsServiceEvents
    {
        public static event Action UpdateTasksList;
        public static void TaskSaved() 
        {
            UpdateTasksList?.Invoke();
        }
    }
}
