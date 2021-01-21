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
        public List<string> SqlServers { get; set; }
        public List<Enum> LoginTypes { get; set; }
        public string ServerName { get => ServersList.SelectedItem as string; }
        public Enums.LoginTypesEnumeration LoginType { get => (Enums.LoginTypesEnumeration)LoginTypesList.SelectedItem; }
        public string Username { get => UsernameTextbox.Text; }
        public string Password { get => PasswordTextbox.Text; }
        public event Action Login;
        private enum Test { Test1, Test2 };
        private List<string> ReadableList = new List<string>() { "Тестовый вариант 1","Тестовый вариант 2" };

        public ConnectForm(ApplicationContext context)
        {
            InitializeComponent();
            ConnectButton.Click += ConnectButton_Click;
            this.Load += ConnectForm_Load;
            LoginTypesList.SelectedValueChanged += LoginTypesList_SelectedValueChanged;
            _context = context;

            var TestEnumList = SelectList.Of<Test>();
            ReadableEnumeration readableEnumeration = new ReadableEnumeration(ReadableList, TestEnumList);
            
            var readableList = readableEnumeration.GetReadableList();
            var testResult = readableEnumeration.GetSelectedEnum("Тестовый вариант 1");
        }

        private void LoginTypesList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (LoginType == Enums.LoginTypesEnumeration.Windows)
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
            if (_context.MainForm == null) 
            {
                _context.MainForm = this;
                Application.Run(_context);
                return;
            }
            _context.MainForm = this;
            base.Show();
        }

        public void Wait()
        {
            OpenChildPanel(new WaitForm("Подключаемся к SQL серверу..."));
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
            StatusBar.Text = text;
            StatusBar.BackColor = Color.Red;
        }
    }
}
