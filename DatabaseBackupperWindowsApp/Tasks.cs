using DatabaseBackupper;
using DatabaseBackupperWindowsApp.Extensions;
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
    public partial class Tasks : Form
    {
        
        private Form parentWindow;
        private LoginData loginData;
        private readonly DatabasesManager databases;
        private readonly TasksManager tasksManager;
        public Tasks(Form parentForm, LoginData loginData, DatabasesManager databases)
        {
            InitializeComponent();
            this.parentWindow = parentForm;
            this.loginData = loginData;
            this.databases = databases;
            tasksManager = new TasksManager();
            Closed += (s, args) => {
                parentForm.Show();
            };
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            TasksTable.Refill(tasksManager);
            TasksTable.KeyDown += TasksTable_KeyDown;
            TasksTable.Focus();
        }

        private void TasksTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) { 
                var active = TasksTable.CurrentRow;
                
                tasksManager.DeleteTask((Guid)active.Cells["ID"].Value);
                TasksTable.Rows.Remove(active);
                
            }
            if (e.KeyCode == Keys.Enter)
            {
                var active = TasksTable.CurrentRow;
                var taskData = tasksManager.GetTask((Guid)active.Cells["ID"].Value);
                Hide();
                
                TaskDetail details = new TaskDetail(taskData, this);
                details.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            parentWindow.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var backupData = new BackupData()
            {
                AllDatabases = databases.DatabasesList,
                DatabasesToBackup = new List<string>()
            };
            TaskDetail details = new TaskDetail(new TaskData() { LoginData = loginData, BackupData = backupData, ID = Guid.NewGuid() }, this);
            details.Show();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            TasksTable.Refill(tasksManager);
        }

        
    }
}
