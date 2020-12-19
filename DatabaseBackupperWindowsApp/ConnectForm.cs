
using DatabaseBackupperWindowsApp;
using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.Managers;
using DatabaseBackupperWindowsLibrary.ViewModels;
using LoadingIndicator.WinForms;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupperWindowsApp
{
    public partial class ConnectForm : Form
    {
        private Panel wait;
        private Thread thread;
        private Logger logger = LogManager.GetCurrentClassLogger();
        private LongOperation longOperation;
        
        public ConnectForm()
        {
            InitializeComponent();
            HeaderPanel.MouseMove += HeaderPanel_MouseMove;
            wait = new Panel();
            wait.Dock = DockStyle.Fill;
            wait.BackColor = Color.White;
            Controls.Add(wait);
            longOperation = new LongOperation(wait, LongOperationSettings.Default);
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

       

        private async void ConnectButton(object sender, EventArgs e)
        {
            try
            {
                var databases = new DatabasesManager(ServerName.Text, Username.Text, Password.Text);
                wait.BringToFront();
               
                using (longOperation.Start(true))
                {
                    databases.DatabasesList = await databases.GetAllOfThem();
                    await Task.Run(async () => await databases.InitStorage());
                }
                panel.BringToFront();
                logger.Info($"Подключение к базе данных");
                Status.Text = "Ожидайте...";
                logger.Info($"Успешно подключились к базе данных, получили список базы данных");
                var loginData = new LoginData()
                {
                    ServerName = ServerName.Text,
                    UserName = Username.Text,
                    Password = Password.Text
                };
                
                BackupDatabaseForm form = new BackupDatabaseForm(databases, loginData);
                Close();
                thread = new Thread(x => 
                {
                    Application.Run(form);
                });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            catch (Exception ex) 
            {
                panel.BringToFront();
                Status.Text = "Ошибка подключения к базе данных";
                logger.Error(ex);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlServersManager manager = new SqlServersManager();
            var sqlServers = manager.GetAllOfThem();
            ServerName.DataSource = sqlServers;
            Authentication.Items.Add("Windows");
            //Authentication.Items.Add("SQL Server");
            Authentication.SelectedIndexChanged += Authentication_SelectedIndexChanged;
            Authentication.SelectedIndex = 0;
            
        }

        private void Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Authentication.SelectedIndex == 0)
            {
                Username.Enabled = false;
                Password.Enabled = false;
                Username.Text = Environment.UserDomainName+"\\"+Environment.UserName;
            }
            else 
            {
                
                Username.Text = "sa";
                Username.Enabled = true;
                Password.Enabled = true;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
