using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.Managers;
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
        public static void RefillTasks(this DataGridView view, TasksManager tasksManager)
        {
            var tasks = tasksManager.GetAllOfThem();
            view.Rows.Clear();
            foreach (var task in tasks)
            {
                view.Rows.Add(task.Name, task.ID, task.LoginData.ServerName, task.BackupData.Path, task.Schedule.Description);
            }
        }

        public static void RefillSchedules(this DataGridView view, ScheduleManager manager)
        {
            var schedules = manager.GetAllOfThem();
            view.Rows.Clear();
            foreach (var schedule in schedules)
            {
                view.Rows.Add(schedule.ID, schedule.Description, schedule.Cron);
            }
        }
    }
}
