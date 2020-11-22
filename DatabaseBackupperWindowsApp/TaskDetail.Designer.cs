namespace DatabaseBackupperWindowsApp
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
            this.PathToBackup = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.Schedule = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.ServerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // DatabasesList
            // 
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(13, 66);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(222, 214);
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
            this.label2.Location = new System.Drawing.Point(13, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Schedule";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Path";
            // 
            // PathToBackup
            // 
            this.PathToBackup.Location = new System.Drawing.Point(71, 312);
            this.PathToBackup.Name = "PathToBackup";
            this.PathToBackup.Size = new System.Drawing.Size(164, 20);
            this.PathToBackup.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name";
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(57, 14);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(178, 20);
            this.TaskName.TabIndex = 10;
            // 
            // Schedule
            // 
            this.Schedule.Location = new System.Drawing.Point(71, 286);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(164, 20);
            this.Schedule.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ReturnButtonClick);
            // 
            // ServerName
            // 
            this.ServerName.AutoSize = true;
            this.ServerName.Location = new System.Drawing.Point(57, 41);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(38, 13);
            this.ServerName.TabIndex = 13;
            this.ServerName.Text = "Server";
            // 
            // TaskDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 398);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaskName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PathToBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Schedule);
            this.Controls.Add(this.DatabasesList);
            this.Controls.Add(this.label1);
            this.Name = "TaskDetail";
            this.Text = "Детали задачи";
            this.Load += new System.EventHandler(this.TaskDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox DatabasesList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PathToBackup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.TextBox Schedule;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ServerName;
    }
}