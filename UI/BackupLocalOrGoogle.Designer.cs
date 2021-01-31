namespace UI
{
    partial class BackupLocalOrGoogle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupLocalOrGoogle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.GoogleButton = new System.Windows.Forms.Button();
            this.LocalButton = new System.Windows.Forms.Button();
            this.Reauthorize = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.Reauthorize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.GoogleButton);
            this.panel1.Controls.Add(this.LocalButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 125);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Где вы хотели бы сделать резервную копию своих баз данных? В случае выбора облачн" +
    "ого диска на нем будет создана папка DatabaseBackupper (если не была создана ран" +
    "ее) и в нее будет сделан бэкап.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GoogleButton
            // 
            this.GoogleButton.Location = new System.Drawing.Point(196, 64);
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(139, 23);
            this.GoogleButton.TabIndex = 1;
            this.GoogleButton.Text = "На Google диске";
            this.GoogleButton.UseVisualStyleBackColor = true;
            // 
            // LocalButton
            // 
            this.LocalButton.Location = new System.Drawing.Point(12, 64);
            this.LocalButton.Name = "LocalButton";
            this.LocalButton.Size = new System.Drawing.Size(139, 23);
            this.LocalButton.TabIndex = 0;
            this.LocalButton.Text = "На локальном пк";
            this.LocalButton.UseVisualStyleBackColor = true;
            // 
            // Reauthorize
            // 
            this.Reauthorize.Location = new System.Drawing.Point(12, 93);
            this.Reauthorize.Name = "Reauthorize";
            this.Reauthorize.Size = new System.Drawing.Size(323, 23);
            this.Reauthorize.TabIndex = 3;
            this.Reauthorize.Text = "Перелогиниться (либо авторизоваться)";
            this.Reauthorize.UseVisualStyleBackColor = true;
            // 
            // BackupLocalOrGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 125);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupLocalOrGoogle";
            this.Text = "Куда бэкапить базы?";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoogleButton;
        private System.Windows.Forms.Button LocalButton;
        private System.Windows.Forms.Button Reauthorize;
    }
}