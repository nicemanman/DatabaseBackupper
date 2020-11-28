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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(12, 298);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(230, 23);
            this.BackupButton.TabIndex = 1;
            this.BackupButton.Text = "Backup  now";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(13, 326);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(229, 23);
            this.DisconnectButton.TabIndex = 2;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(13, 34);
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(395, 20);
            this.Path.TabIndex = 3;
            // 
            // ChoosePath
            // 
            this.ChoosePath.Location = new System.Drawing.Point(414, 35);
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
            this.DatabasesList.Location = new System.Drawing.Point(13, 91);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(230, 199);
            this.DatabasesList.TabIndex = 7;
            // 
            // ProgressList
            // 
            this.ProgressList.HideSelection = false;
            this.ProgressList.Location = new System.Drawing.Point(248, 61);
            this.ProgressList.Name = "ProgressList";
            this.ProgressList.Size = new System.Drawing.Size(236, 229);
            this.ProgressList.TabIndex = 8;
            this.ProgressList.UseCompatibleStateImageBehavior = false;
            this.ProgressList.View = System.Windows.Forms.View.List;
            // 
            // Schedule
            // 
            this.Schedule.Location = new System.Drawing.Point(249, 298);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(235, 23);
            this.Schedule.TabIndex = 9;
            this.Schedule.Text = "Schedule this";
            this.Schedule.UseVisualStyleBackColor = true;
            this.Schedule.Click += new System.EventHandler(this.ScheduleButtonClick);
            // 
            // AllTasks
            // 
            this.AllTasks.Location = new System.Drawing.Point(249, 327);
            this.AllTasks.Name = "AllTasks";
            this.AllTasks.Size = new System.Drawing.Size(235, 23);
            this.AllTasks.TabIndex = 10;
            this.AllTasks.Text = "All tasks";
            this.AllTasks.UseVisualStyleBackColor = true;
            this.AllTasks.Click += new System.EventHandler(this.AllTasks_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 61);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Выбрать все";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BackupDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(496, 359);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AllTasks);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.ProgressList);
            this.Controls.Add(this.DatabasesList);
            this.Controls.Add(this.ChoosePath);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}