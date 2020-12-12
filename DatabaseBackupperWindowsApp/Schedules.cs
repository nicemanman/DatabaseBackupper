using DatabaseBackupperWindowsApp.Extensions;
using DatabaseBackupperWindowsLibrary;
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
    public partial class Schedules : Form
    {
        private ScheduleManager manager;
        public Schedules()
        {
            InitializeComponent();
            Activated += Schedules_Activated;
        }

        private void Schedules_Activated(object sender, EventArgs e)
        {
            SchedulesTable.RefillSchedules(manager);
        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            ScheduleDetails details = new ScheduleDetails();
            details.ShowDialog();
        }

        private void ReturnButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            ScheduleManager manager = new ScheduleManager();
            this.manager = manager;
            SchedulesTable.CellClick += SchedulesTable_CellClick;
            SchedulesTable.KeyDown += SchedulesTable_KeyDown;
        }

        private void SchedulesTable_KeyDown(object sender, KeyEventArgs e)
        {
            var active = SchedulesTable.CurrentRow;
            if (e.KeyCode == Keys.Delete)
            {
                DeleteSchedule(active);
            }
            if (e.KeyCode == Keys.Enter)
            {
                OpenSchedule(active);
            }
        }

        

        private void SchedulesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex != SchedulesTable.Columns["Delete"].Index
                && e.ColumnIndex != SchedulesTable.Columns["Open"].Index) return;

            if (e.ColumnIndex == SchedulesTable.Columns["Delete"].Index)
            {
                DeleteSchedule(SchedulesTable.CurrentRow);
            }
            else
            {
                OpenSchedule(SchedulesTable.CurrentRow);
            }
        }

        private void OpenSchedule(DataGridViewRow currentRow)
        {
            var schedule = manager.GetSchedule((int)currentRow.Cells["ID"].Value);
            if (schedule != null) 
            {
                ScheduleDetails details = new ScheduleDetails(schedule);
                details.ShowDialog();
            }
        }

        private void DeleteSchedule(DataGridViewRow currentRow)
        {
            manager.DeleteSchedule((int)currentRow.Cells["ID"].Value);
            SchedulesTable.RefillSchedules(manager);
        }
    }
}
