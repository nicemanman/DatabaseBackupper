using DatabaseBackupper;
using DatabaseBackupperWindowsApp;
using Newtonsoft.Json;
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
        public ConnectForm()
        {
            InitializeComponent();
            Closed += (s, args) => { Application.Exit(); };
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                var databases = new Databases(ServerName.Text, UserName.Text, Password.Text);
                if (RememberMe.Checked) 
                {
                    var loginData = new LoginData()
                    {
                        ServerName = ServerName.Text,
                        UserName = UserName.Text,
                        Password = Password.Text
                    };
                    using (StreamWriter file = File.CreateText(@"LoginData.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, loginData);
                    }
                    
                }
                BackupDatabaseForm form = new BackupDatabaseForm(databases);
                
                form.Show();
                Hide();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(this,"Ошибка","Подключение к базе данных");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"LoginData.json"))
            using (StreamReader file = File.OpenText(@"LoginData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                LoginData data = (LoginData)serializer.Deserialize(file, typeof(LoginData));
                ServerName.Text = data.ServerName;
                UserName.Text = data.UserName;
                Password.Text = data.Password;
            }

        }
    }
}
