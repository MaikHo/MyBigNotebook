namespace MyBigNotebook.Forms
{
    partial class FormPhotos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhotos));
            this.tsPhoto = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeViewPhoto = new System.Windows.Forms.TreeView();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbKeyWorlds = new System.Windows.Forms.TextBox();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.tspAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbDescription.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPhoto
            // 
            this.tsPhoto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAdd,
            this.tsbDelete});
            this.tsPhoto.Location = new System.Drawing.Point(0, 0);
            this.tsPhoto.Name = "tsPhoto";
            this.tsPhoto.Size = new System.Drawing.Size(800, 25);
            this.tsPhoto.TabIndex = 0;
            this.tsPhoto.Text = "toolStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeViewPhoto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxPhoto);
            this.splitContainer1.Panel2.Controls.Add(this.gbDescription);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 425);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeViewPhoto
            // 
            this.treeViewPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewPhoto.Location = new System.Drawing.Point(0, 0);
            this.treeViewPhoto.Name = "treeViewPhoto";
            this.treeViewPhoto.Size = new System.Drawing.Size(204, 425);
            this.treeViewPhoto.TabIndex = 0;
            this.treeViewPhoto.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPhoto_AfterSelect);
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.rtbDescription);
            this.gbDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDescription.Location = new System.Drawing.Point(0, 261);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(592, 100);
            this.gbDescription.TabIndex = 3;
            this.gbDescription.TabStop = false;
            this.gbDescription.Text = "Описание";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDescription.Location = new System.Drawing.Point(3, 16);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(586, 81);
            this.rtbDescription.TabIndex = 0;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbKeyWorlds);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ключевые слова";
            // 
            // tbKeyWorlds
            // 
            this.tbKeyWorlds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbKeyWorlds.Location = new System.Drawing.Point(3, 16);
            this.tbKeyWorlds.Multiline = true;
            this.tbKeyWorlds.Name = "tbKeyWorlds";
            this.tbKeyWorlds.Size = new System.Drawing.Size(586, 45);
            this.tbKeyWorlds.TabIndex = 0;
            this.tbKeyWorlds.TextChanged += new System.EventHandler(this.tbKeyWorlds_TextChanged);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(592, 261);
            this.pictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto.TabIndex = 1;
            this.pictureBoxPhoto.TabStop = false;
            this.pictureBoxPhoto.DoubleClick += new System.EventHandler(this.pictureBoxPhoto_DoubleClick);
            // 
            // tspAdd
            // 
            this.tspAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tspAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspAdd.Name = "tspAdd";
            this.tspAdd.Size = new System.Drawing.Size(23, 22);
            this.tspAdd.Text = "Добавить";
            this.tspAdd.Click += new System.EventHandler(this.tspAdd_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "Удалить";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // FormPhotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tsPhoto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPhotos";
            this.Text = "Фотоальбом";
            this.tsPhoto.ResumeLayout(false);
            this.tsPhoto.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbDescription.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPhoto;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeViewPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbKeyWorlds;
        private System.Windows.Forms.ToolStripButton tspAdd;
        private System.Windows.Forms.ToolStripButton tsbDelete;
    }
}