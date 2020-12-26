namespace UI
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
            System.Windows.Forms.ToolStripMenuItem AllSchedulesMenuButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDatabaseForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.ChoosePath = new System.Windows.Forms.Button();
            this.AllTasks = new System.Windows.Forms.Button();
            this.Schedule = new System.Windows.Forms.Button();
            this.SelectAll = new System.Windows.Forms.CheckBox();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.BackupNow = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ListView();
            this.DatabasesList = new System.Windows.Forms.CheckedListBox();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.базыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ScheduleTaskMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllTasksMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewTask = new System.Windows.Forms.ToolStripMenuItem();
            this.расписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewScheduleMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            AllSchedulesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AllSchedulesMenuButton
            // 
            AllSchedulesMenuButton.Name = "AllSchedulesMenuButton";
            AllSchedulesMenuButton.Size = new System.Drawing.Size(221, 22);
            AllSchedulesMenuButton.Text = "Все расписания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(251, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Лог выполнения";
            // 
            // ChoosePath
            // 
            this.ChoosePath.Location = new System.Drawing.Point(421, 47);
            this.ChoosePath.Name = "ChoosePath";
            this.ChoosePath.Size = new System.Drawing.Size(70, 20);
            this.ChoosePath.TabIndex = 19;
            this.ChoosePath.Text = "Путь";
            this.ChoosePath.UseVisualStyleBackColor = true;
            // 
            // AllTasks
            // 
            this.AllTasks.Location = new System.Drawing.Point(255, 344);
            this.AllTasks.Name = "AllTasks";
            this.AllTasks.Size = new System.Drawing.Size(235, 23);
            this.AllTasks.TabIndex = 23;
            this.AllTasks.Text = "Все задачи";
            this.AllTasks.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            this.Schedule.Location = new System.Drawing.Point(255, 315);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(235, 23);
            this.Schedule.TabIndex = 22;
            this.Schedule.Text = "Создать задачу";
            this.Schedule.UseVisualStyleBackColor = true;
            // 
            // SelectAll
            // 
            this.SelectAll.AutoSize = true;
            this.SelectAll.Location = new System.Drawing.Point(20, 76);
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(91, 17);
            this.SelectAll.TabIndex = 24;
            this.SelectAll.Text = "Выбрать все";
            this.SelectAll.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(19, 343);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(229, 23);
            this.LogoutButton.TabIndex = 17;
            this.LogoutButton.Text = "Отключиться";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(20, 46);
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(395, 20);
            this.Path.TabIndex = 18;
            // 
            // BackupNow
            // 
            this.BackupNow.Location = new System.Drawing.Point(18, 315);
            this.BackupNow.Name = "BackupNow";
            this.BackupNow.Size = new System.Drawing.Size(230, 23);
            this.BackupNow.TabIndex = 16;
            this.BackupNow.Text = "Бэкап";
            this.BackupNow.UseVisualStyleBackColor = true;
            // 
            // Progress
            // 
            this.Progress.HideSelection = false;
            this.Progress.Location = new System.Drawing.Point(255, 106);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(236, 199);
            this.Progress.TabIndex = 21;
            this.Progress.UseCompatibleStateImageBehavior = false;
            this.Progress.View = System.Windows.Forms.View.List;
            // 
            // DatabasesList
            // 
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(20, 106);
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
            this.panel.Controls.Add(this.LogoutButton);
            this.panel.Controls.Add(this.Schedule);
            this.panel.Controls.Add(this.SelectAll);
            this.panel.Controls.Add(this.menuStrip1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(523, 379);
            this.panel.TabIndex = 27;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базыДанныхToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.расписанияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // базыДанныхToolStripMenuItem
            // 
            this.базыДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackupMenuButton,
            this.ScheduleTaskMenuButton});
            this.базыДанныхToolStripMenuItem.Name = "базыДанныхToolStripMenuItem";
            this.базыДанныхToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.базыДанныхToolStripMenuItem.Text = "Базы данных";
            // 
            // BackupMenuButton
            // 
            this.BackupMenuButton.Name = "BackupMenuButton";
            this.BackupMenuButton.Size = new System.Drawing.Size(156, 22);
            this.BackupMenuButton.Text = "Бэкап";
            // 
            // ScheduleTaskMenuButton
            // 
            this.ScheduleTaskMenuButton.Name = "ScheduleTaskMenuButton";
            this.ScheduleTaskMenuButton.Size = new System.Drawing.Size(156, 22);
            this.ScheduleTaskMenuButton.Text = "Создать задачу";
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllTasksMenuButton,
            this.CreateNewTask});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // AllTasksMenuButton
            // 
            this.AllTasksMenuButton.Name = "AllTasksMenuButton";
            this.AllTasksMenuButton.Size = new System.Drawing.Size(195, 22);
            this.AllTasksMenuButton.Text = "Все задачи";
            // 
            // CreateNewTask
            // 
            this.CreateNewTask.Name = "CreateNewTask";
            this.CreateNewTask.Size = new System.Drawing.Size(195, 22);
            this.CreateNewTask.Text = "Создать новую задачу";
            // 
            // расписанияToolStripMenuItem
            // 
            this.расписанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            AllSchedulesMenuButton,
            this.CreateNewScheduleMenuButton});
            this.расписанияToolStripMenuItem.Name = "расписанияToolStripMenuItem";
            this.расписанияToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.расписанияToolStripMenuItem.Text = "Расписания";
            // 
            // CreateNewScheduleMenuButton
            // 
            this.CreateNewScheduleMenuButton.Name = "CreateNewScheduleMenuButton";
            this.CreateNewScheduleMenuButton.Size = new System.Drawing.Size(221, 22);
            this.CreateNewScheduleMenuButton.Text = "Создать новое расписание";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgramm,
            this.AboutAuthor});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutProgramm
            // 
            this.AboutProgramm.Name = "AboutProgramm";
            this.AboutProgramm.Size = new System.Drawing.Size(149, 22);
            this.AboutProgramm.Text = "О программе";
            // 
            // AboutAuthor
            // 
            this.AboutAuthor.Name = "AboutAuthor";
            this.AboutAuthor.Size = new System.Drawing.Size(149, 22);
            this.AboutAuthor.Text = "Об авторе";
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BackupDatabaseForm";
            this.Text = " ";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button BackupNow;
        private System.Windows.Forms.ListView Progress;
        private System.Windows.Forms.CheckedListBox DatabasesList;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem базыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackupMenuButton;
        private System.Windows.Forms.ToolStripMenuItem ScheduleTaskMenuButton;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllTasksMenuButton;
        private System.Windows.Forms.ToolStripMenuItem CreateNewTask;
        private System.Windows.Forms.ToolStripMenuItem расписанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramm;
        private System.Windows.Forms.ToolStripMenuItem AboutAuthor;
        private System.Windows.Forms.ToolStripMenuItem CreateNewScheduleMenuButton;
    }
}