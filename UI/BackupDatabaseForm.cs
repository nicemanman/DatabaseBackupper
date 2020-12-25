﻿using System.Collections.Generic;
using System.Windows.Forms;
using Presentation.Views;
using System.Linq;

namespace UI
{
    public partial class BackupDatabaseForm : Form, IBackupView
    {
        private readonly ApplicationContext context;

        public BackupDatabaseForm(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            Load += BackupDatabaseForm_Load;
        }

        private void BackupDatabaseForm_Load(object sender, System.EventArgs e)
        {
            foreach (var item in allDatabases)
            {
                DatabasesList.Items.Add(item);
            }
        }
        private string path;
        public string PathToBackup { get => Path.Text; set => path = value; }
        private List<string> allDatabases;
        public List<string> AllDatabases {
            get
            {
                var list = new List<string>();
                foreach (var item in DatabasesList.Items)
                {
                    list.Add(item.ToString());
                }
                return list;
            }
            set => allDatabases = value;
        }
        private List<string> databasesToBackup;
        public List<string> DatabasesToBackup
        {
            get
            {
                var list = new List<string>();
                foreach (var item in DatabasesList.CheckedItems)
                {
                    list.Add(item.ToString());
                }
                return list;
            }
            set => databasesToBackup = value;
        }
        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }
        public void StopWaiting()
        {
            throw new System.NotImplementedException();
        }

        public void Wait()
        {
            throw new System.NotImplementedException();
        }
    }
}
