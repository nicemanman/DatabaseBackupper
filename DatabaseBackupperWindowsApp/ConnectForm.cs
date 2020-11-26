using DatabaseBackupper;
using DatabaseBackupperWindowsApp;
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
                var databases = new DatabasesManager(ServerName.Text, "", "");
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
                MessageBox.Show(this,"Ошибка","Подключение к базе данных");
                logger.Error(ex);
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"LoginData.json"))
            using (StreamReader file = File.OpenText(@"LoginData.json"))
            {
                logger.Info($"Не первое подключение!");
                logger.Info($"Успешно прочитали файл LoginData.json");
                JsonSerializer serializer = new JsonSerializer();
                LoginData data = (LoginData)serializer.Deserialize(file, typeof(LoginData));
                ServerName.Text = data.ServerName;
            }

        }
    }
}
