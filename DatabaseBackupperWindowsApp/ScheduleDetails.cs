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
        ScheduleData schedule;
        public ScheduleDetails(ScheduleData schedule = null)
        {
            InitializeComponent();
            manager = new ScheduleManager();
            DayOfWeek.Text = "?";
            this.schedule = schedule;
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
                ID = schedule?.ID ?? 0,
                Description = ScheduleName.Text,
                Cron = cronExpression
            });
            Close();
        }

        private void HowTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.quartz-scheduler.net/documentation/quartz-2.x/tutorial/crontriggers.html#example-cron-expressions");
        }

        private void ScheduleDetails_Load(object sender, EventArgs e)
        {
            if (schedule == null) return;
            ScheduleName.Text = schedule.Description;
            var cron_parts = schedule.Cron.Split(' ');
            Seconds.Text = cron_parts[0];
            Minutes.Text = cron_parts[1];
            Hours.Text = cron_parts[2];
            DayOfMonth.Text = cron_parts[3];
            Month.Text = cron_parts[4];
            DayOfWeek.Text = cron_parts[5];

        }
    }
}
