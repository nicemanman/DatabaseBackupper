
using DomainModel.Models;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Schedules : Form, ISchedulesView
    {
        
        public Schedules()
        {
            InitializeComponent();
            Activated += Schedules_Activated;
            SchedulesTable.KeyDown += SchedulesTable_KeyDown;
            SchedulesTable.CellClick += SchedulesTable_CellClick;
            CreateNewSchedule.Click += CreateNewSchedule_Click;
        }

        private void CreateNewSchedule_Click(object sender, EventArgs e)
        {
            CreateNewScheduleAction();
        }

        

        private void Schedules_Activated(object sender, EventArgs e)
        {
            Reload();
        }

        public void Wait(string text = null)
        {
            throw new NotImplementedException();
        }

        public void Wait(Progress<string> progres)
        {
            throw new NotImplementedException();
        }

        public void StopWaiting()
        {
            throw new NotImplementedException();
        }

        List<ScheduleModel> ISchedulesView.Schedules { 
            set 
            {
                SchedulesTable.Rows.Clear();
                foreach (var schedule in value)
                {
                    var nextFireTimes = String.Join("\n", schedule.NextFireTimes);
                    SchedulesTable.Rows.Add(schedule.Id, schedule.Name, schedule.CronExpression, nextFireTimes);
                }
            } 
        }
        public event Action Reload;
        public event Func<int,Task> RemoveSchedule;
        public event Action<int> OpenSchedule;
        public event Action CreateNewScheduleAction;

        private async void SchedulesTable_KeyDown(object sender, KeyEventArgs e)
        {
            var active = SchedulesTable.CurrentRow;
            int id = Int32.Parse(active.Cells["Id"].Value.ToString());
            if (e.KeyCode == Keys.Delete)
            {
                await RemoveSchedule(id);
                Reload();
            }
            if (e.KeyCode == Keys.Enter)
            {
                OpenSchedule(id);
            }
            
        }

        private async void SchedulesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != SchedulesTable.Columns["Delete"].Index
                && e.ColumnIndex != SchedulesTable.Columns["Open"].Index) return;
            var active = SchedulesTable.CurrentRow;
            int id = Int32.Parse(active.Cells["Id"].Value.ToString());
            if (e.ColumnIndex == SchedulesTable.Columns["Delete"].Index)
            {
                await RemoveSchedule(id);
                Reload();
            }
            else
            {
                OpenSchedule(id);
            }
            
        }
    }
}
