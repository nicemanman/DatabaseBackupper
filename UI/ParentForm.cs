using Presentation.Common;
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
    public partial class ParentForm : Form, IView
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        public void StopWaiting()
        {
            throw new NotImplementedException();
        }

        public void Wait(string text = null)
        {
            MessageBox.Show("BRUH");
        }

        public void Wait(Progress<string> progres)
        {
            throw new NotImplementedException();
        }
    }
}
