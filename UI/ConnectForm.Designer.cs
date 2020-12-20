using System.Windows.Forms;
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
            this.ChooseDirectoryToBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTypesList = new System.Windows.Forms.ComboBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.ServersList = new System.Windows.Forms.ComboBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 357);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(115, 17);
            this.Status.Text = "Добро пожаловать!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 39);
            this.label1.TabIndex = 35;
            this.label1.Text = "Подключение";
            // 
            // LoginTypesList
            // 
            this.LoginTypesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoginTypesList.FormattingEnabled = true;
            this.LoginTypesList.Location = new System.Drawing.Point(117, 181);
            this.LoginTypesList.Name = "LoginTypesList";
            this.LoginTypesList.Size = new System.Drawing.Size(268, 21);
            this.LoginTypesList.TabIndex = 34;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(118, 232);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(267, 20);
            this.PasswordTextbox.TabIndex = 33;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(117, 207);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(267, 20);
            this.UsernameTextbox.TabIndex = 32;
            // 
            // ServersList
            // 
            this.ServersList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServersList.FormattingEnabled = true;
            this.ServersList.Location = new System.Drawing.Point(117, 156);
            this.ServersList.Name = "ServersList";
            this.ServersList.Size = new System.Drawing.Size(268, 21);
            this.ServersList.TabIndex = 31;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(235, 262);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(150, 29);
            this.ConnectButton.TabIndex = 30;
            this.ConnectButton.Text = "Подключиться";
            this.ConnectButton.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.ConnectButton);
            this.panel.Controls.Add(this.LoginTypesList);
            this.panel.Controls.Add(this.ServersList);
            this.panel.Controls.Add(this.PasswordTextbox);
            this.panel.Controls.Add(this.UsernameTextbox);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(524, 358);
            this.panel.TabIndex = 36;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 379);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectForm";
            this.Text = "Бэкап баз данных";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog ChooseDirectoryToBackup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Status;
        private Label label1;
        private ComboBox LoginTypesList;
        private TextBox PasswordTextbox;
        private TextBox UsernameTextbox;
        private ComboBox ServersList;
        private Button ConnectButton;
        private Panel panel;
    }
}

