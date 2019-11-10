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
            this.panelAdd = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
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
            this.monthCalendarMain.ShowToday = false;
            this.monthCalendarMain.ShowTodayCircle = false;
            this.monthCalendarMain.TabIndex = 0;
            // 
            // panelAdd
            // 
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdd.Location = new System.Drawing.Point(0, 260);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(668, 114);
            this.panelAdd.TabIndex = 1;
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.toolStrip1);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 162);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(668, 98);
            this.panelInfo.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbAdd.Text = "Добавить день рождения";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // FormCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 374);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.monthCalendarMain);
            this.Name = "FormCalendar";
            this.Text = "FormCalendar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCalendar_FormClosed);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarMain;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAdd;
    }
}