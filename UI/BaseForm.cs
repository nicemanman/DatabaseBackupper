using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Properties;

namespace UI
{
    public partial class BaseForm : Form
    {
        private readonly ResourceManager resourceManager;
        public BaseForm()
        {
            InitializeComponent();
            HeaderPanel.MouseMove += HeaderPanel_MouseMove;
            CloseAppButton.MouseEnter += CloseAppButton_MouseEnter;
            CloseAppButton.MouseLeave += CloseAppButton_MouseLeave;
            CloseAppButton.MouseClick += CloseAppButton_MouseClick;
            resourceManager = new ResourceManager("Resources", typeof(BaseForm).Assembly);
            OpenChildPanel(new WaitCircle());
        }

        private async void CloseAppButton_MouseClick(object sender, MouseEventArgs e)
        {
            var button = (PictureBox)sender;
            var image = Resources.Close_Square_Press;
            button.Image = image;
            await Task.Delay(50);
            Close();
        }

        private void CloseAppButton_MouseLeave(object sender, EventArgs e)
        {
            var button = (PictureBox)sender;
            var image = Resources.Close_SquareRed2;
            button.Image = image;
        }

        private void CloseAppButton_MouseEnter(object sender, EventArgs e)
        {
            var button = (PictureBox)sender;
            var image = Resources.Close_Square_Light;
            button.Image = image;
        }

        private Point MouseHook;
        private void HeaderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { Cursor = Cursors.Default; MouseHook = e.Location; }
            else
            {
                Location = new Point((Size)Location - (Size)MouseHook + (Size)e.Location);
                Cursor = Cursors.Hand;
            }
        }

        private Form activeForm = null;
        private void OpenChildPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

    }
}
