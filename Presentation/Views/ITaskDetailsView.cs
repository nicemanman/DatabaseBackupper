using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface ITaskDetailsView : IView
    {
        event Action Reload;
        event Action AddNewSchedule;
        event Action SaveTask;
        event Action TimeTaskFired;
        public int Id { get; set; }
        public string Caption { get; set; }
        public List<string> SchedulesList { set; }
        public string SelectedSchedule { get; set; }
        public List<string> DatabasesList { set; }
        public List<string> SelectedDatabasesList { get; set; }
        public List<string> EmailsList { set; }
        public string SelectedEmail { get; set; }
        public List<string> PathsToBackup { set; }
        public string SelectedPath { get; set; }
        public string SQLServer { get; set; }
        public bool NotifyAboutFinish { get; set; }
        public bool TaskIsEnables { get; set; }
        void ShowMessage(string text);
        void ShowError(string text);
    }
}
