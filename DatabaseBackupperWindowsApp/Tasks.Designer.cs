namespace DatabaseBackupperWindowsApp
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TasksTable = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenTaskMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTaskMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.OpenTaskButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(18, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Создать новую задачу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(267, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(422, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Вернуться";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.TaskName,
            this.ID,
            this.ServerName,
            this.Path,
            this.Schedule,
            this.Delete,
            this.OpenTaskButton});
            this.TasksTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.TasksTable.Location = new System.Drawing.Point(18, 17);
            this.TasksTable.Name = "TasksTable";
            this.TasksTable.ReadOnly = true;
            this.TasksTable.Size = new System.Drawing.Size(671, 345);
            this.TasksTable.TabIndex = 0;
            
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.TasksTable);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 407);
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
            this.OpenTaskMenuButton.Click += new System.EventHandler(this.OpenTaskMenuButton_Click);
            // 
            // DeleteTaskMenuButton
            // 
            this.DeleteTaskMenuButton.Name = "DeleteTaskMenuButton";
            this.DeleteTaskMenuButton.Size = new System.Drawing.Size(160, 22);
            this.DeleteTaskMenuButton.Text = "Удалить задачу";
            this.DeleteTaskMenuButton.Click += new System.EventHandler(this.DeleteTaskMenuButton_Click);
            // 
            // TaskName
            // 
            this.TaskName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaskName.HeaderText = "Название";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
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
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Удалить задачу";
            this.Delete.ToolTipText = "Удалить задачу";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // OpenTaskButton
            // 
            this.OpenTaskButton.HeaderText = "";
            this.OpenTaskButton.Name = "OpenTaskButton";
            this.OpenTaskButton.ReadOnly = true;
            this.OpenTaskButton.Text = "Открыть задачу";
            this.OpenTaskButton.ToolTipText = "Открыть задачу";
            this.OpenTaskButton.UseColumnTextForButtonValue = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 407);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tasks";
            this.Text = "Задачи";
            this.Load += new System.EventHandler(this.Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView TasksTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenTaskMenuButton;
        private System.Windows.Forms.ToolStripMenuItem DeleteTaskMenuButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn OpenTaskButton;
    }
}