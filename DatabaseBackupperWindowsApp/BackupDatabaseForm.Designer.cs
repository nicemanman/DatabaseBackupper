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
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.ChoosePath = new System.Windows.Forms.Button();
            this.AllTasks = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.CheckBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.BackupNow = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ListView();
            this.DatabasesList = new System.Windows.Forms.CheckedListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(251, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Лог выполнения";
            // 
            // ChoosePath
            // 
            this.ChoosePath.Location = new System.Drawing.Point(421, 23);
            this.ChoosePath.Name = "ChoosePath";
            this.ChoosePath.Size = new System.Drawing.Size(70, 20);
            this.ChoosePath.TabIndex = 19;
            this.ChoosePath.Text = "path";
            this.ChoosePath.UseVisualStyleBackColor = true;
            this.ChoosePath.Click += new System.EventHandler(this.ChoosePath_Click_1);
            // 
            // AllTasks
            // 
            this.AllTasks.Location = new System.Drawing.Point(255, 320);
            this.AllTasks.Name = "AllTasks";
            this.AllTasks.Size = new System.Drawing.Size(235, 23);
            this.AllTasks.TabIndex = 23;
            this.AllTasks.Text = "All tasks";
            this.AllTasks.UseVisualStyleBackColor = true;
            this.AllTasks.Click += new System.EventHandler(this.AllTasks_Click_1);
            // 
            // Schedule
            // 
            this.Schedule.Location = new System.Drawing.Point(255, 291);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(235, 23);
            this.Schedule.TabIndex = 22;
            this.Schedule.Text = "Schedule this";
            this.Schedule.UseVisualStyleBackColor = true;
            this.Schedule.Click += new System.EventHandler(this.Schedule_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.AutoSize = true;
            this.SelectAll.Location = new System.Drawing.Point(20, 52);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(91, 17);
            this.SelectAll.TabIndex = 24;
            this.SelectAll.Text = "Выбрать все";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.CheckedChanged += new System.EventHandler(this.SelectAll_CheckedChanged);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(19, 319);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(229, 23);
            this.Disconnect.TabIndex = 17;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(20, 22);
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(395, 20);
            this.Path.TabIndex = 18;
            // 
            // BackupNow
            // 
            this.BackupNow.Location = new System.Drawing.Point(18, 291);
            this.BackupNow.Name = "BackupNow";
            this.BackupNow.Size = new System.Drawing.Size(230, 23);
            this.BackupNow.TabIndex = 16;
            this.BackupNow.Text = "Backup  now";
            this.BackupNow.UseVisualStyleBackColor = true;
            this.BackupNow.Click += new System.EventHandler(this.BackupNow_Click);
            // 
            // Progress
            // 
            this.Progress.HideSelection = false;
            this.Progress.Location = new System.Drawing.Point(255, 82);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(236, 199);
            this.Progress.TabIndex = 21;
            this.Progress.UseCompatibleStateImageBehavior = false;
            this.Progress.View = System.Windows.Forms.View.List;
            // 
            // DatabasesList
            // 
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(20, 82);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(230, 199);
            this.DatabasesList.TabIndex = 20;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.Progress);
            this.panel.Controls.Add(this.DatabasesList);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.BackupNow);
            this.panel.Controls.Add(this.ChoosePath);
            this.panel.Controls.Add(this.Path);
            this.panel.Controls.Add(this.AllTasks);
            this.panel.Controls.Add(this.Disconnect);
            this.panel.Controls.Add(this.Schedule);
            this.panel.Controls.Add(this.SelectAll);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(523, 379);
            this.panel.TabIndex = 27;
            // 
            // BackupDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 379);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupDatabaseForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.BackupDatabaseForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChoosePath;
        private System.Windows.Forms.Button AllTasks;
        private System.Windows.Forms.Button Schedule;
        private System.Windows.Forms.CheckBox SelectAll;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button BackupNow;
        private System.Windows.Forms.ListView Progress;
        private System.Windows.Forms.CheckedListBox DatabasesList;
        private System.Windows.Forms.Panel panel;
    }
}