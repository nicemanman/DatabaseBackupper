using DatabaseBackupper;
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
    public partial class BackupDatabaseForm : Form
    {
        private Databases databases;
        Logger logger = LogManager.GetCurrentClassLogger();
        public BackupDatabaseForm(Databases databases)
        {
            InitializeComponent();
            this.databases = databases;
            Closed += (s, args) => Application.Exit();
        }

        private void BackupDatabaseForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < databases.Length; i++)
            {
                Databases.Items.Add(databases[i]);
            }
            if (File.Exists(@"BackupData.json"))
            using (StreamReader file = File.OpenText(@"BackupData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                BackupData data = (BackupData)serializer.Deserialize(file, typeof(BackupData));
                Path.Text = data.Path;
            }
        }


        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            ConnectForm form = new ConnectForm();
            form.Show();
            Hide();
        }

        private void BackupButton_Click(object sender, EventArgs e)
        {
            List<string> selectedDatabases = new List<string>();
            foreach (var item in Databases.CheckedItems)
            {
                selectedDatabases.Add(item as string);
            }
            try
            {
                databases.SetSettings(selectedDatabases, Path.Text);
                databases.Backup();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ошибка", "Бэкап баз данных");
            }
            //save data
            var backupData = new BackupData() { Path = Path.Text };
            using (StreamWriter file = File.CreateText(@"BackupData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, backupData);
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
    }
}
