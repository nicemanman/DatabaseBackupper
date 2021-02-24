using Presentation.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class ConnectFormTest : UI.ParentForm, ILoginView
    {
        public ConnectFormTest()
        {
            InitializeComponent();
            
        }

        public List<string> SqlServers { set => throw new NotImplementedException(); }

        public string ServerName => throw new NotImplementedException();

        public List<string> LoginTypes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string LoginType => throw new NotImplementedException();

        public string Username => throw new NotImplementedException();

        public string Password => throw new NotImplementedException();

        public event Action Login;
        public event Action LoginTypeChanged;
        public event Action RefreshSQLServersList;

        public void SetMSSQLAuth()
        {
            throw new NotImplementedException();
        }

        public void SetWindowsAuth()
        {
            throw new NotImplementedException();
        }

        public void ShowError(string text)
        {
            throw new NotImplementedException();
        }
    }
}
