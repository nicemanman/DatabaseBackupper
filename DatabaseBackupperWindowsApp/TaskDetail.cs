using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.ViewModels;
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
        

        public TaskDetail(TaskData task)
        {
            InitializeComponent();
            this.task = task;
            
            
        }

        private void TaskDetail_Load(object sender, EventArgs e)
        {
            ScheduleManager manager = new ScheduleManager();
            var scheduleDataList = manager.GetAllOfThem();
            Dictionary<int, string> schedules = new Dictionary<int, string>();
            foreach (var item in scheduleDataList)
            {
                schedules.Add(item.ID, item.Description);
            }
            ScheduleDropDownList.DataSource = schedules.ToArray();
            ScheduleDropDownList.ValueMember = "Key";
            ScheduleDropDownList.DisplayMember = "Value";
            var index = task.ScheduleID == 0 ? 1 : task.ScheduleID;
            if (schedules.Count > 0)
            ScheduleDropDownList.SelectedItem = new KeyValuePair<int, string>(index, schedules[index])/*schedules[(task.ScheduleID == 0 ? 1 : task.ScheduleID)]*/;
               
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
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TasksManager tasksManager = new TasksManager();
            task.BackupData.DatabasesToBackup.Clear();
            foreach (var database in DatabasesList.CheckedItems)
            {
                task.BackupData.DatabasesToBackup.Add(database as string);
            }
            KeyValuePair<int, string> selectedValue = (KeyValuePair<int, string>)ScheduleDropDownList.SelectedItem;
            task.ScheduleID = selectedValue.Key;
            task.BackupData.Path = PathToBackup.Text;
            task.Name = TaskName.Text;
            tasksManager.AddTask(task);
            Close();
            
            
        }

        private void ChoosePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PathToBackup.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
