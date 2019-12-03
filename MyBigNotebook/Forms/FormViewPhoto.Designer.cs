namespace MyBigNotebook.Forms
{
    partial class FormViewPhoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormViewPhoto));
            this.toolStripPhoto = new System.Windows.Forms.ToolStrip();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStripPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripPhoto
            // 
            this.toolStripPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Save});
            this.toolStripPhoto.Location = new System.Drawing.Point(0, 0);
            this.toolStripPhoto.Name = "toolStripPhoto";
            this.toolStripPhoto.Size = new System.Drawing.Size(696, 25);
            this.toolStripPhoto.TabIndex = 1;
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(696, 480);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Save.Image = global::MyBigNotebook.Properties.Resources.baseline_insert_photo_black_36dp;
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(23, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "Image.jpg";
            this.saveFileDialog.Filter = "jpg|*.jpg";
            // 
            // FormViewPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 505);
            this.Controls.Add(this.pictureBoxPhoto);
            this.Controls.Add(this.toolStripPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormViewPhoto";
            this.Text = "Просмотр фотографии";
            this.toolStripPhoto.ResumeLayout(false);
            this.toolStripPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.ToolStrip toolStripPhoto;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}