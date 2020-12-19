using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginPanel.Location = new Point(
            this.ClientSize.Width / 2 - LoginPanel.Size.Width / 2,
            this.ClientSize.Height / 2 - LoginPanel.Size.Height / 2);
            LoginPanel.Anchor = AnchorStyles.None;
        }
    }
}
