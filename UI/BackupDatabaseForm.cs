using System.Collections.Generic;
using System.Windows.Forms;
using Presentation.Views;
using System.Linq;
using System;
using System.IO;

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
            //нижняя панель с кнопками
            LogoutButton.Click += (s,e) => Logout();
            BackupButton.Click += (s,e) => Backup();
            OpenTasksButton.Click += (s, e) => OpenAllTasks();
            CreateTaskByTemplateButton.Click += (s, e) => CreateTaskByTemplate();
            //меню
            //бэкап
            BackupMenuButton.Click += (s, e) => Backup();
            CreateTaskByTemplateMenuButton.Click += (s,e) => CreateTaskByTemplate();
            //задачи
            OpenTasksMenuButton.Click += (s, e) => OpenAllTasks();
            CreateNewTaskMenuButton.Click += (s, e) => CreateNewTask();
            //расписания
            OpenSchedulesMenuButton.Click += (s, e) => OpenAllSchedules();
            CreateNewScheduleMenuButton.Click += (s, e) => CreateNewSchedule();

            SelectAllCheckbox.CheckedChanged += SelectAllCheckbox_CheckedChanged;
            ChoosePathButton.Click += ChoosePathButton_Click;
            
        }

       

        private void ChoosePathButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PathsToBackupCombobox.Text = fbd.SelectedPath;
                }
            }
        }

        private void SelectAllCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            for (var i = 0; i < DatabasesList.Items.Count; i++)
            {
                DatabasesList.SetItemChecked(i, SelectAllCheckbox.Checked);
            }
        }

        private void BackupDatabaseForm_Load(object sender, System.EventArgs e)
        {
            PathsToBackupCombobox.DataSource = PathsToBackup;
            foreach (var item in allDatabases)
            {
                DatabasesList.Items.Add(item);
            }
        }

        private string path;
        public string PathToBackup { get => PathsToBackupCombobox.Text; set => path = value; }

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

        public event Action Logout;
        public event Action Backup;
        public event Action CreateNewTask;
        public event Action CreateTaskByTemplate;
        public event Action OpenAllTasks;
        public event Action CreateNewSchedule;
        public event Action OpenAllSchedules;

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

        public List<string> PathsToBackup { get; set; }

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

        public void StartBackupProcess(Progress<string> backupProgress)
        {
            ProgressListBox.Items.Clear();
            backupProgress.ProgressChanged += BackupProgress_ProgressChanged;
            MenuStrip.Enabled = false;
            ToolButtonsPanel.Enabled = false;
        }

        private void BackupProgress_ProgressChanged(object sender, string e)
        {
            ProgressListBox.Items.Add(e);
        }

        public void EndBackupProcess()
        {
            MenuStrip.Enabled = true;
            ToolButtonsPanel.Enabled = true;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка валидации");
        }

       
    }
}
