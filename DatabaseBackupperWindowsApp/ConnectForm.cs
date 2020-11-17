using DatabaseBackupper;
using DatabaseBackupperWindowsApp;
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
        private LoginData loginData { get; set; }
        private Logger logger = LogManager.GetCurrentClassLogger();
        public ConnectForm()
        {
            InitializeComponent();
            Closed += (s, args) => { Application.Exit(); };
            RememberMe.Checked = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                logger.Info($"Подключение к базе данных");
                var databases = new Databases(ServerName.Text, UserName.Text, Password.Text);
                logger.Info($"Успешно подключились к базе данных, получили список базы данных");
                if (RememberMe.Checked) 
                {
                    logger.Info($"Запоминаем данные для входа");
                    var loginData = new LoginData()
                    {
                        ServerName = ServerName.Text,
                        UserName = UserName.Text,
                        Password = ""
                    };
                    logger.Info($"Записываем данные в файл LoginData.json");
                    using (StreamWriter file = File.CreateText(@"LoginData.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, loginData);
                        logger.Info($"Успешно записали данные в файл LoginData.json");
                    }
                    
                }
                BackupDatabaseForm form = new BackupDatabaseForm(databases);
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
                UserName.Text = data.UserName;
                Password.Text = data.Password;
            }

        }
    }
}
