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
    public partial class BackupLocalOrGoogle : Form
    {
        private readonly Action backupLocal;
        private readonly Action backupGoogle;
        private readonly Action reauthorizeAction;

        public BackupLocalOrGoogle(Action localAction, Action googleAction, Action reauthorizeAction)
        {
            InitializeComponent();
            this.backupLocal = localAction;
            this.backupGoogle = googleAction;
            this.reauthorizeAction = reauthorizeAction;
            LocalButton.Click += LocalButton_Click;
            GoogleButton.Click += GoogleButton_Click;
            Reauthorize.Click += Reauthorize_Click;
        }

        private void Reauthorize_Click(object sender, EventArgs e)
        {
            reauthorizeAction();
            Close();
        }

        private void GoogleButton_Click(object sender, EventArgs e)
        {
            backupGoogle();
            Close();
        }

        private void LocalButton_Click(object sender, EventArgs e)
        {
            backupLocal();
            Close();
        }
    }
}
