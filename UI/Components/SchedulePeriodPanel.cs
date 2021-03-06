﻿
using DomainModel.Components.CronBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DomainModel.Enums;

namespace UI.Components
{
    public partial class SchedulePeriodPanel : Panel
    {

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public CronExpressionType Type { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ComboBox MinutesControl { get; set; }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ComboBox HoursControl { get; set; }

       

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CheckedListBox SpecificDays { get; set; }


        public int minutes { get => GetIntValueFromControl(MinutesControl); }
        public int hours { get => GetIntValueFromControl(HoursControl); }
       
        

        public SchedulePeriodPanel()
        {
            InitializeComponent();
        }

        public SchedulePeriodPanel(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
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
            MinutesControl = (ComboBox)FindControlWithTag(this.Controls, "minutes");
            HoursControl = (ComboBox)FindControlWithTag(this.Controls, "hours");
            SpecificDays = (CheckedListBox)FindControlWithTag(this.Controls, "days");
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

        
    }

    
    
}
