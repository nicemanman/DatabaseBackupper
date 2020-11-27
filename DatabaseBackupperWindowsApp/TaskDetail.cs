using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupperWindowsApp
{
    public partial class TaskDetail : Form
    {
        private readonly TaskData task;
        private readonly Form parentForm;

        public TaskDetail(TaskData task, Form parentForm)
        {
            InitializeComponent();
            this.task = task;
            this.parentForm = parentForm;
            Closed += (s, args) => {
                parentForm.Show();
            };
        }

        private void TaskDetail_Load(object sender, EventArgs e)
        {
            TaskName.Text = task.Name;
            ServerName.Text = task.LoginData.ServerName;
            foreach (var database in task.BackupData.AllDatabases)
            {
                var selected = task.BackupData.DatabasesToBackup.Contains(database);
                DatabasesList.Items.Add(database, selected);
            }
            //Schedule.Text = task.CronJob;
            PathToBackup.Text = task.BackupData.Path;
        }

        private void ReturnButtonClick(object sender, EventArgs e)
        {
            Close();
            parentForm?.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TasksManager tasksManager = new TasksManager();
            task.BackupData.DatabasesToBackup.Clear();
            foreach (var database in DatabasesList.CheckedItems)
            {
                task.BackupData.DatabasesToBackup.Add(database as string);
            }
            //task.CronJob = Schedule.Text;
            task.BackupData.Path = PathToBackup.Text;
            task.Name = TaskName.Text;
            tasksManager.AddTask(task);
            Close();
            
            
        }
    }
}
