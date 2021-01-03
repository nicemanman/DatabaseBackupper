
using DomainModel;
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
    public partial class ScheduleDetails : Form, IScheduleDetailsView
    {
        private Dictionary<Constants.SchedulePeriodics, Panel> periodicPanels;
        public ScheduleDetails()
        {
            InitializeComponent();
            PeriodicList.SelectedValueChanged += PeriodicList_SelectedValueChanged;
            Load += ScheduleDetails_Load;
            
            periodicPanels = new Dictionary<Constants.SchedulePeriodics, Panel>
            {
                { Constants.SchedulePeriodics.Minutes, MinutesIntervalPanel },
                { Constants.SchedulePeriodics.Hours, HoursIntervalPanel },
                { Constants.SchedulePeriodics.Weeks, WeekIntervalPanel },
                { Constants.SchedulePeriodics.Days, DaysIntervalPanel }
            };

            MinutesIntervalPanel.Parent = AllPeriodicsPanel;
            HoursIntervalPanel.Parent = AllPeriodicsPanel;
            WeekIntervalPanel.Parent = AllPeriodicsPanel;
            DaysIntervalPanel.Parent = AllPeriodicsPanel;

            MinutesIntervalPanel.Dock = DockStyle.Fill;
            HoursIntervalPanel.Dock = DockStyle.Fill;
            WeekIntervalPanel.Dock = DockStyle.Fill;
            DaysIntervalPanel.Dock = DockStyle.Fill;
            
            var minutesIntervalRange = new List<string>();
            for (int i = 1; i < 60; i += 1) 
            {
                minutesIntervalRange.Add(i.ToString()) ;
            }

            var hoursIntervalRange = new List<string>();
            for (int i = 1; i < 24; i += 1)
            {
                hoursIntervalRange.Add(i.ToString());
            }
            //Minutes
            MinutesIntervalCombobox.DataSource = minutesIntervalRange;
            //Days
            HoursIntervalCombobox.DataSource = hoursIntervalRange;
            MinutesIntervalCombobox2.DataSource = minutesIntervalRange;
            //Hours
            HoursIntervalCombobox2.DataSource = hoursIntervalRange;
            HoursIntervalCombobox3.DataSource = hoursIntervalRange;
            MinutesIntervalCombobox3.DataSource = minutesIntervalRange;
            //Weekly
            HoursIntervalCombobox4.DataSource = hoursIntervalRange;
            MinutesIntervalCombobox4.DataSource = minutesIntervalRange;
        }

        
        private void ScheduleDetails_Load(object sender, EventArgs e)
        {
            PeriodicList.DataSource = SchedulePeriodics;
            this.Text = Caption;
        }

        private void PeriodicList_SelectedValueChanged(object sender, EventArgs e)
        {
            var list = (ComboBox)sender;
            var enumItem = Constants.GetItem(list.SelectedItem.ToString());

            foreach (var item in periodicPanels)
            {
                if (item.Key == enumItem)
                    item.Value.BringToFront();
            }

        }

        public List<string> SchedulePeriodics { get; set; }
        public string SelectedPeriodic { get; set; }
        public string Caption { get; set; }

        public void SetSchedule(string selectedPeriodic)
        {
            throw new NotImplementedException();
        }

        public void StopWaiting()
        {
            throw new NotImplementedException();
        }

        public void Wait()
        {
            throw new NotImplementedException();
        }

        public new void Show() 
        {
            ShowDialog();
        }
    }
}
