﻿using System.Windows.Forms;
namespace UI
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
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTypesList = new System.Windows.Forms.ComboBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.ServersList = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.UpdateServersListButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusBar = new System.Windows.Forms.Label();
            this.ChildPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(142, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "Подключение";
            // 
            // LoginTypesList
            // 
            this.LoginTypesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginTypesList.FormattingEnabled = true;
            this.LoginTypesList.Location = new System.Drawing.Point(125, 169);
            this.LoginTypesList.Name = "LoginTypesList";
            this.LoginTypesList.Size = new System.Drawing.Size(268, 21);
            this.LoginTypesList.TabIndex = 34;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(126, 221);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.Size = new System.Drawing.Size(267, 20);
            this.PasswordTextbox.TabIndex = 33;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(125, 195);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(268, 20);
            this.UsernameTextbox.TabIndex = 32;
            // 
            // ServersList
            // 
            this.ServersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServersList.FormattingEnabled = true;
            this.ServersList.Location = new System.Drawing.Point(125, 143);
            this.ServersList.Name = "ServersList";
            this.ServersList.Size = new System.Drawing.Size(268, 21);
            this.ServersList.TabIndex = 31;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(262, 247);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(131, 29);
            this.ConnectButton.TabIndex = 30;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // ChildPanel
            // 
            this.ChildPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChildPanel.Controls.Add(this.UpdateServersListButton);
            this.ChildPanel.Controls.Add(this.panel1);
            this.ChildPanel.Controls.Add(this.label1);
            this.ChildPanel.Controls.Add(this.ConnectButton);
            this.ChildPanel.Controls.Add(this.LoginTypesList);
            this.ChildPanel.Controls.Add(this.ServersList);
            this.ChildPanel.Controls.Add(this.PasswordTextbox);
            this.ChildPanel.Controls.Add(this.UsernameTextbox);
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(523, 379);
            this.ChildPanel.TabIndex = 36;
            // 
            // UpdateServersListButton
            // 
            this.UpdateServersListButton.Location = new System.Drawing.Point(125, 247);
            this.UpdateServersListButton.Name = "UpdateServersListButton";
            this.UpdateServersListButton.Size = new System.Drawing.Size(131, 29);
            this.UpdateServersListButton.TabIndex = 37;
            this.UpdateServersListButton.Text = "Обновить";
            this.UpdateServersListButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.StatusBar);
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 29);
            this.panel1.TabIndex = 36;
            // 
            // StatusBar
            // 
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusBar.Location = new System.Drawing.Point(0, 0);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(523, 29);
            this.StatusBar.TabIndex = 0;
            this.StatusBar.Text = "Добро пожаловать!";
            this.StatusBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 379);
            this.Controls.Add(this.ChildPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectForm";
            this.Text = "Бэкап баз данных";
            this.ChildPanel.ResumeLayout(false);
            this.ChildPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private ComboBox LoginTypesList;
        private TextBox PasswordTextbox;
        private TextBox UsernameTextbox;
        private ComboBox ServersList;
        private Button ConnectButton;
        private Panel ChildPanel;
        private Panel panel1;
        private Label StatusBar;
        private Button UpdateServersListButton;
    }
}

