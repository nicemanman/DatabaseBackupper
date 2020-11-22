﻿using DatabaseBackupper;
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
using System.Linq;
namespace DatabaseBackupperWindowsApp
{
    public partial class BackupDatabaseForm : Form
    {
        private Databases databases;
        private LoginData loginData;
        private BackupData backupData;
        Logger logger = LogManager.GetCurrentClassLogger();
        public BackupDatabaseForm(Databases databases, LoginData loginData)
        {
            InitializeComponent();
            this.databases = databases;
            this.loginData = loginData;
            Closed += (s, args) => {
                ConnectForm form = new ConnectForm();
                form.Show();
            };
        }

        private void BackupDatabaseForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < databases.Length; i++)
            {
                DatabasesList.Items.Add(databases[i]);
            }
            logger.Info($"Успешно загрузили базы данных с сервера");
            if (File.Exists(@"BackupData.json"))
            using (StreamReader file = File.OpenText(@"BackupData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                backupData = (BackupData)serializer.Deserialize(file, typeof(BackupData));
                Path.Text = backupData.Path;
                logger.Info($"Успешно загрузили путь бэкапа {Path.Text} из файла BackupData.json");
            }
        }


        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            ConnectForm form = new ConnectForm();
            form.Show();
            Close();
        }

        private async void BackupButton_Click(object sender, EventArgs e)
        {
            BackupButton.Enabled = false;
            DisconnectButton.Enabled = false;
            List<string> selectedDatabases = GetSelectedDatabases();
            try
            {
                logger.Info($"Начат бэкап баз данных");
                var tasks = new List<Task>();
                
                var progress = new Progress<string>(status =>
                {
                    ProgressList.Clear();
                    ProgressList.Items.Add(String.Join(Environment.NewLine, status));

                    logger.Info(status);
                });
                foreach (var database in selectedDatabases) 
                {
                    Func<Task> action = async () => await databases.Backup(database, Path.Text, progress);
                    tasks.Add(await Task.Factory.StartNew(action));
                }
                await Task.WhenAll(tasks.ToArray());
                ProgressList.Items.Add(new ListViewItem("Финиш"));
                logger.Info($"Бэкап баз данных завершен");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка", "Бэкап баз данных");
                logger.Error(ex);
            }
            BackupButton.Enabled = true;
            DisconnectButton.Enabled = true;
            //save data
            var backupData = new BackupData() { Path = Path.Text };
            using (StreamWriter file = File.CreateText(@"BackupData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, backupData);
                logger.Info($"Успешно записали путь бэкапа {Path.Text} в файл BackupData.json");
            }
        }

        private void ChoosePath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    Path.Text = fbd.SelectedPath;
                }
            }
        }

        private void ScheduleButtonClick(object sender, EventArgs e)
        {
            Hide();
            backupData = new BackupData()
            {
                AllDatabases = databases.DatabasesList,
                DatabasesToBackup = GetSelectedDatabases(),
                Path = Path.Text
            };
            TaskDetail details = new TaskDetail(new TaskData() { LoginData = loginData, BackupData = backupData, ID = Guid.NewGuid() }, this);
            details.Show();
        }
        public List<string> GetSelectedDatabases() 
        {
            List<string> selectedDatabases = new List<string>();
            foreach (var item in DatabasesList.CheckedItems)
            {
                selectedDatabases.Add(item as string);
            }
            return selectedDatabases;
        }
        private void AllTasks_Click(object sender, EventArgs e)
        {
            Hide();
            Tasks tasksForm = new Tasks(this, loginData, databases);
            tasksForm.Show();
        }
    }
}
