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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonCalendar = new System.Windows.Forms.Button();
            this.buttonDiary = new System.Windows.Forms.Button();
            this.buttonFinansial = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.buttonNotes = new System.Windows.Forms.Button();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonPhoto = new System.Windows.Forms.Button();
            this.buttonPlants = new System.Windows.Forms.Button();
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
            // buttonFinansial
            // 
            this.buttonFinansial.Location = new System.Drawing.Point(29, 72);
            this.buttonFinansial.Name = "buttonFinansial";
            this.buttonFinansial.Size = new System.Drawing.Size(175, 23);
            this.buttonFinansial.TabIndex = 2;
            this.buttonFinansial.Text = "Финансовый помошник";
            this.buttonFinansial.UseVisualStyleBackColor = true;
            this.buttonFinansial.Click += new System.EventHandler(this.buttonFinansial_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Location = new System.Drawing.Point(29, 102);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(175, 23);
            this.buttonInformation.TabIndex = 3;
            this.buttonInformation.Text = "Информация";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // buttonNotes
            // 
            this.buttonNotes.Location = new System.Drawing.Point(29, 132);
            this.buttonNotes.Name = "buttonNotes";
            this.buttonNotes.Size = new System.Drawing.Size(175, 23);
            this.buttonNotes.TabIndex = 4;
            this.buttonNotes.Text = "Заметки";
            this.buttonNotes.UseVisualStyleBackColor = true;
            this.buttonNotes.Click += new System.EventHandler(this.buttonNotes_Click);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Записная книжка";
            this.notifyIconMain.Visible = true;
            // 
            // buttonPhoto
            // 
            this.buttonPhoto.Location = new System.Drawing.Point(29, 162);
            this.buttonPhoto.Name = "buttonPhoto";
            this.buttonPhoto.Size = new System.Drawing.Size(175, 23);
            this.buttonPhoto.TabIndex = 5;
            this.buttonPhoto.Text = "Фотогалерея";
            this.buttonPhoto.UseVisualStyleBackColor = true;
            this.buttonPhoto.Click += new System.EventHandler(this.buttonPhoto_Click);
            // 
            // buttonPlants
            // 
            this.buttonPlants.Location = new System.Drawing.Point(29, 192);
            this.buttonPlants.Name = "buttonPlants";
            this.buttonPlants.Size = new System.Drawing.Size(175, 23);
            this.buttonPlants.TabIndex = 6;
            this.buttonPlants.Text = "Планы";
            this.buttonPlants.UseVisualStyleBackColor = true;
            this.buttonPlants.Click += new System.EventHandler(this.buttonPlants_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 341);
            this.Controls.Add(this.buttonPlants);
            this.Controls.Add(this.buttonPhoto);
            this.Controls.Add(this.buttonNotes);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonFinansial);
            this.Controls.Add(this.buttonDiary);
            this.Controls.Add(this.buttonCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Главное меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalendar;
        private System.Windows.Forms.Button buttonDiary;
        private System.Windows.Forms.Button buttonFinansial;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Button buttonNotes;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.Button buttonPhoto;
        private System.Windows.Forms.Button buttonPlants;
    }
}

