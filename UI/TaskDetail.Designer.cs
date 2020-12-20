namespace UI
{
    partial class TaskDetail
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
            this.label1 = new System.Windows.Forms.Label();
            this.DatabasesList = new System.Windows.Forms.CheckedListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ServerName = new System.Windows.Forms.Label();
            this.ScheduleDropDownList = new System.Windows.Forms.ComboBox();
            this.PathToBackup = new System.Windows.Forms.Label();
            this.ChoosePath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сервер";
            // 
            // DatabasesList
            // 
            this.DatabasesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(13, 66);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(252, 214);
            this.DatabasesList.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(13, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Расписание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(13, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Путь";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(135, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Название";
            // 
            // TaskName
            // 
            this.TaskName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskName.Location = new System.Drawing.Point(76, 14);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(189, 20);
            this.TaskName.TabIndex = 10;
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ServerName.Location = new System.Drawing.Point(73, 41);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(38, 13);
            this.ServerName.TabIndex = 13;
            this.ServerName.Text = "Server";
            // 
            // ScheduleDropDownList
            // 
            this.ScheduleDropDownList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ScheduleDropDownList.FormattingEnabled = true;
            this.ScheduleDropDownList.Location = new System.Drawing.Point(87, 284);
            this.ScheduleDropDownList.Name = "ScheduleDropDownList";
            this.ScheduleDropDownList.Size = new System.Drawing.Size(178, 21);
            this.ScheduleDropDownList.TabIndex = 14;
            // 
            // PathToBackup
            // 
            this.PathToBackup.AutoSize = true;
            this.PathToBackup.Location = new System.Drawing.Point(69, 313);
            this.PathToBackup.Name = "PathToBackup";
            this.PathToBackup.Size = new System.Drawing.Size(0, 13);
            this.PathToBackup.TabIndex = 15;
            // 
            // ChoosePath
            // 
            this.ChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChoosePath.Location = new System.Drawing.Point(185, 310);
            this.ChoosePath.Name = "ChoosePath";
            this.ChoosePath.Size = new System.Drawing.Size(80, 20);
            this.ChoosePath.TabIndex = 16;
            this.ChoosePath.Text = "Путь";
            this.ChoosePath.UseVisualStyleBackColor = true;
            
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 394);
            this.panel1.TabIndex = 17;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.status.Location = new System.Drawing.Point(0, 372);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(277, 22);
            this.status.TabIndex = 0;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(118, 17);
            this.StatusLabel.Text = "toolStripStatusLabel1";
            
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 394);
            this.Controls.Add(this.ChoosePath);
            this.Controls.Add(this.PathToBackup);
            this.Controls.Add(this.ScheduleDropDownList);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabasesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TaskDetail";
            this.Text = "Детали задачи";
            
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox DatabasesList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TaskName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label ServerName;
        private System.Windows.Forms.ComboBox ScheduleDropDownList;
        private System.Windows.Forms.Label PathToBackup;
        private System.Windows.Forms.Button ChoosePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
    }
}