namespace UI
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.Authentication = new System.Windows.Forms.ComboBox();
            this.ServerName = new System.Windows.Forms.ComboBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.LoginPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 411);
            this.panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 35);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 44;
            this.checkBox1.Text = "Локальные и сетевые";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MoolBoran", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "Подключение к серверу:";
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ConnectButton.FlatAppearance.BorderSize = 0;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Location = new System.Drawing.Point(155, 182);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(150, 29);
            this.ConnectButton.TabIndex = 36;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = false;
            // 
            // Authentication
            // 
            this.Authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Authentication.FormattingEnabled = true;
            this.Authentication.Location = new System.Drawing.Point(11, 104);
            this.Authentication.Name = "Authentication";
            this.Authentication.Size = new System.Drawing.Size(293, 21);
            this.Authentication.TabIndex = 40;
            // 
            // ServerName
            // 
            this.ServerName.BackColor = System.Drawing.SystemColors.Menu;
            this.ServerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerName.FormattingEnabled = true;
            this.ServerName.Location = new System.Drawing.Point(12, 78);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(293, 21);
            this.ServerName.TabIndex = 37;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 156);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(293, 20);
            this.Password.TabIndex = 39;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(12, 130);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(292, 20);
            this.Username.TabIndex = 38;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.checkBox1);
            this.LoginPanel.Controls.Add(this.ConnectButton);
            this.LoginPanel.Controls.Add(this.ServerName);
            this.LoginPanel.Controls.Add(this.Password);
            this.LoginPanel.Controls.Add(this.Authentication);
            this.LoginPanel.Controls.Add(this.Username);
            this.LoginPanel.Location = new System.Drawing.Point(221, 87);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(338, 227);
            this.LoginPanel.TabIndex = 45;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.ComboBox Authentication;
        private System.Windows.Forms.ComboBox ServerName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LoginPanel;
    }
}
