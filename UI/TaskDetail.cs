using Presentation.Views;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class TaskDetail : Form, ITaskDetailsView
    {
        
        public TaskDetail()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            ShowDialog();
        }
        public void StopWaiting()
        {
            throw new NotImplementedException();
        }

        public void Wait(string text = null)
        {
            throw new NotImplementedException();
        }

        public void Wait(Progress<string> progres)
        {
            throw new NotImplementedException();
        }
    }
}
