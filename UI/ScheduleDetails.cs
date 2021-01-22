
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
using UI.Components;
using static DomainModel.Enums;

namespace UI
{
    public partial class ScheduleDetails : Form, IScheduleDetailsView
    {
        private Dictionary<Enums.CronExpressionType, SchedulePeriodPanel> periodicPanels;
        private Dictionary<string, CronExpressionType> namings;
        private SchedulePeriodPanel currentPanel;

        public event Action OnPeriodicChanged;

        public ScheduleDetails()
        {
            InitializeComponent();
            
            Load += ScheduleDetails_Load;
            SaveButton.Click += SaveButton_Click;
            //"название" - "элемент перечисления" - "панель, связанная с ним"
            periodicPanels = new Dictionary<Enums.CronExpressionType, SchedulePeriodPanel>
            {
                { Enums.CronExpressionType.EveryNMinutes, EveryNMinutes },//минута
                { Enums.CronExpressionType.EveryNHours, EveryNHours},//час
                { Enums.CronExpressionType.EveryDayAt, EveryDayAt },//час, минута
                { Enums.CronExpressionType.EverySpecificDayAt, EverySpecificWeekdayAt },//список дней, час, минута
            };

            foreach (var panel in periodicPanels)
            {
                if (panel.Value == null) continue;
                panel.Value.Parent = AllPeriodicsPanel;
                panel.Value.Dock = DockStyle.Fill;
                panel.Value.LoadPanel();
            }

            PeriodicList.SelectedValueChanged += PeriodicList_SelectedValueChanged;
            
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

            PeriodicList.DataSource = SchedulePeriodics;
            this.Text = Caption;
        }

        private void PeriodicList_SelectedValueChanged(object sender, EventArgs e)
        {
            OnPeriodicChanged();
        }

        public List<string> SchedulePeriodics { get; set; }
        public string SelectedPeriodic { get { return PeriodicList.SelectedItem.ToString(); } set 
            {
                PeriodicList.SelectedItem = value;
            } 
        }
        public string Caption { get; set; }
        public int Minutes { get => currentPanel.minutes; set => currentPanel.MinutesControl.Text = value.ToString(); }
        public int Hours { get => currentPanel.hours; set => currentPanel.HoursControl.Text = value.ToString(); }
        public List<string> days { get => throw new NotImplementedException(); set 
            {
                var panel = periodicPanels.Values.Where(x => x.SpecificDays != null).FirstOrDefault();
                foreach (var day in value)
                {
                    panel.SpecificDays.Items.Add(day);
                }
            } }
        public List<string> selectedDays { 
            get
            {
                var list = new List<string>();
                var panel = periodicPanels.Values.Where(x => x.SpecificDays != null).FirstOrDefault();
                foreach (var day in panel.SpecificDays.CheckedItems)
                {
                    list.Add(day.ToString());
                }
                return list;
            }
            set => throw new NotImplementedException(); }

        
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

        public void Wait(Progress<string> progres)
        {
            throw new NotImplementedException();
        }

        public void SetSchedule(Enums.CronExpressionType type)
        {
            var panel = periodicPanels[type];
            panel.BringToFront();
            currentPanel = panel;
        }

        public string GetSchedule()
        {
            throw new NotImplementedException();
        }
    }
}
