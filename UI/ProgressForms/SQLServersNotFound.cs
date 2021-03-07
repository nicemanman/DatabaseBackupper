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
    public partial class SQLServersNotFound : Form
    {
        private event Action action;
        public SQLServersNotFound(Action a)
        {
            InitializeComponent();
            action = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            action?.Invoke();
        }
    }
}
