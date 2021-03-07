using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
namespace UI
{
    public partial class TaskDetail : Form, ITaskDetailsView
    {
        
        public TaskDetail()
        {
            InitializeComponent();
            AddNewScheduleButton.Click += AddNewScheduleButton_Click;
            SaveTaskButton.Click += SaveTaskButton_Click;
            WhatTimeTaskFiredButton.Click += WhatTimeTaskFiredButton_Click;
            ChoosePathButton.Click += ChoosePathButton_Click;
        }

        private void WhatTimeTaskFiredButton_Click(object sender, EventArgs e)
        {
            TimeTaskFired?.Invoke();
        }

        private void SaveTaskButton_Click(object sender, EventArgs e)
        {
            SaveTask?.Invoke();
        }

        private void AddNewScheduleButton_Click(object sender, EventArgs e)
        {
            AddNewSchedule?.Invoke();
            Reload?.Invoke();
        }

        public List<string> SchedulesList { 
            set
            {
                ScheduleDropDownList.DataSource = value;
            } 
        }
        public List<string> EmailsList {
            set
            {
                EmailsDropDownList.DataSource = value;
            }
        }
        public List<string> PathsToBackup 
        { 
            set
            {
                PathsToBackupCombobox.DataSource = value;
            }
        }

        public string SelectedSchedule
        {
            get => ScheduleDropDownList.SelectedItem.ToString();
            set
            {
                foreach (var item in ScheduleDropDownList.Items)
                {
                    if (item.ToString() == value)
                    {
                        ScheduleDropDownList.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        public string SelectedEmail
        {
            get => EmailsDropDownList.Text;
            set
            {
                foreach (var item in EmailsDropDownList.Items)
                {
                    if (item.ToString() == value)
                    {
                        EmailsDropDownList.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        public string SelectedPath { 
            get => PathsToBackupCombobox.Text;
            set
            {
                foreach (var item in PathsToBackupCombobox.Items)
                {
                    if (item.ToString() == value)
                    {
                        PathsToBackupCombobox.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        public bool NotifyAboutFinish { get => NotifyCheckbox.Checked; set => NotifyCheckbox.Checked = value; }
        public bool TaskIsEnables { get => TaskEnabledCheckBox.Checked; set => TaskEnabledCheckBox.Checked = value; }
        public string Caption { get => TaskName.Text; set { TaskName.Text = value; this.Text = value; } }

        public List<string> DatabasesList {
            set
            {
                DatabasesCheckedBoxList.DataSource = value;
            }
        }
        public List<string> SelectedDatabasesList { 
            get 
            {
                var selectedDatabases = new List<string>();
                foreach (var database in DatabasesCheckedBoxList.CheckedItems)
                {
                    selectedDatabases.Add(database.ToString());
                }
                return selectedDatabases;
            }
            set 
            { 
                foreach (var database in value)
                {
                    for (int i = 0; i < DatabasesCheckedBoxList.Items.Count; i++) 
                    {
                        var item = DatabasesCheckedBoxList.Items[i];
                        if (item.ToString() == database) 
                        {
                            DatabasesCheckedBoxList.SetItemChecked(i, true);
                        }
                    }
                }
            } 
        }

        public string SQLServer { get => ServerName.Text; set => ServerName.Text = value; }
        public int Id { get; set; }

        public event Action Reload;
        public event Action AddNewSchedule;
        public event Action SaveTask;
        public event Action TimeTaskFired;

        public new void Show()
        {
            ShowDialog();
        }
        public void StopWaiting()
        {
            throw new NotImplementedException();
        }
        //TODO - Надо будет переместь методы в общую форму, и наследоваться от нее вместо Form
        public void Wait(string text = null)
        {
            throw new NotImplementedException();
        }

        public void Wait(Progress<string> progres)
        {
            throw new NotImplementedException();
        }

        public void ShowMessage(string text)
        {
            MessageBox.Show(text, "Сообщение");
        }
        public void ShowError(string text) 
        {
            MessageBox.Show(text, "Ошибка валидации");
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
    }
}
