using QuartzCronGenerator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Components
{
    public partial class SchedulePeriodPanel : Panel
    {
        
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public CronExpressionType Type { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control MinutesControl { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control HoursControl { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control DaysInterval { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control SpecificDays { get; set; }


        private int minutes { get => GetIntValueFromControl(MinutesControl); }
        private int hours { get => GetIntValueFromControl(HoursControl); }
        private int daysInterval { get => GetIntValueFromControl(DaysInterval); }
        

        public SchedulePeriodPanel()
        {
            
            InitializeComponent();
            
        }

        public SchedulePeriodPanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            
        }

        public string GetCronExpression() 
        {
            var daysOfWeek = DaysOfWeek.Friday;
            
            switch (Type) 
            {
                case CronExpressionType.EveryNMinutes:
                    return CronExpression.EveryNMinutes(minutes);
                case CronExpressionType.EveryNHours:
                    return CronExpression.EveryNHours(hours);
                case CronExpressionType.EveryDayAt:
                    return CronExpression.EveryDayAt(hours,minutes);
                case CronExpressionType.EverySpecificDayAt:
                    return CronExpression.EverySpecificWeekDayAt(hours, minutes, GetSelectedDays());

            }
            return null;
        }

        /// <summary>
        /// Позволяет обойти все контролы рекурсивно в поисках тега
        /// </summary>
        /// <param name="controls"></param>
        private Control FindControlWithTag(Control.ControlCollection controls, string Tag)
        {

            foreach (Control c in this.Controls)
            {
                if (c.Tag != null && c.Tag.ToString() == Tag)
                    return c;

                    if (c.HasChildren)
                    FindControlWithTag(c.Controls, Tag); //Recursively check all children controls as well; ie groupboxes or tabpages
            }
            return null;
        }

        public int GetIntValueFromControl(Control control) 
        {
            Int32.TryParse(control?.Text, out var value);
            return value;
        }

        public void LoadPanel() 
        {
            MinutesControl = FindControlWithTag(this.Controls, "minutes");
            HoursControl = FindControlWithTag(this.Controls, "hours");
            SpecificDays = FindControlWithTag(this.Controls, "days");
            if (MinutesControl != null) 
            {
                var list = ((ComboBox)MinutesControl);
                for (int i = 1; i < 60; i++)
                {
                    list.Items.Add(i);
                }
                list.SelectedIndex = 0;
            }
            if (HoursControl != null)
            {
                var list = ((ComboBox)HoursControl);
                for (int i = 1; i < 24; i++)
                {
                    list.Items.Add(i);
                }
                list.SelectedIndex = 0;
            }
        }

        public DaysOfWeek GetSelectedDays() 
        {
            if (SpecificDays == null)
                throw new Exception("Контрол со списком дней не задан!");
            var checkBoxList = (CheckedListBox)SpecificDays;
            if (checkBoxList.CheckedItems.Count == 0)
                throw new Exception("Необходимо выбрать хотя бы один день!");
            DaysOfWeek daysOfWeek = DaysOfWeek.Monday;
            int index = 0;
            foreach (DaysOfWeek item in checkBoxList.CheckedItems)
            {
                if (index == 0)
                {
                    daysOfWeek = item;
                }
                else 
                {
                    daysOfWeek = daysOfWeek | item;
                }
                index++;
            }
            return daysOfWeek;
            
            
        }
        
    }

    
}
