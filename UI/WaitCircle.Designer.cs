namespace UI
{
    partial class WaitCircle
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
            this.WaitCircleBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitCircleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.WaitCircleBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 372);
            this.panel1.TabIndex = 0;
            // 
            // WaitCircleBox
            // 
            this.WaitCircleBox.Image = global::UI.Properties.Resources.oie_191135217N8GvuGu;
            this.WaitCircleBox.Location = new System.Drawing.Point(341, 136);
            this.WaitCircleBox.Name = "WaitCircleBox";
            this.WaitCircleBox.Size = new System.Drawing.Size(62, 54);
            this.WaitCircleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WaitCircleBox.TabIndex = 0;
            this.WaitCircleBox.TabStop = false;
            // 
            // WaitCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 372);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitCircle";
            this.Text = "WaitCircle";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaitCircleBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox WaitCircleBox;
    }
}