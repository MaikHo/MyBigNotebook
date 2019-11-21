namespace MyBigNotebook.Forms
{
    partial class FormClassInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClassInformation));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageDossier = new System.Windows.Forms.TabPage();
            this.tabPageLinks = new System.Windows.Forms.TabPage();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.splitContainerDossier = new System.Windows.Forms.SplitContainer();
            this.dgvDossierList = new System.Windows.Forms.DataGridView();
            this.panelDossierPhoto = new System.Windows.Forms.Panel();
            this.toolStripContainerDossierPhoto = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.pictureBoxDossierPhoto = new System.Windows.Forms.PictureBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControlMain.SuspendLayout();
            this.tabPageDossier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDossier)).BeginInit();
            this.splitContainerDossier.Panel1.SuspendLayout();
            this.splitContainerDossier.Panel2.SuspendLayout();
            this.splitContainerDossier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDossierList)).BeginInit();
            this.panelDossierPhoto.SuspendLayout();
            this.toolStripContainerDossierPhoto.ContentPanel.SuspendLayout();
            this.toolStripContainerDossierPhoto.TopToolStripPanel.SuspendLayout();
            this.toolStripContainerDossierPhoto.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDossierPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageDossier);
            this.tabControlMain.Controls.Add(this.tabPageLinks);
            this.tabControlMain.Controls.Add(this.tabPageInfo);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(937, 562);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageDossier
            // 
            this.tabPageDossier.Controls.Add(this.splitContainerDossier);
            this.tabPageDossier.Controls.Add(this.toolStrip1);
            this.tabPageDossier.Location = new System.Drawing.Point(4, 22);
            this.tabPageDossier.Name = "tabPageDossier";
            this.tabPageDossier.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDossier.Size = new System.Drawing.Size(929, 536);
            this.tabPageDossier.TabIndex = 0;
            this.tabPageDossier.Text = "Личные дела";
            this.tabPageDossier.UseVisualStyleBackColor = true;
            // 
            // tabPageLinks
            // 
            this.tabPageLinks.Location = new System.Drawing.Point(4, 22);
            this.tabPageLinks.Name = "tabPageLinks";
            this.tabPageLinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLinks.Size = new System.Drawing.Size(929, 536);
            this.tabPageLinks.TabIndex = 1;
            this.tabPageLinks.Text = "Ссылки";
            this.tabPageLinks.UseVisualStyleBackColor = true;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Size = new System.Drawing.Size(929, 536);
            this.tabPageInfo.TabIndex = 2;
            this.tabPageInfo.Text = "Информация";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(923, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // splitContainerDossier
            // 
            this.splitContainerDossier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDossier.Location = new System.Drawing.Point(3, 28);
            this.splitContainerDossier.Name = "splitContainerDossier";
            // 
            // splitContainerDossier.Panel1
            // 
            this.splitContainerDossier.Panel1.Controls.Add(this.dgvDossierList);
            // 
            // splitContainerDossier.Panel2
            // 
            this.splitContainerDossier.Panel2.Controls.Add(this.panelDossierPhoto);
            this.splitContainerDossier.Size = new System.Drawing.Size(923, 505);
            this.splitContainerDossier.SplitterDistance = 167;
            this.splitContainerDossier.TabIndex = 1;
            // 
            // dgvDossierList
            // 
            this.dgvDossierList.AllowUserToAddRows = false;
            this.dgvDossierList.AllowUserToDeleteRows = false;
            this.dgvDossierList.AllowUserToResizeColumns = false;
            this.dgvDossierList.AllowUserToResizeRows = false;
            this.dgvDossierList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDossierList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDossierList.Location = new System.Drawing.Point(0, 0);
            this.dgvDossierList.Name = "dgvDossierList";
            this.dgvDossierList.Size = new System.Drawing.Size(167, 505);
            this.dgvDossierList.TabIndex = 0;
            // 
            // panelDossierPhoto
            // 
            this.panelDossierPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDossierPhoto.Controls.Add(this.toolStripContainerDossierPhoto);
            this.panelDossierPhoto.Location = new System.Drawing.Point(498, 18);
            this.panelDossierPhoto.Name = "panelDossierPhoto";
            this.panelDossierPhoto.Size = new System.Drawing.Size(226, 285);
            this.panelDossierPhoto.TabIndex = 0;
            // 
            // toolStripContainerDossierPhoto
            // 
            // 
            // toolStripContainerDossierPhoto.ContentPanel
            // 
            this.toolStripContainerDossierPhoto.ContentPanel.Controls.Add(this.pictureBoxDossierPhoto);
            this.toolStripContainerDossierPhoto.ContentPanel.Size = new System.Drawing.Size(224, 258);
            this.toolStripContainerDossierPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainerDossierPhoto.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainerDossierPhoto.Name = "toolStripContainerDossierPhoto";
            this.toolStripContainerDossierPhoto.Size = new System.Drawing.Size(224, 283);
            this.toolStripContainerDossierPhoto.TabIndex = 0;
            this.toolStripContainerDossierPhoto.Text = "toolStripContainer1";
            // 
            // toolStripContainerDossierPhoto.TopToolStripPanel
            // 
            this.toolStripContainerDossierPhoto.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(64, 25);
            this.toolStrip2.TabIndex = 0;
            // 
            // pictureBoxDossierPhoto
            // 
            this.pictureBoxDossierPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDossierPhoto.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDossierPhoto.Name = "pictureBoxDossierPhoto";
            this.pictureBoxDossierPhoto.Size = new System.Drawing.Size(224, 258);
            this.pictureBoxDossierPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDossierPhoto.TabIndex = 0;
            this.pictureBoxDossierPhoto.TabStop = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // FormClassInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 562);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormClassInformation";
            this.Text = "FormClassInformation";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageDossier.ResumeLayout(false);
            this.tabPageDossier.PerformLayout();
            this.splitContainerDossier.Panel1.ResumeLayout(false);
            this.splitContainerDossier.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerDossier)).EndInit();
            this.splitContainerDossier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDossierList)).EndInit();
            this.panelDossierPhoto.ResumeLayout(false);
            this.toolStripContainerDossierPhoto.ContentPanel.ResumeLayout(false);
            this.toolStripContainerDossierPhoto.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainerDossierPhoto.TopToolStripPanel.PerformLayout();
            this.toolStripContainerDossierPhoto.ResumeLayout(false);
            this.toolStripContainerDossierPhoto.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDossierPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageDossier;
        private System.Windows.Forms.TabPage tabPageLinks;
        private System.Windows.Forms.SplitContainer splitContainerDossier;
        private System.Windows.Forms.DataGridView dgvDossierList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.Panel panelDossierPhoto;
        private System.Windows.Forms.ToolStripContainer toolStripContainerDossierPhoto;
        private System.Windows.Forms.PictureBox pictureBoxDossierPhoto;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}