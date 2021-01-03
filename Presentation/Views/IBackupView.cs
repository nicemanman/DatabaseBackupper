using Presentation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Views
{
    public interface IBackupView : IView
    {
        List<string> PathsToBackup { get; set; }
        string PathToBackup { get; set; }
        List<string> AllDatabases { get; set; }
        List<string> DatabasesToBackup { get; set; }
        void StartBackupProcess(Progress<string> progress);
        void EndBackupProcess();
        
        void ShowError(string message);
        void ShowSuccess(string message);

        event Action Logout;
        event Action Backup;
        event Action CreateNewTask;
        event Action CreateTaskByTemplate;
        event Action OpenAllTasks;
        event Action CreateNewSchedule;
        event Action OpenAllSchedules;
    }
}
