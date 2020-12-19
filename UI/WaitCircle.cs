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
    public partial class WaitCircle : Form
    {
        public WaitCircle()
        {
            InitializeComponent();
            WaitCircleBox.Location = new Point(
            this.ClientSize.Width / 2 - WaitCircleBox.Size.Width / 2,
            this.ClientSize.Height / 2 - WaitCircleBox.Size.Height / 2);
            WaitCircleBox.Anchor = AnchorStyles.None;
        }
    }
}
