using DatabaseBackupper;
using DatabaseBackupperWindowsApp;
using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.ViewModels;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBackupperWindowsApp
{
    public partial class ConnectForm : Form
    {
        
        private Logger logger = LogManager.GetCurrentClassLogger();
       
        public ConnectForm()
        {
            InitializeComponent();
            Closed += (s, args) => { Application.Exit(); };
        }

        private void ConnectButton(object sender, EventArgs e)
        {
            try
            {
                logger.Info($"Подключение к базе данных");
                Status.Text = "Ожидайте...";
                var databases = new DatabasesManager(ServerName.Text, Username.Text, Password.Text);
                logger.Info($"Успешно подключились к базе данных, получили список базы данных");
                var loginData = new LoginData()
                {
                    ServerName = ServerName.Text,
                    UserName = Username.Text,
                    Password = Password.Text
                };
                
                BackupDatabaseForm form = new BackupDatabaseForm(databases, loginData);
                form.Show();
                Hide();
            }
            catch (Exception ex) 
            {
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


        
    }
}
