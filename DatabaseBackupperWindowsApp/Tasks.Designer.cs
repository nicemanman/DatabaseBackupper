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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TasksTable = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Schedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start new";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TasksTable
            // 
            this.TasksTable.AllowUserToAddRows = false;
            this.TasksTable.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TasksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.ID,
            this.ServerName,
            this.Path,
            this.Schedule});
            this.TasksTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.TasksTable.Location = new System.Drawing.Point(13, 13);
            this.TasksTable.Name = "TasksTable";
            this.TasksTable.ReadOnly = true;
            this.TasksTable.Size = new System.Drawing.Size(380, 212);
            this.TasksTable.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(139, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 21);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            this.TaskName.Width = 37;
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
            this.ServerName.HeaderText = "Server";
            this.ServerName.Name = "ServerName";
            this.ServerName.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            // 
            // Schedule
            // 
            this.Schedule.HeaderText = "Schedule";
            this.Schedule.Name = "Schedule";
            this.Schedule.ReadOnly = true;
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.TasksTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Tasks";
            this.Text = "Задачи";
            this.Load += new System.EventHandler(this.Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TasksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView TasksTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Schedule;
    }
}