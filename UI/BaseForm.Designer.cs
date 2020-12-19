namespace UI
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HideAppButton = new System.Windows.Forms.PictureBox();
            this.MaximizeAppButton = new System.Windows.Forms.PictureBox();
            this.CloseAppButton = new System.Windows.Forms.PictureBox();
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HideAppButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeAppButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseAppButton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.ChildPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HeaderPanel.Controls.Add(this.HideAppButton);
            this.HeaderPanel.Controls.Add(this.MaximizeAppButton);
            this.HeaderPanel.Controls.Add(this.CloseAppButton);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 28);
            this.HeaderPanel.TabIndex = 1;
            // 
            // HideAppButton
            // 
            this.HideAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.HideAppButton.Image = global::UI.Properties.Resources.Minimize_Square_Orange;
            this.HideAppButton.Location = new System.Drawing.Point(700, 0);
            this.HideAppButton.Name = "HideAppButton";
            this.HideAppButton.Size = new System.Drawing.Size(35, 28);
            this.HideAppButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.HideAppButton.TabIndex = 2;
            this.HideAppButton.TabStop = false;
            // 
            // MaximizeAppButton
            // 
            this.MaximizeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeAppButton.Image = global::UI.Properties.Resources.Maximize_Orange;
            this.MaximizeAppButton.Location = new System.Drawing.Point(735, 0);
            this.MaximizeAppButton.Name = "MaximizeAppButton";
            this.MaximizeAppButton.Size = new System.Drawing.Size(34, 28);
            this.MaximizeAppButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MaximizeAppButton.TabIndex = 1;
            this.MaximizeAppButton.TabStop = false;
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseAppButton.Image = global::UI.Properties.Resources.Close_SquareRed2;
            this.CloseAppButton.Location = new System.Drawing.Point(769, 0);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.Size = new System.Drawing.Size(31, 28);
            this.CloseAppButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseAppButton.TabIndex = 0;
            this.CloseAppButton.TabStop = false;
            // 
            // ChildPanel
            // 
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChildPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(800, 450);
            this.ChildPanel.TabIndex = 0;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HideAppButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeAppButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseAppButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox CloseAppButton;
        private System.Windows.Forms.PictureBox MaximizeAppButton;
        private System.Windows.Forms.PictureBox HideAppButton;
        private System.Windows.Forms.Panel ChildPanel;
    }
}

