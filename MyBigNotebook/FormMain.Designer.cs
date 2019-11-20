namespace MyBigNotebook
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonDiary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCalendar
            // 
            this.buttonCalendar.Location = new System.Drawing.Point(29, 13);
            this.buttonCalendar.Name = "buttonCalendar";
            this.buttonCalendar.Size = new System.Drawing.Size(175, 23);
            this.buttonCalendar.TabIndex = 0;
            this.buttonCalendar.Text = "Календарь";
            this.buttonCalendar.UseVisualStyleBackColor = true;
            this.buttonCalendar.Click += new System.EventHandler(this.buttonCalendar_Click);
            // 
            // buttonDiary
            // 
            this.buttonDiary.Location = new System.Drawing.Point(29, 43);
            this.buttonDiary.Name = "buttonDiary";
            this.buttonDiary.Size = new System.Drawing.Size(175, 23);
            this.buttonDiary.TabIndex = 1;
            this.buttonDiary.Text = "Дневник";
            this.buttonDiary.UseVisualStyleBackColor = true;
            this.buttonDiary.Click += new System.EventHandler(this.buttonDiary_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 341);
            this.Controls.Add(this.buttonDiary);
            this.Controls.Add(this.buttonCalendar);
            this.Name = "FormMain";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonDiary;
    }
}

