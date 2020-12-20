﻿using DomainModel.Services;
using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ConnectForm : Form, ILoginView
    {
        private readonly ApplicationContext _context;
        public List<string> SqlServers { get; set; }
        public string ServerName { get => ServersList.SelectedItem as string; }
        public List<Enum> LoginTypes { get; set; }
        public LoginTypesEnumeration LoginType { get => (LoginTypesEnumeration)LoginTypesList.SelectedItem; }
        public string Username { get => UsernameTextbox.Text; }
        public string Password { get => PasswordTextbox.Text; }
        public event Action Login;
        

        public ConnectForm(ApplicationContext context)
        {
            InitializeComponent();
            ConnectButton.Click += ConnectButton_Click;
            this.Load += ConnectForm_Load;
            LoginTypesList.SelectedValueChanged += LoginTypesList_SelectedValueChanged;
            _context = context;
        }

        private void LoginTypesList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (LoginType == LoginTypesEnumeration.Windows)
            {
                UsernameTextbox.Enabled = false;
                PasswordTextbox.Enabled = false;
                UsernameTextbox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
            }
            else
            {
                UsernameTextbox.Text = "sa";
                UsernameTextbox.Enabled = true;
                PasswordTextbox.Enabled = true;
            }
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void ConnectForm_Load(object sender, EventArgs e)
        {
            LoginTypesList.DataSource = LoginTypes;
            ServersList.DataSource = SqlServers;
        }

        public new void Show() 
        {
            _context.MainForm = this;
            Application.Run(_context);
        }
    }
}