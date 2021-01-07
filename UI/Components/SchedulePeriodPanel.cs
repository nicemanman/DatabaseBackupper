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


        private int minutes { get { Int32.TryParse(MinutesControl.Text, out var value);  return value; } }
        private int hours { get { Int32.TryParse(HoursControl.Text, out var value);  return value; } }
        private int daysInterval { get { Int32.TryParse(HoursControl.Text, out var value);  return value; } }
        

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
            switch (Type) 
            {
                case CronExpressionType.EveryNMinutes:
                    return CronExpression.EveryNMinutes(minutes);
                case CronExpressionType.EveryNHours:
                    return CronExpression.EveryNHours(hours);
                case CronExpressionType.EveryDayAt:
                    return CronExpression.EveryDayAt(hours,minutes);
                case CronExpressionType.EverySpecificWeekDayAt:
                    return CronExpression.EverySpecificWeekDayAt(hours, minutes, DaysOfWeek.Friday | DaysOfWeek.Monday);

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
            Int32.TryParse(MinutesControl.Text, out var value);
            return value;
        }

        public void LoadPanel() 
        {
            MinutesControl = FindControlWithTag(this.Controls, "minutes");
            HoursControl = FindControlWithTag(this.Controls, "hours");
            SpecificDays = FindControlWithTag(this.Controls, "days");
        }
        
    }

    
}
