
using DomainModel.Models;
using Presentation.Views;
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

namespace UI
{
    public partial class Tasks : Form, ITasksView
    {

        public Tasks()
        {
            InitializeComponent();
            Activated += Tasks_Activated;
            TasksTable.KeyDown += TasksTable_KeyDown;
            TasksTable.CellClick += TasksTable_CellClick;
            CreateNewJobButton.Click += CreateNewJobButton_Click;
        }

        private void CreateNewJobButton_Click(object sender, EventArgs e)
        {
            CreateNewJobAction?.Invoke();
        }

        private void Tasks_Activated(object sender, EventArgs e)
        {
            Reload?.Invoke();
        }

        List<TaskModel> ITasksView.Tasks {
            set
            {
                TasksTable.Rows.Clear();
                foreach (var task in value)
                {
                    TasksTable.Rows.Add(task.Id,task.Name, task.SQLServer, task.SelectedPath, task.SelectedSchedule.Name, task.Enabled, task.NotifyAboutFinish, task.SelectedEmail);
                }
            }
        }

        public event Action Reload;
        public event Func<int, Task> RemoveTask;
        public event Action<int> OpenTask;
        public event Action CreateNewJobAction;


        private async void TasksTable_KeyDown(object sender, KeyEventArgs e)
        {
            var active = TasksTable.CurrentRow;
            int id = Int32.Parse(active.Cells["Id"].Value.ToString());
            if (e.KeyCode == Keys.Delete)
            {
                await RemoveTask?.Invoke(id);
                Reload?.Invoke();
            }
            if (e.KeyCode == Keys.Enter)
            {
                OpenTask?.Invoke(id);
            }

        }

        private async void TasksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != TasksTable.Columns["Delete"].Index
                && e.ColumnIndex != TasksTable.Columns["Open"].Index) return;
            var active = TasksTable.CurrentRow;
            int id = Int32.Parse(active.Cells["Id"].Value.ToString());
            if (e.ColumnIndex == TasksTable.Columns["Delete"].Index)
            {
                await RemoveTask?.Invoke(id);
                Reload?.Invoke();
            }
            else
            {
                OpenTask?.Invoke(id);
            }

        }

        public void StopWaiting()
        {
            throw new NotImplementedException();
        }

        public void Wait(string text = null)
        {
            throw new NotImplementedException();
        }

        public void Wait(Progress<string> progres)
        {
            throw new NotImplementedException();
        }
    }
}
