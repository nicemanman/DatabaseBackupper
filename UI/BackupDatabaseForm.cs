using System.Collections.Generic;
using System.Windows.Forms;
using Presentation.Views;
using System.Linq;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UI
{
    public partial class BackupDatabaseForm : Form, IBackupView
    {
        private readonly ApplicationContext context;
        private int toolTipIndex = -1;
        public BackupDatabaseForm(ApplicationContext _context)
        {
            context = _context;
            InitializeComponent();
            Load += BackupDatabaseForm_Load;
            //нижняя панель с кнопками
            LogoutButton.Click += (s,e) => Logout();
            BackupButton.Click += (s,e)=>Backup();
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
            //справка
            AboutProgrammMenuButton.Click += (s, e) => OpenAboutProgram();
            AboutAuthorMenuButton.Click += (s, e) => OpenAboutAuthor();

            SelectAllCheckbox.CheckedChanged += SelectAllCheckbox_CheckedChanged;
            ChoosePathButton.Click += ChoosePathButton_Click;
            ProgressListBox.MouseDoubleClick += ProgressListBox_MouseDoubleClick;
            DatabasesList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.showCheckBoxToolTip);

            OpenFolder.Click += OpenFolder_Click;
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            
            if (Directory.Exists(PathsToBackupCombobox.Text))
            {
                Process.Start(PathsToBackupCombobox.Text);
            }
            else 
            {
                ShowError("Данного пути не существует!");
            }
        }

        private void showCheckBoxToolTip(object sender, MouseEventArgs e)
        {
            var checkedListBox = (CheckedListBox)sender;
            if (toolTipIndex != checkedListBox.IndexFromPoint(e.Location))
            {
                toolTipIndex = checkedListBox.IndexFromPoint(checkedListBox.PointToClient(MousePosition));
                if (toolTipIndex > -1)
                {
                    tooltip.SetToolTip(checkedListBox, checkedListBox.Items[toolTipIndex].ToString());
                }
            }
        }

        private void ProgressListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listbox = (ListBox)sender;
            int index = listbox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(listbox.Items[index].ToString());
            }
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
        public event Action OpenAboutAuthor;
        public event Action OpenAboutProgram;

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
            if (activeForm != null)
                activeForm.Close();
        }

        public void Wait(Progress<string> progress)
        {
            OpenChildPanel(new WaitForm(progress));
        }

        private Form activeForm = null;
        private void OpenChildPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ChildPanel.Controls.Add(childForm);
            ChildPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void StartBackupProcess(Progress<string> backupProgress, Progress<string> detailsProgress)
        {
            ProgressListBox.Items.Clear();
            backupProgress.ProgressChanged += BackupProgress_ProgressChanged;
            MenuStrip.Visible = false;
            Wait(detailsProgress);
        }


        private void BackupProgress_ProgressChanged(object sender, string e)
        {
            ProgressListBox.Items.Add(e);
        }

        public void EndBackupProcess()
        {
            StopWaiting();
            MenuStrip.Visible = true;
        }

        public void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка валидации");
        }

        public void ShowSuccess(string message)
        {
            MessageBox.Show(message, "Успех");
        }

        public void Wait(string text = null)
        {
            if (text == null)
                OpenChildPanel(new WaitForm("Ожидайте..."));
            else
                OpenChildPanel(new WaitForm(text));
        }
    }
}
