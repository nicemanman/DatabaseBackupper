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
            var manager = new TasksManager();
            var tasks = manager.GetAllOfThem();
            view.Rows.Clear();
            foreach (var task in tasks)
            {
                view.Rows.Add(task.Name, task.ID, task.LoginData.ServerName, task.BackupData.Path, task.Schedule.Description);
            }
            
        }
    }
}
