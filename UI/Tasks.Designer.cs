namespace UI
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            this.CreateNewJobButton = new System.Windows.Forms.Button();
            this.TasksTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenTaskMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTaskMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NotifyAboutFinish = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Open = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateNewJobButton
            // 
            this.CreateNewJobButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateNewJobButton.Location = new System.Drawing.Point(487, 330);
            this.CreateNewJobButton.Name = "CreateNewJobButton";
            this.CreateNewJobButton.Size = new System.Drawing.Size(243, 21);
            this.CreateNewJobButton.TabIndex = 1;
            this.CreateNewJobButton.Text = "Создать новую задачу";
            this.CreateNewJobButton.UseVisualStyleBackColor = true;
            // 
            // TasksTable
            // 
            this.TasksTable.AllowUserToAddRows = false;
            this.TasksTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TasksTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.TasksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TaskName,
            this.ServerName,
            this.Path,
            this.Schedule,
            this.IsEnabled,
            this.NotifyAboutFinish,
            this.EMail,
            this.Delete,
            this.Open});
            this.TasksTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.TasksTable.Location = new System.Drawing.Point(18, 17);
            this.TasksTable.Name = "TasksTable";
            this.TasksTable.ReadOnly = true;
            this.TasksTable.Size = new System.Drawing.Size(712, 302);
            this.TasksTable.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.TasksTable);
            this.panel1.Controls.Add(this.CreateNewJobButton);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 364);
            this.panel1.TabIndex = 3;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTaskMenuButton,
            this.DeleteTaskMenuButton});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(161, 48);
            // 
            // OpenTaskMenuButton
            // 
            this.OpenTaskMenuButton.Name = "OpenTaskMenuButton";
            this.OpenTaskMenuButton.Size = new System.Drawing.Size(160, 22);
            this.OpenTaskMenuButton.Text = "Открыть задачу";
            // 
            // DeleteTaskMenuButton
            // 
            this.DeleteTaskMenuButton.Name = "DeleteTaskMenuButton";
            this.DeleteTaskMenuButton.Size = new System.Drawing.Size(160, 22);
            this.DeleteTaskMenuButton.Text = "Удалить задачу";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskName.HeaderText = "Название";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // ServerName
            // 
            this.ServerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServerName.HeaderText = "Имя сервера";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Path.HeaderText = "Путь на диске";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // Schedule
            // 
            this.Schedule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Schedule.HeaderText = "Периодичность";
            this.Schedule.Name = "Schedule";
            this.Schedule.ReadOnly = true;
            // 
            // IsEnabled
            // 
            this.IsEnabled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IsEnabled.HeaderText = "Действует";
            this.IsEnabled.Name = "IsEnabled";
            this.IsEnabled.ReadOnly = true;
            // 
            // NotifyAboutFinish
            // 
            this.NotifyAboutFinish.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NotifyAboutFinish.HeaderText = "Уведомлять при завершении";
            this.NotifyAboutFinish.Name = "NotifyAboutFinish";
            this.NotifyAboutFinish.ReadOnly = true;
            this.NotifyAboutFinish.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NotifyAboutFinish.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EMail
            // 
            this.EMail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMail.HeaderText = "E-Mail для уведомления";
            this.EMail.Name = "EMail";
            this.EMail.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Удалить задачу";
            this.Delete.ToolTipText = "Удалить задачу";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Open
            // 
            this.Open.HeaderText = "";
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            this.Open.Text = "Открыть задачу";
            this.Open.ToolTipText = "Открыть задачу";
            this.Open.UseColumnTextForButtonValue = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 364);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tasks";
            this.Text = "Задачи";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CreateNewJobButton;
        private System.Windows.Forms.DataGridView TasksTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenTaskMenuButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteTaskMenuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsEnabled;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotifyAboutFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Open;
    }
}