namespace UI
{
    partial class TaskDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetail));
            this.label1 = new System.Windows.Forms.Label();
            this.DatabasesList = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SaveTaskButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ServerName = new System.Windows.Forms.Label();
            this.ScheduleDropDownList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailsDropDownList = new System.Windows.Forms.ComboBox();
            this.NotifyCheckbox = new System.Windows.Forms.CheckBox();
            this.TaskEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.AddNewScheduleButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PathsToBackupCombobox = new System.Windows.Forms.ComboBox();
            this.ChoosePathButton = new System.Windows.Forms.Button();
            this.WhatTimeTaskFiredButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сервер";
            // 
            // DatabasesList
            // 
            this.DatabasesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(13, 66);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(470, 184);
            this.DatabasesList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Расписание";
            // 
            // SaveTaskButton
            // 
            this.SaveTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveTaskButton.Location = new System.Drawing.Point(353, 343);
            this.SaveTaskButton.Name = "SaveTaskButton";
            this.SaveTaskButton.Size = new System.Drawing.Size(130, 23);
            this.SaveTaskButton.TabIndex = 9;
            this.SaveTaskButton.Text = "Сохранить";
            this.SaveTaskButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название";
            // 
            // TaskName
            // 
            this.TaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskName.Location = new System.Drawing.Point(76, 14);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(407, 20);
            this.TaskName.TabIndex = 10;
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerName.Location = new System.Drawing.Point(73, 41);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(38, 13);
            this.ServerName.TabIndex = 13;
            this.ServerName.Text = "Server";
            // 
            // ScheduleDropDownList
            // 
            this.ScheduleDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleDropDownList.FormattingEnabled = true;
            this.ScheduleDropDownList.Location = new System.Drawing.Point(87, 257);
            this.ScheduleDropDownList.Name = "ScheduleDropDownList";
            this.ScheduleDropDownList.Size = new System.Drawing.Size(364, 21);
            this.ScheduleDropDownList.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.WhatTimeTaskFiredButton);
            this.panel1.Controls.Add(this.EmailsDropDownList);
            this.panel1.Controls.Add(this.NotifyCheckbox);
            this.panel1.Controls.Add(this.TaskEnabledCheckBox);
            this.panel1.Controls.Add(this.AddNewScheduleButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PathsToBackupCombobox);
            this.panel1.Controls.Add(this.ChoosePathButton);
            this.panel1.Controls.Add(this.SaveTaskButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 378);
            this.panel1.TabIndex = 17;
            // 
            // EmailsDropDownList
            // 
            this.EmailsDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailsDropDownList.FormattingEnabled = true;
            this.EmailsDropDownList.Location = new System.Drawing.Point(156, 310);
            this.EmailsDropDownList.Name = "EmailsDropDownList";
            this.EmailsDropDownList.Size = new System.Drawing.Size(295, 21);
            this.EmailsDropDownList.TabIndex = 36;
            // 
            // NotifyCheckbox
            // 
            this.NotifyCheckbox.AutoSize = true;
            this.NotifyCheckbox.Location = new System.Drawing.Point(16, 312);
            this.NotifyCheckbox.Name = "NotifyCheckbox";
            this.NotifyCheckbox.Size = new System.Drawing.Size(134, 17);
            this.NotifyCheckbox.TabIndex = 35;
            this.NotifyCheckbox.Text = "Уведомлять на почту";
            this.NotifyCheckbox.UseVisualStyleBackColor = true;
            // 
            // TaskEnabledCheckBox
            // 
            this.TaskEnabledCheckBox.AutoSize = true;
            this.TaskEnabledCheckBox.Checked = true;
            this.TaskEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TaskEnabledCheckBox.Location = new System.Drawing.Point(16, 335);
            this.TaskEnabledCheckBox.Name = "TaskEnabledCheckBox";
            this.TaskEnabledCheckBox.Size = new System.Drawing.Size(119, 17);
            this.TaskEnabledCheckBox.TabIndex = 34;
            this.TaskEnabledCheckBox.Text = "Выполнять задачу";
            this.TaskEnabledCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddNewScheduleButton
            // 
            this.AddNewScheduleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNewScheduleButton.Location = new System.Drawing.Point(457, 255);
            this.AddNewScheduleButton.Name = "AddNewScheduleButton";
            this.AddNewScheduleButton.Size = new System.Drawing.Size(26, 23);
            this.AddNewScheduleButton.TabIndex = 33;
            this.AddNewScheduleButton.Text = "+";
            this.AddNewScheduleButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddNewScheduleButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Путь";
            // 
            // PathsToBackupCombobox
            // 
            this.PathsToBackupCombobox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathsToBackupCombobox.FormattingEnabled = true;
            this.PathsToBackupCombobox.Location = new System.Drawing.Point(87, 285);
            this.PathsToBackupCombobox.Name = "PathsToBackupCombobox";
            this.PathsToBackupCombobox.Size = new System.Drawing.Size(364, 21);
            this.PathsToBackupCombobox.TabIndex = 31;
            // 
            // ChoosePathButton
            // 
            this.ChoosePathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoosePathButton.Location = new System.Drawing.Point(457, 285);
            this.ChoosePathButton.Name = "ChoosePathButton";
            this.ChoosePathButton.Size = new System.Drawing.Size(26, 21);
            this.ChoosePathButton.TabIndex = 30;
            this.ChoosePathButton.Text = "...";
            this.ChoosePathButton.UseVisualStyleBackColor = true;
            // 
            // WhatTimeTaskFiredButton
            // 
            this.WhatTimeTaskFiredButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WhatTimeTaskFiredButton.Location = new System.Drawing.Point(156, 343);
            this.WhatTimeTaskFiredButton.Name = "WhatTimeTaskFiredButton";
            this.WhatTimeTaskFiredButton.Size = new System.Drawing.Size(191, 23);
            this.WhatTimeTaskFiredButton.TabIndex = 37;
            this.WhatTimeTaskFiredButton.Text = "Когда будет выполнена задача?";
            this.WhatTimeTaskFiredButton.UseVisualStyleBackColor = true;
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 378);
            this.Controls.Add(this.ScheduleDropDownList);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabasesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TaskDetail";
            this.Text = "Детали задачи";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox DatabasesList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveTaskButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TaskName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.ComboBox ScheduleDropDownList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddNewScheduleButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PathsToBackupCombobox;
        private System.Windows.Forms.Button ChoosePathButton;
        private System.Windows.Forms.CheckBox TaskEnabledCheckBox;
        private System.Windows.Forms.ComboBox EmailsDropDownList;
        private System.Windows.Forms.CheckBox NotifyCheckbox;
        private System.Windows.Forms.Button WhatTimeTaskFiredButton;
    }
}