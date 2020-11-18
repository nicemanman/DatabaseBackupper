using System.Windows.Forms;
namespace DatabaseBackupperWindowsApp
{
    partial class ConnectForm : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.ServerNameLabel = new System.Windows.Forms.Label();
            this.ChooseDirectoryToBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ServerNameLabel
            // 
            this.ServerNameLabel.AutoSize = true;
            this.ServerNameLabel.Location = new System.Drawing.Point(3, 6);
            this.ServerNameLabel.Name = "ServerNameLabel";
            this.ServerNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ServerNameLabel.TabIndex = 1;
            this.ServerNameLabel.Text = "Server";
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(59, 6);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(221, 20);
            this.ServerName.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(59, 58);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(221, 20);
            this.Password.TabIndex = 14;
            this.Password.UseSystemPasswordChar = true;
            this.Password.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password";
            this.label4.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Username";
            this.label1.Visible = false;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(59, 32);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(221, 20);
            this.UserName.TabIndex = 16;
            this.UserName.Visible = false;
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Location = new System.Drawing.Point(5, 111);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(94, 17);
            this.RememberMe.TabIndex = 18;
            this.RememberMe.Text = "Remember me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 145);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.ServerNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectForm";
            this.Text = "Бэкап баз данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ServerNameLabel;
        private System.Windows.Forms.FolderBrowserDialog ChooseDirectoryToBackup;
        private TextBox ServerName;
        private Button button1;
        private TextBox Password;
        private Label label4;
        private Label label1;
        private TextBox UserName;
        private CheckBox RememberMe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

