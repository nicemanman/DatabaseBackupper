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
            this.Databases = new System.Windows.Forms.CheckedListBox();
            this.BackupButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.TextBox();
            this.ChoosePath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Databases
            // 
            this.Databases.FormattingEnabled = true;
            this.Databases.Location = new System.Drawing.Point(12, 42);
            this.Databases.Name = "Databases";
            this.Databases.Size = new System.Drawing.Size(230, 229);
            this.Databases.TabIndex = 0;
            // 
            // BackupButton
            // 
            this.BackupButton.Location = new System.Drawing.Point(12, 277);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(230, 23);
            this.BackupButton.TabIndex = 1;
            this.BackupButton.Text = "Backup  now";
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.BackupButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(11, 335);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(229, 23);
            this.DisconnectButton.TabIndex = 2;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(13, 13);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(153, 20);
            this.Path.TabIndex = 3;
            // 
            // ChoosePath
            // 
            this.ChoosePath.Location = new System.Drawing.Point(173, 13);
            this.ChoosePath.Name = "ChoosePath";
            this.ChoosePath.Size = new System.Drawing.Size(70, 20);
            this.ChoosePath.TabIndex = 4;
            this.ChoosePath.Text = "path";
            this.ChoosePath.UseVisualStyleBackColor = true;
            this.ChoosePath.Click += new System.EventHandler(this.ChoosePath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create backup task";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackupDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChoosePath);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.BackupButton);
            this.Controls.Add(this.Databases);
            this.Name = "BackupDatabaseForm";
            this.Text = "Бэкап баз данных";
            this.Load += new System.EventHandler(this.BackupDatabaseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Databases;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button ChoosePath;
        private System.Windows.Forms.Button button1;
    }
}