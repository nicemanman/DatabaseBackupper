using DatabaseBackupper;
using DatabaseBackupperWindowsApp.Extensions;
using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.ViewModels;
using LoadingIndicator.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupperWindowsApp
{
    public partial class Tasks : Form
    {
        private LongOperation longOperation;
        private Panel wait;
        private LoginData loginData;
        private readonly DatabasesManager databases;
        private readonly TasksManager tasksManager;
        public Tasks(LoginData loginData, BackupData backupData, DatabasesManager databases)
        {
            InitializeComponent();
            this.loginData = loginData;
            this.databases = databases;
            tasksManager = new TasksManager();
            Activated += new System.EventHandler(this.Tasks_OnShown);

            wait = new Panel();
            wait.Dock = DockStyle.Fill;
            wait.BackColor = Color.White;
            Controls.Add(wait);

            longOperation = new LongOperation(wait, LongOperationSettings.Default);
        }

        private async void Tasks_OnShown(object sender, EventArgs e)
        {
            wait.BringToFront();
            using (longOperation.Start()) 
            {
                await TasksTable.Refill(tasksManager);
                
            }
            panel1.BringToFront();
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            TasksTable.KeyDown += TasksTable_KeyDown;
            TasksTable.Focus();
        }

        private void TasksTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) { 
                var active = TasksTable.CurrentRow;
                
                tasksManager.DeleteTask((int)active.Cells["ID"].Value);
                TasksTable.Rows.Remove(active);
                
            }
            if (e.KeyCode == Keys.Enter)
            {
                var active = TasksTable.CurrentRow;
                var taskData = tasksManager.GetTask((int)active.Cells["ID"].Value);
                
                
                TaskDetail details = new TaskDetail(taskData);
                details.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            BackupDatabaseForm form = new BackupDatabaseForm(databases, loginData);
            Thread thread = new Thread(x =>
            {
                Application.Run(form);
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var backupData = new BackupData()
            {
                AllDatabases = databases.DatabasesList,
                DatabasesToBackup = new List<string>()
            };
            TaskDetail details = new TaskDetail(new TaskData() { LoginData = loginData, BackupData = backupData });
            details.ShowDialog();
        }

 
    }
}
