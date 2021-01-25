using DomainModel;
using DomainModel.Services;
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
        public List<string> SqlServers 
        { 
            set 
            {
                if (value.Count == 0)
                    OpenChildPanel(new SQLServersNotFound(() => { RefreshSQLServersList(); }));
                ServersList.DataSource = value;
            } 
        }
        public List<string> LoginTypes { get; set; }
        public string ServerName { get => ServersList.SelectedItem as string; }
        public string LoginType { get => LoginTypesList.SelectedItem.ToString(); }
        public string Username { get => UsernameTextbox.Text; }
        public string Password { get => PasswordTextbox.Text; }
        public event Action Login;
        public event Action LoginTypeChanged;
        public event Action RefreshSQLServersList;

        private enum Test { Test1, Test2 };
        private List<string> ReadableList = new List<string>() { "Тестовый вариант 1","Тестовый вариант 2" };

        public ConnectForm(ApplicationContext context)
        {
            InitializeComponent();
            ConnectButton.Click += ConnectButton_Click;
            this.Load += ConnectForm_Load;
            LoginTypesList.SelectedValueChanged += LoginTypesList_SelectedValueChanged;
            UpdateServersListButton.Click += UpdateServersListButton_Click;
            _context = context;
        }

        private void UpdateServersListButton_Click(object sender, EventArgs e)
        {
            RefreshSQLServersList();
        }

        private void LoginTypesList_SelectedValueChanged(object sender, EventArgs e)
        {
            LoginTypeChanged();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void ConnectForm_Load(object sender, EventArgs e)
        {
            LoginTypesList.DataSource = LoginTypes;
        }

        public new void Show() 
        {
            if (_context.MainForm == null) 
            {
                _context.MainForm = this;
                Application.Run(_context);
                return;
            }
            _context.MainForm = this;
            base.Show();
        }

        public void Wait(string text = null)
        {
            if (text == null)
                OpenChildPanel(new WaitForm("Подключаемся к SQL серверу..."));
            else
                OpenChildPanel(new WaitForm(text));
        }

        public void StopWaiting()
        {
            if (activeForm != null)
                activeForm.Close();
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

        public void ShowError(string text)
        {
            StatusBar.Text = "Не удалось подключиться:(";
            StatusBar.BackColor = Color.Red;
            MessageBox.Show(text, "Ошибка подключения");
        }

        public void SetMSSQLAuth()
        {
            UsernameTextbox.Text = "sa";
            UsernameTextbox.Enabled = true;
            PasswordTextbox.Enabled = true;
        }

        public void SetWindowsAuth()
        {
            UsernameTextbox.Enabled = false;
            PasswordTextbox.Enabled = false;
            UsernameTextbox.Text = Environment.UserDomainName + "\\" + Environment.UserName;
            PasswordTextbox.Text = "";
        }

        public void Wait(Progress<string> progress)
        {
            OpenChildPanel(new WaitForm(progress));
        }

        
    }
}
