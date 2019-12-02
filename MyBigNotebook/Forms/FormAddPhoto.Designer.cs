namespace MyBigNotebook.Forms
{
    partial class FormAddPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPhoto));
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbPhotoFile = new System.Windows.Forms.TextBox();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.tbKeyWorlds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.openPhotoFileDialod = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(107, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(282, 20);
            this.tbName.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(107, 33);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(282, 21);
            this.cbCategory.TabIndex = 2;
            // 
            // tbPhotoFile
            // 
            this.tbPhotoFile.Location = new System.Drawing.Point(107, 61);
            this.tbPhotoFile.Name = "tbPhotoFile";
            this.tbPhotoFile.ReadOnly = true;
            this.tbPhotoFile.Size = new System.Drawing.Size(255, 20);
            this.tbPhotoFile.TabIndex = 3;
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(107, 88);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(282, 96);
            this.tbDescription.TabIndex = 4;
            this.tbDescription.Text = "";
            // 
            // tbKeyWorlds
            // 
            this.tbKeyWorlds.Location = new System.Drawing.Point(107, 191);
            this.tbKeyWorlds.Multiline = true;
            this.tbKeyWorlds.Name = "tbKeyWorlds";
            this.tbKeyWorlds.Size = new System.Drawing.Size(282, 54);
            this.tbKeyWorlds.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Файл фото";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Описание";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ключевые слова";
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(368, 61);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(21, 20);
            this.buttonOpenFile.TabIndex = 10;
            this.buttonOpenFile.Text = "...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 262);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(377, 40);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 317);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKeyWorlds);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbPhotoFile);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddPhoto";
            this.Text = "Добавить фотографию";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox tbPhotoFile;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.TextBox tbKeyWorlds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.OpenFileDialog openPhotoFileDialod;
    }
}