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

        }

        private void ReturnButtonClick(object sender, EventArgs e)
        {

        }

        private void Schedules_Load(object sender, EventArgs e)
        {
            ScheduleManager manager = new ScheduleManager();
            this.manager = manager;
        }
    }
}
