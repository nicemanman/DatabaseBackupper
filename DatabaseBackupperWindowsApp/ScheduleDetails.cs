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
        public ScheduleDetails()
        {
            InitializeComponent();
            DayOfMonth.TextChanged += DayOfMonth_TextChanged;
            DayOfWeek.TextChanged += DayOfWeek_TextChanged;
        }

        private void DayOfWeek_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.Text != "?")
                DayOfMonth.Text = "?";
            
        }

        private void DayOfMonth_TextChanged(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.Text != "?")
                DayOfWeek.Text = "?";
        }
    }
}
