
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
        private SchedulePeriodPanel currentPanel;

        public event Action OnPeriodicChanged;
        public event Action SaveButtonPressed;

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
            SaveButtonPressed?.Invoke();
        }

        private void ScheduleDetails_Load(object sender, EventArgs e)
        {

            this.Text = Caption;
        }

        private void PeriodicList_SelectedValueChanged(object sender, EventArgs e)
        {
            OnPeriodicChanged?.Invoke();
        }

        public List<string> SchedulePeriodics { set { PeriodicList.DataSource = value; } }
        public string SelectedPeriodic { get { return PeriodicList.SelectedItem.ToString(); } set 
            {
                foreach (var item in PeriodicList.Items)
                {
                    if (item.ToString() == value) 
                    {
                        PeriodicList.SelectedItem = item;
                        break;
                    }
                }
            } 
        }
        public string Caption { get => ScheduleName.Text; set => ScheduleName.Text = value; }
        public int Minutes { get => currentPanel.minutes; set => currentPanel.MinutesControl.Text = value.ToString(); }
        public int Hours { get => currentPanel.hours; set => currentPanel.HoursControl.Text = value.ToString(); }
        private List<string> selectedDaysList = new List<string>();
        public List<string> days {
            get 
            {
                return selectedDaysList;
            } 
            set 
            {
                selectedDaysList = value;
            } 
        }
        public List<string> selectedDays { 
            get
            {
                var list = new List<string>();
                var panel = periodicPanels.Values.Where(x => x.SpecificDays != null).FirstOrDefault();
                if (panel!=null)
                    foreach (var day in panel.SpecificDays.CheckedItems)
                    {
                        list.Add(day.ToString());
                    }
                return list;
            }
            set 
            {
                var panel = periodicPanels.Values.Where(x => x.SpecificDays != null).FirstOrDefault();
                foreach (var day in days)
                {
                    if (value != null && value.Contains(day)) 
                    {
                        panel.SpecificDays.Items.Add(day, true);
                    } else
                        panel.SpecificDays.Items.Add(day, false);
                }
                }
            }

        public int Id { get; set; }

        public void StopWaiting()
        {
            throw new NotImplementedException();
        }

        public void Wait(string text = null)
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

        public void ShowError(string text)
        {
            MessageBox.Show(text, "Ошибка валидации");
        }
    }
}
