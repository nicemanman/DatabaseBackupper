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
    public partial class ScheduleDetails : Form
    {
        ScheduleManager manager;
        public ScheduleDetails()
        {
            InitializeComponent();
            manager = new ScheduleManager();
            DayOfWeek.Text = "?";
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            var cronExpression = Seconds.Text + " " + Minutes.Text +" "+ Hours.Text +" "+ DayOfMonth.Text +" "+ Month.Text +" "+ DayOfWeek.Text;

            var validation = manager.ValidateCronExpression(cronExpression);
            if (!validation) 
            {
                MessageBox.Show("Выражение не верное!");
                return;
            }
            await manager.AddSchedule(new ScheduleData() 
            {
                Description = ScheduleName.Text,
                Cron = cronExpression
            });
            Close();
        }

        private void HowTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontriggers.html#example-cron-expressions");
        }
    }
}
