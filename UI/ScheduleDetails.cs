
using DomainModel;
using Presentation.Views;
using QuartzCronGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Components;

namespace UI
{
    public partial class ScheduleDetails : Form, IScheduleDetailsView
    {
        private Dictionary<CronExpressionType, SchedulePeriodPanel> periodicPanels;
        private Dictionary<string, CronExpressionType> namings;
        private SchedulePeriodPanel currentPanel;
        public ScheduleDetails()
        {
            InitializeComponent();
            
            Load += ScheduleDetails_Load;
            SaveButton.Click += SaveButton_Click;
            periodicPanels = new Dictionary<CronExpressionType, SchedulePeriodPanel>
            {
                { CronExpressionType.EveryNSeconds, null },//секунда
                { CronExpressionType.EveryNMinutes, EveryNMinutes },//минута
                { CronExpressionType.EveryNHours, EveryNHours},//час
                { CronExpressionType.EveryNDaysAt, null },//интервал в днях, час, минута
                { CronExpressionType.EveryDayAt, EveryDayAt },//час, минута
                { CronExpressionType.EveryWeekDayAt, null },//час, минута
                { CronExpressionType.EverySpecificDayAt, EverySpecificWeekdayAt },//список дней, час, минута
            };

            namings = new Dictionary<string, CronExpressionType>
            {
                
                { "Минутная периодичность",CronExpressionType.EveryNMinutes  },//минута
                { "Часовая периодичность", CronExpressionType.EveryNHours},//час
                { "Каждый день", CronExpressionType.EveryDayAt},//час, минута
                { "В определенные дни", CronExpressionType.EverySpecificDayAt},//список дней, час, минута
            };

            foreach (var panel in periodicPanels)
            {
                if (panel.Value == null) continue;
                panel.Value.Parent = AllPeriodicsPanel;
                panel.Value.Dock = DockStyle.Fill;
                panel.Value.LoadPanel();
            }
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
            
            PeriodicList.SelectedValueChanged += PeriodicList_SelectedValueChanged;
            specificDays.Items.Add(DaysOfWeek.Monday);
            specificDays.Items.Add(DaysOfWeek.Tuesday);
            specificDays.Items.Add(DaysOfWeek.Wednesday);
            specificDays.Items.Add(DaysOfWeek.Thursday);
            specificDays.Items.Add(DaysOfWeek.Friday);
            specificDays.Items.Add(DaysOfWeek.Saturday);
            specificDays.Items.Add(DaysOfWeek.Sunday);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var cron = currentPanel.GetCronExpression();
                if (cron == null)
                    MessageBox.Show("Генерация этого cron выражения еще не реализована!");
                else
                    MessageBox.Show(cron);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ScheduleDetails_Load(object sender, EventArgs e)
        {

            PeriodicList.DataSource = namings.Keys.ToList();
            this.Text = Caption;
        }

        private void PeriodicList_SelectedValueChanged(object sender, EventArgs e)
        {
            var list = (ComboBox)sender;
            namings.TryGetValue(list.SelectedItem.ToString(), out var enumItem);
            
            foreach (var item in periodicPanels)
            {
                if (item.Key == enumItem) 
                {
                    item.Value.BringToFront();
                    currentPanel = item.Value;
                    
                }
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
