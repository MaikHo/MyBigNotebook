namespace MyBigNotebook.Forms
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.dgUser = new System.Windows.Forms.GroupBox();
            this.gbAutoSave = new System.Windows.Forms.GroupBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxGoogleUser = new System.Windows.Forms.TextBox();
            this.checkBoxAutoSave = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownsaveTime = new System.Windows.Forms.NumericUpDown();
            this.dgUser.SuspendLayout();
            this.gbAutoSave.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsaveTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUser
            // 
            this.dgUser.Controls.Add(this.textBoxGoogleUser);
            this.dgUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgUser.Location = new System.Drawing.Point(0, 0);
            this.dgUser.Name = "dgUser";
            this.dgUser.Size = new System.Drawing.Size(248, 49);
            this.dgUser.TabIndex = 0;
            this.dgUser.TabStop = false;
            this.dgUser.Text = "Имя пользователя Google";
            // 
            // gbAutoSave
            // 
            this.gbAutoSave.Controls.Add(this.numericUpDownsaveTime);
            this.gbAutoSave.Controls.Add(this.label1);
            this.gbAutoSave.Controls.Add(this.checkBoxAutoSave);
            this.gbAutoSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAutoSave.Location = new System.Drawing.Point(0, 49);
            this.gbAutoSave.Name = "gbAutoSave";
            this.gbAutoSave.Size = new System.Drawing.Size(248, 100);
            this.gbAutoSave.TabIndex = 1;
            this.gbAutoSave.TabStop = false;
            this.gbAutoSave.Text = "Автосохранение";
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenu.Controls.Add(this.buttonClose);
            this.panelMenu.Controls.Add(this.buttonSave);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 149);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(248, 62);
            this.panelMenu.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(12, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(223, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(12, 33);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(223, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxGoogleUser
            // 
            this.textBoxGoogleUser.Location = new System.Drawing.Point(13, 20);
            this.textBoxGoogleUser.Name = "textBoxGoogleUser";
            this.textBoxGoogleUser.Size = new System.Drawing.Size(223, 20);
            this.textBoxGoogleUser.TabIndex = 0;
            // 
            // checkBoxAutoSave
            // 
            this.checkBoxAutoSave.AutoSize = true;
            this.checkBoxAutoSave.Location = new System.Drawing.Point(7, 20);
            this.checkBoxAutoSave.Name = "checkBoxAutoSave";
            this.checkBoxAutoSave.Size = new System.Drawing.Size(97, 17);
            this.checkBoxAutoSave.TabIndex = 0;
            this.checkBoxAutoSave.Text = "Автосохрание";
            this.checkBoxAutoSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Период автосохранения, мин";
            // 
            // numericUpDownsaveTime
            // 
            this.numericUpDownsaveTime.Location = new System.Drawing.Point(13, 64);
            this.numericUpDownsaveTime.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownsaveTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownsaveTime.Name = "numericUpDownsaveTime";
            this.numericUpDownsaveTime.Size = new System.Drawing.Size(223, 20);
            this.numericUpDownsaveTime.TabIndex = 2;
            this.numericUpDownsaveTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(248, 211);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.gbAutoSave);
            this.Controls.Add(this.dgUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetting";
            this.Text = "Настройки";
            this.dgUser.ResumeLayout(false);
            this.dgUser.PerformLayout();
            this.gbAutoSave.ResumeLayout(false);
            this.gbAutoSave.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownsaveTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dgUser;
        private System.Windows.Forms.GroupBox gbAutoSave;
        private System.Windows.Forms.TextBox textBoxGoogleUser;
        private System.Windows.Forms.NumericUpDown numericUpDownsaveTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxAutoSave;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
    }
}