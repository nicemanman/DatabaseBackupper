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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDatabaseForm));
            this.OpenSchedulesMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.ChoosePathButton = new System.Windows.Forms.Button();
            this.OpenTasksButton = new System.Windows.Forms.Button();
            this.CreateTaskByTemplateButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.DatabasesList = new System.Windows.Forms.CheckedListBox();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.PathsToBackupCombobox = new System.Windows.Forms.ComboBox();
            this.backupPathContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgressListBox = new System.Windows.Forms.ListBox();
            this.SelectAllCheckbox = new System.Windows.Forms.CheckBox();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.базыДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTaskByTemplateMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTasksMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewTaskMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.расписанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewScheduleMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgramm = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolButtonsPanel = new System.Windows.Forms.Panel();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.ChildPanel.SuspendLayout();
            this.backupPathContextMenu.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.ToolButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenSchedulesMenuButton
            // 
            this.OpenSchedulesMenuButton.Name = "OpenSchedulesMenuButton";
            this.OpenSchedulesMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.OpenSchedulesMenuButton.Size = new System.Drawing.Size(261, 22);
            this.OpenSchedulesMenuButton.Text = "Все расписания";
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
            // ChoosePathButton
            // 
            this.ChoosePathButton.Location = new System.Drawing.Point(465, 46);
            this.ChoosePathButton.Name = "ChoosePathButton";
            this.ChoosePathButton.Size = new System.Drawing.Size(26, 21);
            this.ChoosePathButton.TabIndex = 19;
            this.ChoosePathButton.Text = "...";
            this.ChoosePathButton.UseVisualStyleBackColor = true;
            // 
            // OpenTasksButton
            // 
            this.OpenTasksButton.Location = new System.Drawing.Point(256, 33);
            this.OpenTasksButton.Name = "OpenTasksButton";
            this.OpenTasksButton.Size = new System.Drawing.Size(235, 23);
            this.OpenTasksButton.TabIndex = 23;
            this.OpenTasksButton.Text = "Все задачи";
            this.OpenTasksButton.UseVisualStyleBackColor = true;
            // 
            // CreateTaskByTemplateButton
            // 
            this.CreateTaskByTemplateButton.Location = new System.Drawing.Point(255, 4);
            this.CreateTaskByTemplateButton.Name = "CreateTaskByTemplateButton";
            this.CreateTaskByTemplateButton.Size = new System.Drawing.Size(235, 23);
            this.CreateTaskByTemplateButton.TabIndex = 22;
            this.CreateTaskByTemplateButton.Text = "Создать задачу";
            this.CreateTaskByTemplateButton.UseVisualStyleBackColor = true;
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(20, 33);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(229, 23);
            this.LogoutButton.TabIndex = 17;
            this.LogoutButton.Text = "Отключиться";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(19, 4);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(230, 23);
            this.BackupButton.TabIndex = 16;
            this.BackupButton.Text = "Бэкап";
            this.BackupButton.UseVisualStyleBackColor = true;
            // 
            // DatabasesList
            // 
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(20, 106);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(230, 199);
            this.DatabasesList.TabIndex = 20;
            // 
            // ChildPanel
            // 
            this.ChildPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChildPanel.Controls.Add(this.PathsToBackupCombobox);
            this.ChildPanel.Controls.Add(this.ProgressListBox);
            this.ChildPanel.Controls.Add(this.DatabasesList);
            this.ChildPanel.Controls.Add(this.label3);
            this.ChildPanel.Controls.Add(this.ChoosePathButton);
            this.ChildPanel.Controls.Add(this.SelectAllCheckbox);
            this.ChildPanel.Controls.Add(this.MenuStrip);
            this.ChildPanel.Controls.Add(this.ToolButtonsPanel);
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(523, 382);
            this.ChildPanel.TabIndex = 27;
            // 
            // PathsToBackupCombobox
            // 
            this.PathsToBackupCombobox.ContextMenuStrip = this.backupPathContextMenu;
            this.PathsToBackupCombobox.FormattingEnabled = true;
            this.PathsToBackupCombobox.Location = new System.Drawing.Point(20, 45);
            this.PathsToBackupCombobox.Name = "PathsToBackupCombobox";
            this.PathsToBackupCombobox.Size = new System.Drawing.Size(439, 21);
            this.PathsToBackupCombobox.TabIndex = 29;
            // 
            // backupPathContextMenu
            // 
            this.backupPathContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFolder});
            this.backupPathContextMenu.Name = "backupPathContextMenu";
            this.backupPathContextMenu.Size = new System.Drawing.Size(267, 26);
            // 
            // OpenFolder
            // 
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.OpenFolder.Size = new System.Drawing.Size(266, 22);
            this.OpenFolder.Text = "Открыть путь в проводнике";
            // 
            // ProgressListBox
            // 
            this.ProgressListBox.FormattingEnabled = true;
            this.ProgressListBox.Location = new System.Drawing.Point(257, 106);
            this.ProgressListBox.Name = "ProgressListBox";
            this.ProgressListBox.Size = new System.Drawing.Size(234, 199);
            this.ProgressListBox.TabIndex = 28;
            // 
            // SelectAllCheckbox
            // 
            this.SelectAllCheckbox.AutoSize = true;
            this.SelectAllCheckbox.Location = new System.Drawing.Point(20, 84);
            this.SelectAllCheckbox.Name = "SelectAllCheckbox";
            this.SelectAllCheckbox.Size = new System.Drawing.Size(91, 17);
            this.SelectAllCheckbox.TabIndex = 24;
            this.SelectAllCheckbox.Text = "Выбрать все";
            this.SelectAllCheckbox.UseVisualStyleBackColor = true;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.базыДанныхToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.расписанияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MenuStrip.Size = new System.Drawing.Size(523, 24);
            this.MenuStrip.TabIndex = 26;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // базыДанныхToolStripMenuItem
            // 
            this.базыДанныхToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackupMenuButton,
            this.CreateTaskByTemplateMenuButton});
            this.базыДанныхToolStripMenuItem.Name = "базыДанныхToolStripMenuItem";
            this.базыДанныхToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.базыДанныхToolStripMenuItem.Text = "Базы данных";
            // 
            // BackupMenuButton
            // 
            this.BackupMenuButton.Name = "BackupMenuButton";
            this.BackupMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.BackupMenuButton.Size = new System.Drawing.Size(197, 22);
            this.BackupMenuButton.Text = "Бэкап";
            // 
            // CreateTaskByTemplateMenuButton
            // 
            this.CreateTaskByTemplateMenuButton.Name = "CreateTaskByTemplateMenuButton";
            this.CreateTaskByTemplateMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.CreateTaskByTemplateMenuButton.Size = new System.Drawing.Size(197, 22);
            this.CreateTaskByTemplateMenuButton.Text = "Создать задачу";
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTasksMenuButton,
            this.CreateNewTaskMenuButton});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // OpenTasksMenuButton
            // 
            this.OpenTasksMenuButton.Name = "OpenTasksMenuButton";
            this.OpenTasksMenuButton.Size = new System.Drawing.Size(236, 22);
            this.OpenTasksMenuButton.Text = "Все задачи";
            // 
            // CreateNewTaskMenuButton
            // 
            this.CreateNewTaskMenuButton.Name = "CreateNewTaskMenuButton";
            this.CreateNewTaskMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.CreateNewTaskMenuButton.Size = new System.Drawing.Size(236, 22);
            this.CreateNewTaskMenuButton.Text = "Создать новую задачу";
            // 
            // расписанияToolStripMenuItem
            // 
            this.расписанияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSchedulesMenuButton,
            this.CreateNewScheduleMenuButton});
            this.расписанияToolStripMenuItem.Name = "расписанияToolStripMenuItem";
            this.расписанияToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.расписанияToolStripMenuItem.Text = "Расписания";
            // 
            // CreateNewScheduleMenuButton
            // 
            this.CreateNewScheduleMenuButton.Name = "CreateNewScheduleMenuButton";
            this.CreateNewScheduleMenuButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.CreateNewScheduleMenuButton.Size = new System.Drawing.Size(261, 22);
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
            // ToolButtonsPanel
            // 
            this.ToolButtonsPanel.Controls.Add(this.LogoutButton);
            this.ToolButtonsPanel.Controls.Add(this.CreateTaskByTemplateButton);
            this.ToolButtonsPanel.Controls.Add(this.OpenTasksButton);
            this.ToolButtonsPanel.Controls.Add(this.BackupButton);
            this.ToolButtonsPanel.Location = new System.Drawing.Point(0, 311);
            this.ToolButtonsPanel.Name = "ToolButtonsPanel";
            this.ToolButtonsPanel.Size = new System.Drawing.Size(523, 68);
            this.ToolButtonsPanel.TabIndex = 27;
            // 
            // BackupDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 382);
            this.Controls.Add(this.ChildPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "BackupDatabaseForm";
            this.Text = " Бэкап баз данных";
            this.ChildPanel.ResumeLayout(false);
            this.ChildPanel.PerformLayout();
            this.backupPathContextMenu.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ToolButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChoosePathButton;
        private System.Windows.Forms.Button OpenTasksButton;
        private System.Windows.Forms.Button CreateTaskByTemplateButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.CheckedListBox DatabasesList;
        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem базыДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackupMenuButton;
        private System.Windows.Forms.ToolStripMenuItem CreateTaskByTemplateMenuButton;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTasksMenuButton;
        private System.Windows.Forms.ToolStripMenuItem CreateNewTaskMenuButton;
        private System.Windows.Forms.ToolStripMenuItem расписанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgramm;
        private System.Windows.Forms.ToolStripMenuItem AboutAuthor;
        private System.Windows.Forms.ToolStripMenuItem CreateNewScheduleMenuButton;
        private System.Windows.Forms.ToolStripMenuItem OpenSchedulesMenuButton;
        private System.Windows.Forms.CheckBox SelectAllCheckbox;
        private System.Windows.Forms.Panel ToolButtonsPanel;
        private System.Windows.Forms.ListBox ProgressListBox;
        private System.Windows.Forms.ComboBox PathsToBackupCombobox;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ContextMenuStrip backupPathContextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenFolder;
    }
}