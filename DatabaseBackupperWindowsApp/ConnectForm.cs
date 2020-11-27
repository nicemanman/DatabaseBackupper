using DatabaseBackupper;
using DatabaseBackupperWindowsApp;
using DatabaseBackupperWindowsLibrary;
using DatabaseBackupperWindowsLibrary.Models;
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
        private bool winAuth = true;
        public ConnectForm()
        {
            InitializeComponent();
            Closed += (s, args) => { Application.Exit(); };
            RememberMe.Checked = true;
        }

        private void ConnectButton(object sender, EventArgs e)
        {
            try
            {
                logger.Info($"Подключение к базе данных");
                Status.Text = "Ожидайте...";
                var databases = new DatabasesManager(ServerName.Text, Username.Text, Password.Text, winAuth);
                logger.Info($"Успешно подключились к базе данных, получили список базы данных");
                var loginData = new LoginData()
                {
                    ServerName = ServerName.Text,
                    UserName = "",
                    Password = ""
                };
                if (RememberMe.Checked) 
                {
                    logger.Info($"Запоминаем данные для входа");
                    logger.Info($"Записываем данные в файл LoginData.json");
                    using (StreamWriter file = File.CreateText(@"LoginData.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, loginData);
                        logger.Info($"Успешно записали данные в файл LoginData.json");
                    }
                }
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
            Authentication.Items.Add("SQL Server");
            Authentication.SelectedIndexChanged += Authentication_SelectedIndexChanged;
            Authentication.SelectedIndex = 0;
            
        }

        private void Authentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Authentication.SelectedIndex == 0)
            {
                winAuth = true;
                Username.Enabled = false;
                Password.Enabled = false;
                Username.Text = Environment.UserDomainName+"\\"+Environment.UserName;
            }
            else 
            {
                winAuth = false;
                Username.Text = "sa";
                Username.Enabled = true;
                Password.Enabled = true;
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void RememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
