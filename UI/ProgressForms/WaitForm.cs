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
    public partial class WaitForm : Form
    {
        public WaitForm(string statusText)
        {
            InitializeComponent();
            StatusLabel.Text = statusText;
        }

        public WaitForm(Progress<string> progress)
        {
            InitializeComponent();
            progress.ProgressChanged += Progress_ProgressChanged;
            
        }

        private void Progress_ProgressChanged(object sender, string e)
        {
            StatusLabel.Text = e;
        }
    }
}
