namespace UI
{
    partial class ScheduleDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleDetails));
            this.ChildPanel = new System.Windows.Forms.Panel();
            this.EverySpecificWeekdayAt = new UI.Components.SchedulePeriodPanel(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.specificDays = new System.Windows.Forms.CheckedListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MinutesIntervalCombobox4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.HoursIntervalCombobox4 = new System.Windows.Forms.ComboBox();
            this.EveryDayAt = new UI.Components.SchedulePeriodPanel(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.MinutesIntervalCombobox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HoursIntervalCombobox3 = new System.Windows.Forms.ComboBox();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.EveryNHours = new UI.Components.SchedulePeriodPanel(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.HoursIntervalCombobox2 = new System.Windows.Forms.ComboBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.EveryNMinutes = new UI.Components.SchedulePeriodPanel(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.MinutesIntervalCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AllPeriodicsPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PeriodicList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScheduleName = new System.Windows.Forms.TextBox();
            this.ChildPanel.SuspendLayout();
            this.EverySpecificWeekdayAt.SuspendLayout();
            this.EveryDayAt.SuspendLayout();
            this.EveryNHours.SuspendLayout();
            this.EveryNMinutes.SuspendLayout();
            this.AllPeriodicsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChildPanel
            // 
            this.ChildPanel.AutoSize = true;
            this.ChildPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChildPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ChildPanel.Controls.Add(this.EverySpecificWeekdayAt);
            this.ChildPanel.Controls.Add(this.EveryDayAt);
            this.ChildPanel.Controls.Add(this.EveryNHours);
            this.ChildPanel.Controls.Add(this.EveryNMinutes);
            this.ChildPanel.Controls.Add(this.AllPeriodicsPanel);
            this.ChildPanel.Controls.Add(this.label3);
            this.ChildPanel.Controls.Add(this.PeriodicList);
            this.ChildPanel.Controls.Add(this.label1);
            this.ChildPanel.Controls.Add(this.ScheduleName);
            this.ChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildPanel.Location = new System.Drawing.Point(0, 0);
            this.ChildPanel.Name = "ChildPanel";
            this.ChildPanel.Size = new System.Drawing.Size(428, 773);
            this.ChildPanel.TabIndex = 0;
            // 
            // EverySpecificWeekdayAt
            // 
            this.EverySpecificWeekdayAt.Controls.Add(this.label15);
            this.EverySpecificWeekdayAt.Controls.Add(this.specificDays);
            this.EverySpecificWeekdayAt.Controls.Add(this.label16);
            this.EverySpecificWeekdayAt.Controls.Add(this.MinutesIntervalCombobox4);
            this.EverySpecificWeekdayAt.Controls.Add(this.label14);
            this.EverySpecificWeekdayAt.Controls.Add(this.HoursIntervalCombobox4);
            this.EverySpecificWeekdayAt.Location = new System.Drawing.Point(17, 373);
            this.EverySpecificWeekdayAt.Name = "EverySpecificWeekdayAt";
            this.EverySpecificWeekdayAt.Size = new System.Drawing.Size(387, 134);
            this.EverySpecificWeekdayAt.TabIndex = 16;
            this.EverySpecificWeekdayAt.Type = QuartzCronGenerator.CronExpressionType.EverySpecificWeekDayAt;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(171, 108);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "м.";
            // 
            // specificDays
            // 
            this.specificDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.specificDays.FormattingEnabled = true;
            this.specificDays.Location = new System.Drawing.Point(0, 0);
            this.specificDays.Name = "specificDays";
            this.specificDays.Size = new System.Drawing.Size(387, 94);
            this.specificDays.TabIndex = 15;
            this.specificDays.Tag = "days";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(90, 108);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "ч.";
            // 
            // MinutesIntervalCombobox4
            // 
            this.MinutesIntervalCombobox4.FormattingEnabled = true;
            this.MinutesIntervalCombobox4.Location = new System.Drawing.Point(108, 100);
            this.MinutesIntervalCombobox4.Name = "MinutesIntervalCombobox4";
            this.MinutesIntervalCombobox4.Size = new System.Drawing.Size(57, 21);
            this.MinutesIntervalCombobox4.TabIndex = 12;
            this.MinutesIntervalCombobox4.Tag = "minutes";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "В";
            // 
            // HoursIntervalCombobox4
            // 
            this.HoursIntervalCombobox4.FormattingEnabled = true;
            this.HoursIntervalCombobox4.Location = new System.Drawing.Point(30, 100);
            this.HoursIntervalCombobox4.Name = "HoursIntervalCombobox4";
            this.HoursIntervalCombobox4.Size = new System.Drawing.Size(57, 21);
            this.HoursIntervalCombobox4.TabIndex = 11;
            this.HoursIntervalCombobox4.Tag = "hours";
            // 
            // EveryDayAt
            // 
            this.EveryDayAt.Controls.Add(this.label13);
            this.EveryDayAt.Controls.Add(this.MinutesIntervalCombobox3);
            this.EveryDayAt.Controls.Add(this.label2);
            this.EveryDayAt.Controls.Add(this.HoursIntervalCombobox3);
            this.EveryDayAt.Controls.Add(this.radioButton7);
            this.EveryDayAt.Location = new System.Drawing.Point(17, 337);
            this.EveryDayAt.Name = "EveryDayAt";
            this.EveryDayAt.Size = new System.Drawing.Size(387, 29);
            this.EveryDayAt.TabIndex = 15;
            this.EveryDayAt.Type = QuartzCronGenerator.CronExpressionType.EveryDayAt;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(186, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "м.";
            // 
            // MinutesIntervalCombobox3
            // 
            this.MinutesIntervalCombobox3.FormattingEnabled = true;
            this.MinutesIntervalCombobox3.Location = new System.Drawing.Point(123, 3);
            this.MinutesIntervalCombobox3.Name = "MinutesIntervalCombobox3";
            this.MinutesIntervalCombobox3.Size = new System.Drawing.Size(57, 21);
            this.MinutesIntervalCombobox3.TabIndex = 8;
            this.MinutesIntervalCombobox3.Tag = "minutes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ч.";
            // 
            // HoursIntervalCombobox3
            // 
            this.HoursIntervalCombobox3.DisplayMember = "hours";
            this.HoursIntervalCombobox3.FormattingEnabled = true;
            this.HoursIntervalCombobox3.Location = new System.Drawing.Point(45, 3);
            this.HoursIntervalCombobox3.Name = "HoursIntervalCombobox3";
            this.HoursIntervalCombobox3.Size = new System.Drawing.Size(57, 21);
            this.HoursIntervalCombobox3.TabIndex = 7;
            this.HoursIntervalCombobox3.Tag = "hours";
            this.HoursIntervalCombobox3.ValueMember = "hours";
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(12, 4);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(32, 17);
            this.radioButton7.TabIndex = 1;
            this.radioButton7.Text = "В";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // EveryNHours
            // 
            this.EveryNHours.Controls.Add(this.label6);
            this.EveryNHours.Controls.Add(this.HoursIntervalCombobox2);
            this.EveryNHours.Controls.Add(this.radioButton5);
            this.EveryNHours.Location = new System.Drawing.Point(17, 302);
            this.EveryNHours.Name = "EveryNHours";
            this.EveryNHours.Size = new System.Drawing.Size(387, 29);
            this.EveryNHours.TabIndex = 14;
            this.EveryNHours.Type = QuartzCronGenerator.CronExpressionType.EveryNHours;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ч.";
            // 
            // HoursIntervalCombobox2
            // 
            this.HoursIntervalCombobox2.FormattingEnabled = true;
            this.HoursIntervalCombobox2.Location = new System.Drawing.Point(87, 3);
            this.HoursIntervalCombobox2.Name = "HoursIntervalCombobox2";
            this.HoursIntervalCombobox2.Size = new System.Drawing.Size(57, 21);
            this.HoursIntervalCombobox2.TabIndex = 11;
            this.HoursIntervalCombobox2.Tag = "hours";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 4);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(66, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Каждые";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // EveryNMinutes
            // 
            this.EveryNMinutes.Controls.Add(this.label5);
            this.EveryNMinutes.Controls.Add(this.MinutesIntervalCombobox);
            this.EveryNMinutes.Controls.Add(this.label4);
            this.EveryNMinutes.Location = new System.Drawing.Point(17, 269);
            this.EveryNMinutes.Name = "EveryNMinutes";
            this.EveryNMinutes.Size = new System.Drawing.Size(387, 27);
            this.EveryNMinutes.TabIndex = 13;
            this.EveryNMinutes.Type = QuartzCronGenerator.CronExpressionType.EveryNMinutes;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "м.";
            // 
            // MinutesIntervalCombobox
            // 
            this.MinutesIntervalCombobox.FormattingEnabled = true;
            this.MinutesIntervalCombobox.Location = new System.Drawing.Point(87, 3);
            this.MinutesIntervalCombobox.Name = "MinutesIntervalCombobox";
            this.MinutesIntervalCombobox.Size = new System.Drawing.Size(115, 21);
            this.MinutesIntervalCombobox.TabIndex = 1;
            this.MinutesIntervalCombobox.Tag = "minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Каждые(ую)";
            // 
            // AllPeriodicsPanel
            // 
            this.AllPeriodicsPanel.Controls.Add(this.SaveButton);
            this.AllPeriodicsPanel.Location = new System.Drawing.Point(17, 78);
            this.AllPeriodicsPanel.Name = "AllPeriodicsPanel";
            this.AllPeriodicsPanel.Size = new System.Drawing.Size(398, 185);
            this.AllPeriodicsPanel.TabIndex = 12;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(0, 150);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(398, 35);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Периодичность";
            // 
            // PeriodicList
            // 
            this.PeriodicList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PeriodicList.FormattingEnabled = true;
            this.PeriodicList.Location = new System.Drawing.Point(174, 53);
            this.PeriodicList.Name = "PeriodicList";
            this.PeriodicList.Size = new System.Drawing.Size(241, 21);
            this.PeriodicList.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // ScheduleName
            // 
            this.ScheduleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScheduleName.Location = new System.Drawing.Point(123, 21);
            this.ScheduleName.Name = "ScheduleName";
            this.ScheduleName.Size = new System.Drawing.Size(293, 20);
            this.ScheduleName.TabIndex = 0;
            this.ScheduleName.Text = "Расписание";
            // 
            // ScheduleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 773);
            this.Controls.Add(this.ChildPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleDetails";
            this.Text = "Расписание";
            this.ChildPanel.ResumeLayout(false);
            this.ChildPanel.PerformLayout();
            this.EverySpecificWeekdayAt.ResumeLayout(false);
            this.EverySpecificWeekdayAt.PerformLayout();
            this.EveryDayAt.ResumeLayout(false);
            this.EveryDayAt.PerformLayout();
            this.EveryNHours.ResumeLayout(false);
            this.EveryNHours.PerformLayout();
            this.EveryNMinutes.ResumeLayout(false);
            this.EveryNMinutes.PerformLayout();
            this.AllPeriodicsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel ChildPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScheduleName;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox MinutesIntervalCombobox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox MinutesIntervalCombobox4;
        private System.Windows.Forms.ComboBox HoursIntervalCombobox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox HoursIntervalCombobox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MinutesIntervalCombobox3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox PeriodicList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel AllPeriodicsPanel;
        private System.Windows.Forms.ComboBox HoursIntervalCombobox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Components.SchedulePeriodPanel EveryNMinutes;
        private System.Windows.Forms.CheckedListBox specificDays;
        private Components.SchedulePeriodPanel EverySpecificWeekdayAt;
        private Components.SchedulePeriodPanel EveryDayAt;
        private Components.SchedulePeriodPanel EveryNHours;
    }
}