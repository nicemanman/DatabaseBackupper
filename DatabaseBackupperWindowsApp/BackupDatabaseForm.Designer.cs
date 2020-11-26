namespace DatabaseBackupperWindowsApp
{
    partial class BackupDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDatabaseForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BackupButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.ChoosePath = new System.Windows.Forms.Button();
            this.DatabasesList = new System.Windows.Forms.CheckedListBox();
            this.ProgressList = new System.Windows.Forms.ListView();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Schedule = new System.Windows.Forms.Button();
            this.AllTasks = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(11, 307);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(230, 23);
            this.BackupButton.TabIndex = 1;
            this.BackupButton.Text = "Backup  now";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(12, 335);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(229, 23);
            this.DisconnectButton.TabIndex = 2;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(13, 13);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(153, 20);
            this.Path.TabIndex = 3;
            // 
            // ChoosePath
            // 
            this.ChoosePath.Location = new System.Drawing.Point(173, 13);
            this.ChoosePath.Name = "ChoosePath";
            this.ChoosePath.Size = new System.Drawing.Size(70, 20);
            this.ChoosePath.TabIndex = 4;
            this.ChoosePath.Text = "path";
            this.ChoosePath.UseVisualStyleBackColor = true;
            this.ChoosePath.Click += new System.EventHandler(this.ChoosePath_Click);
            // 
            // DatabasesList
            // 
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(12, 40);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(230, 229);
            this.DatabasesList.TabIndex = 7;
            // 
            // ProgressList
            // 
            this.ProgressList.HideSelection = false;
            this.ProgressList.Location = new System.Drawing.Point(248, 40);
            this.ProgressList.Name = "ProgressList";
            this.ProgressList.Size = new System.Drawing.Size(236, 229);
            this.ProgressList.TabIndex = 8;
            this.ProgressList.UseCompatibleStateImageBehavior = false;
            this.ProgressList.View = System.Windows.Forms.View.List;
            // 
            // Schedule
            // 
            this.Schedule.Location = new System.Drawing.Point(249, 277);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(235, 23);
            this.Schedule.TabIndex = 9;
            this.Schedule.Text = "Schedule this";
            this.Schedule.UseVisualStyleBackColor = true;
            this.Schedule.Click += new System.EventHandler(this.ScheduleButtonClick);
            // 
            // AllTasks
            // 
            this.AllTasks.Location = new System.Drawing.Point(249, 306);
            this.AllTasks.Name = "AllTasks";
            this.AllTasks.Size = new System.Drawing.Size(235, 23);
            this.AllTasks.TabIndex = 10;
            this.AllTasks.Text = "All tasks";
            this.AllTasks.UseVisualStyleBackColor = true;
            this.AllTasks.Click += new System.EventHandler(this.AllTasks_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.Location = new System.Drawing.Point(11, 278);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(230, 23);
            this.SelectAll.TabIndex = 11;
            this.SelectAll.Text = "Select all";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // BackupDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 363);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.AllTasks);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.ProgressList);
            this.Controls.Add(this.DatabasesList);
            this.Controls.Add(this.ChoosePath);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.BackupButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupDatabaseForm";
            this.Text = "Бэкап баз данных";
            this.Load += new System.EventHandler(this.BackupDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button ChoosePath;
        private System.Windows.Forms.CheckedListBox DatabasesList;
        private System.Windows.Forms.ListView ProgressList;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.Button AllTasks;
        private System.Windows.Forms.Button SelectAll;
    }
}