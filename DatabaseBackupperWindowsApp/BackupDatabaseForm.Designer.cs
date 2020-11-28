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
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бэкапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗадачуСТекущимиПараметрамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бэкапToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьНовоеПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьТекущееПодключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(13, 274);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(230, 23);
            this.BackupButton.TabIndex = 1;
            this.BackupButton.Text = "Backup  now";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(14, 302);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(229, 23);
            this.DisconnectButton.TabIndex = 2;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(15, 5);
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Size = new System.Drawing.Size(395, 20);
            this.Path.TabIndex = 3;
            // 
            // ChoosePath
            // 
            this.ChoosePath.Location = new System.Drawing.Point(416, 6);
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
            this.DatabasesList.Location = new System.Drawing.Point(15, 65);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(230, 199);
            this.DatabasesList.TabIndex = 7;
            // 
            // ProgressList
            // 
            this.ProgressList.HideSelection = false;
            this.ProgressList.Location = new System.Drawing.Point(250, 35);
            this.ProgressList.Name = "ProgressList";
            this.ProgressList.Size = new System.Drawing.Size(236, 229);
            this.ProgressList.TabIndex = 8;
            this.ProgressList.UseCompatibleStateImageBehavior = false;
            this.ProgressList.View = System.Windows.Forms.View.List;
            // 
            // Schedule
            // 
            this.Schedule.Location = new System.Drawing.Point(250, 274);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(235, 23);
            this.Schedule.TabIndex = 9;
            this.Schedule.Text = "Schedule this";
            this.Schedule.UseVisualStyleBackColor = true;
            this.Schedule.Click += new System.EventHandler(this.ScheduleButtonClick);
            // 
            // AllTasks
            // 
            this.AllTasks.Location = new System.Drawing.Point(250, 303);
            this.AllTasks.Name = "AllTasks";
            this.AllTasks.Size = new System.Drawing.Size(235, 23);
            this.AllTasks.TabIndex = 10;
            this.AllTasks.Text = "All tasks";
            this.AllTasks.UseVisualStyleBackColor = true;
            this.AllTasks.Click += new System.EventHandler(this.AllTasks_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.бэкапToolStripMenuItem,
            this.задачиToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(532, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(91, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Выбрать все";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьНовоеПодключениеToolStripMenuItem,
            this.удалитьТекущееПодключениеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.справкаToolStripMenuItem.Text = "Подключения";
            // 
            // бэкапToolStripMenuItem
            // 
            this.бэкапToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бэкапToolStripMenuItem1});
            this.бэкапToolStripMenuItem.Name = "бэкапToolStripMenuItem";
            this.бэкапToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.бэкапToolStripMenuItem.Text = "Бэкап";
            // 
            // задачиToolStripMenuItem
            // 
            this.задачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЗадачуToolStripMenuItem,
            this.создатьЗадачуСТекущимиПараметрамиToolStripMenuItem,
            this.всеЗадачиToolStripMenuItem});
            this.задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            this.задачиToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.задачиToolStripMenuItem.Text = "Задачи";
            // 
            // создатьЗадачуToolStripMenuItem
            // 
            this.создатьЗадачуToolStripMenuItem.Name = "создатьЗадачуToolStripMenuItem";
            this.создатьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.создатьЗадачуToolStripMenuItem.Text = "Создать задачу с нуля";
            this.создатьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.создатьЗадачуToolStripMenuItem_Click);
            // 
            // создатьЗадачуСТекущимиПараметрамиToolStripMenuItem
            // 
            this.создатьЗадачуСТекущимиПараметрамиToolStripMenuItem.Name = "создатьЗадачуСТекущимиПараметрамиToolStripMenuItem";
            this.создатьЗадачуСТекущимиПараметрамиToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.создатьЗадачуСТекущимиПараметрамиToolStripMenuItem.Text = "Создать задачу с текущими параметрами";
            // 
            // всеЗадачиToolStripMenuItem
            // 
            this.всеЗадачиToolStripMenuItem.Name = "всеЗадачиToolStripMenuItem";
            this.всеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(303, 22);
            this.всеЗадачиToolStripMenuItem.Text = "Все задачи";
            // 
            // бэкапToolStripMenuItem1
            // 
            this.бэкапToolStripMenuItem1.Name = "бэкапToolStripMenuItem1";
            this.бэкапToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.бэкапToolStripMenuItem1.Text = "Бэкап";
            // 
            // создатьНовоеПодключениеToolStripMenuItem
            // 
            this.создатьНовоеПодключениеToolStripMenuItem.Name = "создатьНовоеПодключениеToolStripMenuItem";
            this.создатьНовоеПодключениеToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.создатьНовоеПодключениеToolStripMenuItem.Text = "Создать новое подключение";
            // 
            // удалитьТекущееПодключениеToolStripMenuItem
            // 
            this.удалитьТекущееПодключениеToolStripMenuItem.Name = "удалитьТекущееПодключениеToolStripMenuItem";
            this.удалитьТекущееПодключениеToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
            this.удалитьТекущееПодключениеToolStripMenuItem.Text = "Удалить текущее подключение";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(510, 358);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ChoosePath);
            this.tabPage1.Controls.Add(this.AllTasks);
            this.tabPage1.Controls.Add(this.Schedule);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.DisconnectButton);
            this.tabPage1.Controls.Add(this.Path);
            this.tabPage1.Controls.Add(this.BackupButton);
            this.tabPage1.Controls.Add(this.ProgressList);
            this.tabPage1.Controls.Add(this.DatabasesList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(502, 332);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(502, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BackupDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(532, 405);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BackupDatabaseForm";
            this.Text = "Бэкап баз данных";
            this.Load += new System.EventHandler(this.BackupDatabaseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бэкапToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЗадачуСТекущимиПараметрамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьНовоеПодключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьТекущееПодключениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бэкапToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}