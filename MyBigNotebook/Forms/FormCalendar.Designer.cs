namespace MyBigNotebook
{
    partial class FormCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalendar));
            this.monthCalendarMain = new System.Windows.Forms.MonthCalendar();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.textBoxDayInfo = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddBirthDay = new System.Windows.Forms.ToolStripButton();
            this.tbAddMemorable = new System.Windows.Forms.ToolStripButton();
            this.tbAddReminder = new System.Windows.Forms.ToolStripButton();
            this.panelInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendarMain
            // 
            this.monthCalendarMain.CalendarDimensions = new System.Drawing.Size(4, 1);
            this.monthCalendarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.monthCalendarMain.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarMain.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarMain.MaxSelectionCount = 1;
            this.monthCalendarMain.Name = "monthCalendarMain";
            this.monthCalendarMain.ScrollChange = 1;
            this.monthCalendarMain.ShowToday = false;
            this.monthCalendarMain.ShowTodayCircle = false;
            this.monthCalendarMain.TabIndex = 0;
            this.monthCalendarMain.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarMain_DateSelected);
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.textBoxDayInfo);
            this.panelInfo.Controls.Add(this.toolStrip1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 162);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(668, 212);
            this.panelInfo.TabIndex = 2;
            // 
            // textBoxDayInfo
            // 
            this.textBoxDayInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDayInfo.Location = new System.Drawing.Point(0, 25);
            this.textBoxDayInfo.Multiline = true;
            this.textBoxDayInfo.Name = "textBoxDayInfo";
            this.textBoxDayInfo.Size = new System.Drawing.Size(668, 187);
            this.textBoxDayInfo.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddBirthDay,
            this.tbAddMemorable,
            this.tbAddReminder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddBirthDay
            // 
            this.tsbAddBirthDay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddBirthDay.Image = global::MyBigNotebook.Properties.Resources.baseline_cake_black_36dp;
            this.tsbAddBirthDay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddBirthDay.Name = "tsbAddBirthDay";
            this.tsbAddBirthDay.Size = new System.Drawing.Size(23, 22);
            this.tsbAddBirthDay.Text = "Добавить день рождения";
            this.tsbAddBirthDay.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tbAddMemorable
            // 
            this.tbAddMemorable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAddMemorable.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tbAddMemorable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddMemorable.Name = "tbAddMemorable";
            this.tbAddMemorable.Size = new System.Drawing.Size(23, 22);
            this.tbAddMemorable.Text = "Добавить памятную дату";
            this.tbAddMemorable.Click += new System.EventHandler(this.tbAddMemorable_Click);
            // 
            // tbAddReminder
            // 
            this.tbAddReminder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbAddReminder.Image = global::MyBigNotebook.Properties.Resources.baseline_add_alert_black_36dp;
            this.tbAddReminder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbAddReminder.Name = "tbAddReminder";
            this.tbAddReminder.Size = new System.Drawing.Size(23, 22);
            this.tbAddReminder.Text = "Добавить напоминание";
            this.tbAddReminder.Click += new System.EventHandler(this.tbAddReminder_Click);
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 374);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.monthCalendarMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalendar";
            this.Text = "Календарь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCalendar_FormClosed);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddBirthDay;
        private System.Windows.Forms.TextBox textBoxDayInfo;
        private System.Windows.Forms.ToolStripButton tbAddMemorable;
        private System.Windows.Forms.ToolStripButton tbAddReminder;
    }
}