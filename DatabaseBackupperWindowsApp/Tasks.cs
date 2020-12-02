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

        private void Tasks_OnShown(object sender, EventArgs e)
        {
            TasksTable.RefillTasks(tasksManager);
            foreach (DataGridViewRow item in TasksTable.Rows)
            {
                item.ContextMenuStrip = contextMenu;
            }
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            //var deleteTask = ((DataGridViewButtonColumn)TasksTable.Columns["Delete"]);

            //var openTask = ((DataGridViewButtonColumn)TasksTable.Columns["OpenTask"]);
            TasksTable.CellClick += new DataGridViewCellEventHandler(TasksTable_CellClick);
            TasksTable.KeyDown += TasksTable_KeyDown;
            TasksTable.Focus();
        }

        private void TasksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != TasksTable.Columns["Delete"].Index 
                && e.ColumnIndex != TasksTable.Columns["OpenTaskButton"].Index) return;

            if (e.ColumnIndex == TasksTable.Columns["Delete"].Index)
            {
                DeleteTask(TasksTable.CurrentRow);
            }
            else 
            {
                OpenTask(TasksTable.CurrentRow);
            }
        }

        private void OpenTask(DataGridViewRow currentRow)
        {
            var taskData = tasksManager.GetTask((int)currentRow.Cells["ID"].Value);
            taskData.BackupData.AllDatabases = databases.DatabasesList;
            TaskDetail details = new TaskDetail(taskData);
            details.ShowDialog();
        }

        private void DeleteTask(DataGridViewRow currentRow)
        {
            tasksManager.DeleteTask((int)currentRow.Cells["ID"].Value);
            TasksTable.Rows.Remove(currentRow);
        }

        private void TasksTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) { 
                var active = TasksTable.CurrentRow;
                DeleteTask(active);
            }
            if (e.KeyCode == Keys.Enter)
            {
                var active = TasksTable.CurrentRow;
                OpenTask(active);
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

        private void TasksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OpenTaskMenuButton_Click(object sender, EventArgs e)
        {
            OpenTask(TasksTable.CurrentRow);
        }

        private void DeleteTaskMenuButton_Click(object sender, EventArgs e)
        {
            DeleteTask(TasksTable.CurrentRow);
        }
    }
}
