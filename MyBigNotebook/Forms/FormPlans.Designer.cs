namespace MyBigNotebook.Forms
{
    partial class FormPlans
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlans));
            this.tabControlPlans = new System.Windows.Forms.TabControl();
            this.tabPageFuture = new System.Windows.Forms.TabPage();
            this.splitContainerFuture = new System.Windows.Forms.SplitContainer();
            this.dgvFutureList = new System.Windows.Forms.DataGridView();
            this.ColumnFutureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsFutureName = new System.Windows.Forms.ToolStrip();
            this.gbFuturePunkts = new System.Windows.Forms.GroupBox();
            this.dgvFuturePunkts = new System.Windows.Forms.DataGridView();
            this.tsFuterePunkt = new System.Windows.Forms.ToolStrip();
            this.gbFutureRealise = new System.Windows.Forms.GroupBox();
            this.dtpFutureRealiseDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageTargets = new System.Windows.Forms.TabPage();
            this.tabPageShopping = new System.Windows.Forms.TabPage();
            this.tabPageProjects = new System.Windows.Forms.TabPage();
            this.tsbFutureAdd = new System.Windows.Forms.ToolStripButton();
            this.TstbFutureAdd = new System.Windows.Forms.ToolStripTextBox();
            this.tsbFutureAddClose = new System.Windows.Forms.ToolStripButton();
            this.tsbFutureDelete = new System.Windows.Forms.ToolStripButton();
            this.ColumnFutureNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuturePunktName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuturePunktComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tsbFutureDelPunkt = new System.Windows.Forms.ToolStripButton();
            this.tspFutureAddPunks = new System.Windows.Forms.ToolStripButton();
            this.tabControlPlans.SuspendLayout();
            this.tabPageFuture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFuture)).BeginInit();
            this.splitContainerFuture.Panel1.SuspendLayout();
            this.splitContainerFuture.Panel2.SuspendLayout();
            this.splitContainerFuture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutureList)).BeginInit();
            this.tsFutureName.SuspendLayout();
            this.gbFuturePunkts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuturePunkts)).BeginInit();
            this.tsFuterePunkt.SuspendLayout();
            this.gbFutureRealise.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPlans
            // 
            this.tabControlPlans.Controls.Add(this.tabPageFuture);
            this.tabControlPlans.Controls.Add(this.tabPageTargets);
            this.tabControlPlans.Controls.Add(this.tabPageShopping);
            this.tabControlPlans.Controls.Add(this.tabPageProjects);
            this.tabControlPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPlans.Location = new System.Drawing.Point(0, 0);
            this.tabControlPlans.Name = "tabControlPlans";
            this.tabControlPlans.SelectedIndex = 0;
            this.tabControlPlans.Size = new System.Drawing.Size(918, 570);
            this.tabControlPlans.TabIndex = 0;
            // 
            // tabPageFuture
            // 
            this.tabPageFuture.Controls.Add(this.splitContainerFuture);
            this.tabPageFuture.Location = new System.Drawing.Point(4, 22);
            this.tabPageFuture.Name = "tabPageFuture";
            this.tabPageFuture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFuture.Size = new System.Drawing.Size(910, 544);
            this.tabPageFuture.TabIndex = 0;
            this.tabPageFuture.Text = "Планы на будущее";
            this.tabPageFuture.UseVisualStyleBackColor = true;
            // 
            // splitContainerFuture
            // 
            this.splitContainerFuture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFuture.Location = new System.Drawing.Point(3, 3);
            this.splitContainerFuture.Name = "splitContainerFuture";
            // 
            // splitContainerFuture.Panel1
            // 
            this.splitContainerFuture.Panel1.Controls.Add(this.dgvFutureList);
            this.splitContainerFuture.Panel1.Controls.Add(this.tsFutureName);
            // 
            // splitContainerFuture.Panel2
            // 
            this.splitContainerFuture.Panel2.Controls.Add(this.gbFuturePunkts);
            this.splitContainerFuture.Panel2.Controls.Add(this.gbFutureRealise);
            this.splitContainerFuture.Size = new System.Drawing.Size(904, 538);
            this.splitContainerFuture.SplitterDistance = 170;
            this.splitContainerFuture.TabIndex = 0;
            // 
            // dgvFutureList
            // 
            this.dgvFutureList.AllowUserToAddRows = false;
            this.dgvFutureList.AllowUserToDeleteRows = false;
            this.dgvFutureList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFutureList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFutureName});
            this.dgvFutureList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFutureList.Location = new System.Drawing.Point(0, 25);
            this.dgvFutureList.MultiSelect = false;
            this.dgvFutureList.Name = "dgvFutureList";
            this.dgvFutureList.ReadOnly = true;
            this.dgvFutureList.RowHeadersVisible = false;
            this.dgvFutureList.Size = new System.Drawing.Size(170, 513);
            this.dgvFutureList.TabIndex = 1;
            this.dgvFutureList.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvFutureList_CellStateChanged);
            // 
            // ColumnFutureName
            // 
            this.ColumnFutureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFutureName.HeaderText = "Название плана";
            this.ColumnFutureName.Name = "ColumnFutureName";
            this.ColumnFutureName.ReadOnly = true;
            // 
            // tsFutureName
            // 
            this.tsFutureName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFutureAdd,
            this.tsbFutureDelete,
            this.TstbFutureAdd,
            this.tsbFutureAddClose});
            this.tsFutureName.Location = new System.Drawing.Point(0, 0);
            this.tsFutureName.Name = "tsFutureName";
            this.tsFutureName.Size = new System.Drawing.Size(170, 25);
            this.tsFutureName.TabIndex = 0;
            this.tsFutureName.Text = "toolStrip1";
            // 
            // gbFuturePunkts
            // 
            this.gbFuturePunkts.Controls.Add(this.dgvFuturePunkts);
            this.gbFuturePunkts.Controls.Add(this.tsFuterePunkt);
            this.gbFuturePunkts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFuturePunkts.Location = new System.Drawing.Point(0, 53);
            this.gbFuturePunkts.Name = "gbFuturePunkts";
            this.gbFuturePunkts.Size = new System.Drawing.Size(730, 485);
            this.gbFuturePunkts.TabIndex = 1;
            this.gbFuturePunkts.TabStop = false;
            this.gbFuturePunkts.Text = "Пункты плана";
            // 
            // dgvFuturePunkts
            // 
            this.dgvFuturePunkts.AllowUserToAddRows = false;
            this.dgvFuturePunkts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuturePunkts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFutureNumber,
            this.ColumnFuturePunktName,
            this.ColumnFuturePunktComplete});
            this.dgvFuturePunkts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuturePunkts.Location = new System.Drawing.Point(3, 41);
            this.dgvFuturePunkts.MultiSelect = false;
            this.dgvFuturePunkts.Name = "dgvFuturePunkts";
            this.dgvFuturePunkts.RowHeadersVisible = false;
            this.dgvFuturePunkts.Size = new System.Drawing.Size(724, 441);
            this.dgvFuturePunkts.TabIndex = 1;
            // 
            // tsFuterePunkt
            // 
            this.tsFuterePunkt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspFutureAddPunks,
            this.tsbFutureDelPunkt});
            this.tsFuterePunkt.Location = new System.Drawing.Point(3, 16);
            this.tsFuterePunkt.Name = "tsFuterePunkt";
            this.tsFuterePunkt.Size = new System.Drawing.Size(724, 25);
            this.tsFuterePunkt.TabIndex = 0;
            this.tsFuterePunkt.Text = "toolStrip1";
            // 
            // gbFutureRealise
            // 
            this.gbFutureRealise.Controls.Add(this.dtpFutureRealiseDate);
            this.gbFutureRealise.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFutureRealise.Location = new System.Drawing.Point(0, 0);
            this.gbFutureRealise.Name = "gbFutureRealise";
            this.gbFutureRealise.Size = new System.Drawing.Size(730, 53);
            this.gbFutureRealise.TabIndex = 0;
            this.gbFutureRealise.TabStop = false;
            this.gbFutureRealise.Text = "Дата реализации";
            // 
            // dtpFutureRealiseDate
            // 
            this.dtpFutureRealiseDate.Location = new System.Drawing.Point(6, 19);
            this.dtpFutureRealiseDate.Name = "dtpFutureRealiseDate";
            this.dtpFutureRealiseDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFutureRealiseDate.TabIndex = 0;
            // 
            // tabPageTargets
            // 
            this.tabPageTargets.Location = new System.Drawing.Point(4, 22);
            this.tabPageTargets.Name = "tabPageTargets";
            this.tabPageTargets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTargets.Size = new System.Drawing.Size(910, 544);
            this.tabPageTargets.TabIndex = 1;
            this.tabPageTargets.Text = "Цели";
            this.tabPageTargets.UseVisualStyleBackColor = true;
            // 
            // tabPageShopping
            // 
            this.tabPageShopping.Location = new System.Drawing.Point(4, 22);
            this.tabPageShopping.Name = "tabPageShopping";
            this.tabPageShopping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShopping.Size = new System.Drawing.Size(910, 544);
            this.tabPageShopping.TabIndex = 2;
            this.tabPageShopping.Text = "Список покупок";
            this.tabPageShopping.UseVisualStyleBackColor = true;
            // 
            // tabPageProjects
            // 
            this.tabPageProjects.Location = new System.Drawing.Point(4, 22);
            this.tabPageProjects.Name = "tabPageProjects";
            this.tabPageProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProjects.Size = new System.Drawing.Size(910, 544);
            this.tabPageProjects.TabIndex = 3;
            this.tabPageProjects.Text = "Проекты";
            this.tabPageProjects.UseVisualStyleBackColor = true;
            // 
            // tsbFutureAdd
            // 
            this.tsbFutureAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFutureAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbFutureAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFutureAdd.Name = "tsbFutureAdd";
            this.tsbFutureAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbFutureAdd.Text = "toolStripButton1";
            this.tsbFutureAdd.Click += new System.EventHandler(this.tsbFutureAdd_Click);
            // 
            // TstbFutureAdd
            // 
            this.TstbFutureAdd.Name = "TstbFutureAdd";
            this.TstbFutureAdd.Size = new System.Drawing.Size(100, 23);
            this.TstbFutureAdd.Visible = false;
            this.TstbFutureAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TstbFutureAdd_KeyDown);
            // 
            // tsbFutureAddClose
            // 
            this.tsbFutureAddClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFutureAddClose.Image = global::MyBigNotebook.Properties.Resources.baseline_clear_black_36dp;
            this.tsbFutureAddClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFutureAddClose.Name = "tsbFutureAddClose";
            this.tsbFutureAddClose.Size = new System.Drawing.Size(23, 22);
            this.tsbFutureAddClose.Text = "Отмена";
            this.tsbFutureAddClose.Visible = false;
            this.tsbFutureAddClose.Click += new System.EventHandler(this.tsbFutureAddClose_Click);
            // 
            // tsbFutureDelete
            // 
            this.tsbFutureDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFutureDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbFutureDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFutureDelete.Name = "tsbFutureDelete";
            this.tsbFutureDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbFutureDelete.Text = "Удалить";
            this.tsbFutureDelete.Click += new System.EventHandler(this.tsbFutureDelete_Click);
            // 
            // ColumnFutureNumber
            // 
            this.ColumnFutureNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.ColumnFutureNumber.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnFutureNumber.HeaderText = "Номер";
            this.ColumnFutureNumber.MinimumWidth = 50;
            this.ColumnFutureNumber.Name = "ColumnFutureNumber";
            this.ColumnFutureNumber.Width = 66;
            // 
            // ColumnFuturePunktName
            // 
            this.ColumnFuturePunktName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFuturePunktName.HeaderText = "Текст пункта";
            this.ColumnFuturePunktName.MinimumWidth = 100;
            this.ColumnFuturePunktName.Name = "ColumnFuturePunktName";
            // 
            // ColumnFuturePunktComplete
            // 
            this.ColumnFuturePunktComplete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnFuturePunktComplete.HeaderText = "Флаг завершения";
            this.ColumnFuturePunktComplete.MinimumWidth = 50;
            this.ColumnFuturePunktComplete.Name = "ColumnFuturePunktComplete";
            this.ColumnFuturePunktComplete.Width = 95;
            // 
            // tsbFutureDelPunkt
            // 
            this.tsbFutureDelPunkt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFutureDelPunkt.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbFutureDelPunkt.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFutureDelPunkt.Name = "tsbFutureDelPunkt";
            this.tsbFutureDelPunkt.Size = new System.Drawing.Size(23, 22);
            this.tsbFutureDelPunkt.Text = "toolStripButton1";
            this.tsbFutureDelPunkt.Click += new System.EventHandler(this.tsbFutureDelPunkt_Click);
            // 
            // tspFutureAddPunks
            // 
            this.tspFutureAddPunks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspFutureAddPunks.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tspFutureAddPunks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspFutureAddPunks.Name = "tspFutureAddPunks";
            this.tspFutureAddPunks.Size = new System.Drawing.Size(23, 22);
            this.tspFutureAddPunks.Text = "toolStripButton2";
            this.tspFutureAddPunks.Click += new System.EventHandler(this.tspFutureAddPunks_Click);
            // 
            // FormPlans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 570);
            this.Controls.Add(this.tabControlPlans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPlans";
            this.Text = "Планы";
            this.tabControlPlans.ResumeLayout(false);
            this.tabPageFuture.ResumeLayout(false);
            this.splitContainerFuture.Panel1.ResumeLayout(false);
            this.splitContainerFuture.Panel1.PerformLayout();
            this.splitContainerFuture.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerFuture)).EndInit();
            this.splitContainerFuture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutureList)).EndInit();
            this.tsFutureName.ResumeLayout(false);
            this.tsFutureName.PerformLayout();
            this.gbFuturePunkts.ResumeLayout(false);
            this.gbFuturePunkts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuturePunkts)).EndInit();
            this.tsFuterePunkt.ResumeLayout(false);
            this.tsFuterePunkt.PerformLayout();
            this.gbFutureRealise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPlans;
        private System.Windows.Forms.TabPage tabPageFuture;
        private System.Windows.Forms.TabPage tabPageTargets;
        private System.Windows.Forms.TabPage tabPageShopping;
        private System.Windows.Forms.TabPage tabPageProjects;
        private System.Windows.Forms.SplitContainer splitContainerFuture;
        private System.Windows.Forms.DataGridView dgvFutureList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFutureName;
        private System.Windows.Forms.ToolStrip tsFutureName;
        private System.Windows.Forms.GroupBox gbFuturePunkts;
        private System.Windows.Forms.DataGridView dgvFuturePunkts;
        private System.Windows.Forms.ToolStrip tsFuterePunkt;
        private System.Windows.Forms.GroupBox gbFutureRealise;
        private System.Windows.Forms.DateTimePicker dtpFutureRealiseDate;
        private System.Windows.Forms.ToolStripButton tsbFutureAdd;
        private System.Windows.Forms.ToolStripTextBox TstbFutureAdd;
        private System.Windows.Forms.ToolStripButton tsbFutureAddClose;
        private System.Windows.Forms.ToolStripButton tsbFutureDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFutureNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFuturePunktName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnFuturePunktComplete;
        private System.Windows.Forms.ToolStripButton tspFutureAddPunks;
        private System.Windows.Forms.ToolStripButton tsbFutureDelPunkt;
    }
}