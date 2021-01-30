using Presentation.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
        }

        private void WhatTimeTaskFiredButton_Click(object sender, EventArgs e)
        {
            TimeTaskFired();
        }

        private void SaveTaskButton_Click(object sender, EventArgs e)
        {
            SaveTask();
        }

        private void AddNewScheduleButton_Click(object sender, EventArgs e)
        {
            AddNewSchedule();
            Reload();
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
    }
}
