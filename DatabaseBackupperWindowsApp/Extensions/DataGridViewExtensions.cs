using DatabaseBackupperWindowsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupperWindowsApp.Extensions
{
    public static class DataGridViewExtensions
    {
        public static void Refill(this DataGridView view, TasksManager tasksManager)
        {
            tasksManager.BuildTasksQueue();
            view.Rows.Clear();
            for (int i = 0; i < tasksManager.Count(); i++)
            {
                var currentTask = tasksManager[i];
                view.Rows.Add(currentTask.Name, currentTask.ID, currentTask.LoginData.ServerName, currentTask.BackupData.Path, currentTask.CronJob);
            }
        }
    }
}
