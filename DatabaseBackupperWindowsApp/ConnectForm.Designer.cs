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
            this.ChooseDirectoryToBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ServerName = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Authentication = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Подключиться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ConnectButton);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Location = new System.Drawing.Point(5, 125);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(82, 17);
            this.RememberMe.TabIndex = 18;
            this.RememberMe.Text = "Запомнить";
            this.RememberMe.UseVisualStyleBackColor = true;
            this.RememberMe.CheckedChanged += new System.EventHandler(this.RememberMe_CheckedChanged);
            // 
            // ServerName
            // 
            this.ServerName.FormattingEnabled = true;
            this.ServerName.Location = new System.Drawing.Point(12, 12);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(268, 21);
            this.ServerName.TabIndex = 19;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 160);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(292, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(115, 17);
            this.Status.Text = "Добро пожаловать!";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(12, 63);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(267, 20);
            this.Username.TabIndex = 21;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(13, 88);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(267, 20);
            this.Password.TabIndex = 22;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Authentication
            // 
            this.Authentication.FormattingEnabled = true;
            this.Authentication.Location = new System.Drawing.Point(12, 37);
            this.Authentication.Name = "Authentication";
            this.Authentication.Size = new System.Drawing.Size(268, 21);
            this.Authentication.TabIndex = 23;
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(292, 182);
            this.Controls.Add(this.Authentication);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectForm";
            this.Text = "Бэкап баз данных";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog ChooseDirectoryToBackup;
        private Button button1;
        private CheckBox RememberMe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox ServerName;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Status;
        private TextBox Username;
        private TextBox Password;
        private ComboBox Authentication;
    }
}

