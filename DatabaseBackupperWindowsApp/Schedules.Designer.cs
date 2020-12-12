namespace DatabaseBackupperWindowsApp
{
    partial class Schedules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedules));
            this.SchedulesTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Open = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Return = new System.Windows.Forms.Button();
            this.CreateNewSchedule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SchedulesTable
            // 
            this.SchedulesTable.AllowUserToAddRows = false;
            this.SchedulesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SchedulesTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SchedulesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchedulesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ScheduleName,
            this.Cron,
            this.Open,
            this.Delete});
            this.SchedulesTable.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.SchedulesTable.Location = new System.Drawing.Point(3, 3);
            this.SchedulesTable.Name = "SchedulesTable";
            this.SchedulesTable.ReadOnly = true;
            this.SchedulesTable.Size = new System.Drawing.Size(443, 263);
            this.SchedulesTable.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ScheduleName
            // 
            this.ScheduleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ScheduleName.HeaderText = "Название";
            this.ScheduleName.Name = "ScheduleName";
            this.ScheduleName.ReadOnly = true;
            // 
            // Cron
            // 
            this.Cron.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cron.HeaderText = "Cron выражение";
            this.Cron.Name = "Cron";
            this.Cron.ReadOnly = true;
            // 
            // Open
            // 
            this.Open.HeaderText = "";
            this.Open.Name = "Open";
            this.Open.ReadOnly = true;
            this.Open.Text = "Открыть";
            this.Open.ToolTipText = "Открыть";
            this.Open.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Удалить";
            this.Delete.ToolTipText = "Удалить";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Return
            // 
            this.Return.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Return.Location = new System.Drawing.Point(252, 272);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(194, 22);
            this.Return.TabIndex = 5;
            this.Return.Text = "Вернуться";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.ReturnButtonClick);
            // 
            // CreateNewSchedule
            // 
            this.CreateNewSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateNewSchedule.Location = new System.Drawing.Point(3, 272);
            this.CreateNewSchedule.Name = "CreateNewSchedule";
            this.CreateNewSchedule.Size = new System.Drawing.Size(243, 21);
            this.CreateNewSchedule.TabIndex = 4;
            this.CreateNewSchedule.Text = "Создать новое расписание";
            this.CreateNewSchedule.UseVisualStyleBackColor = true;
            this.CreateNewSchedule.Click += new System.EventHandler(this.CreateButtonClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Return);
            this.panel1.Controls.Add(this.SchedulesTable);
            this.panel1.Controls.Add(this.CreateNewSchedule);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 305);
            this.panel1.TabIndex = 6;
            // 
            // Schedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 305);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Schedules";
            this.Text = "Расписания";
            this.Load += new System.EventHandler(this.Schedules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchedulesTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SchedulesTable;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button CreateNewSchedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cron;
        private System.Windows.Forms.DataGridViewButtonColumn Open;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}