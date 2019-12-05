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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlans));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlPlans = new System.Windows.Forms.TabControl();
            this.tabPageFuture = new System.Windows.Forms.TabPage();
            this.splitContainerFuture = new System.Windows.Forms.SplitContainer();
            this.dgvFutureList = new System.Windows.Forms.DataGridView();
            this.ColumnFutureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsFutureName = new System.Windows.Forms.ToolStrip();
            this.tsbFutureAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbFutureDelete = new System.Windows.Forms.ToolStripButton();
            this.TstbFutureAdd = new System.Windows.Forms.ToolStripTextBox();
            this.tsbFutureAddClose = new System.Windows.Forms.ToolStripButton();
            this.gbFuturePunkts = new System.Windows.Forms.GroupBox();
            this.dgvFuturePunkts = new System.Windows.Forms.DataGridView();
            this.ColumnFutureNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuturePunktName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFuturePunktComplete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tsFuterePunkt = new System.Windows.Forms.ToolStrip();
            this.tspFutureAddPunks = new System.Windows.Forms.ToolStripButton();
            this.tsbFutureDelPunkt = new System.Windows.Forms.ToolStripButton();
            this.gbFutureRealise = new System.Windows.Forms.GroupBox();
            this.dtpFutureRealiseDate = new System.Windows.Forms.DateTimePicker();
            this.tabPageTargets = new System.Windows.Forms.TabPage();
            this.splitContainerTarget = new System.Windows.Forms.SplitContainer();
            this.dgvTargetList = new System.Windows.Forms.DataGridView();
            this.ColumnTargetName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTargetSteps = new System.Windows.Forms.GroupBox();
            this.dgvTargetSteps = new System.Windows.Forms.DataGridView();
            this.ColumnTargetStepNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStepDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStepFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tsTargetStep = new System.Windows.Forms.ToolStrip();
            this.tsbTargetStepAdd = new System.Windows.Forms.ToolStripButton();
            this.tspTargetStepDelete = new System.Windows.Forms.ToolStripButton();
            this.pTargetComplete = new System.Windows.Forms.Panel();
            this.checkTargetCompleteFlag = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTargetDescription = new System.Windows.Forms.GroupBox();
            this.rtbTargetDescription = new System.Windows.Forms.RichTextBox();
            this.gbTargetDateEnd = new System.Windows.Forms.GroupBox();
            this.dtpTargetDateEnd = new System.Windows.Forms.DateTimePicker();
            this.gbTargetDateStart = new System.Windows.Forms.GroupBox();
            this.dtpTargetDateStart = new System.Windows.Forms.DateTimePicker();
            this.tsTargetList = new System.Windows.Forms.ToolStrip();
            this.tsbTargetAdd = new System.Windows.Forms.ToolStripButton();
            this.tslTargetAdd = new System.Windows.Forms.ToolStripLabel();
            this.tstbTargetName = new System.Windows.Forms.ToolStripTextBox();
            this.tsbTargetCanselAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbTargetDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPageShopping = new System.Windows.Forms.TabPage();
            this.splitContainerShop = new System.Windows.Forms.SplitContainer();
            this.tvShoppingList = new System.Windows.Forms.TreeView();
            this.imageListShopping = new System.Windows.Forms.ImageList(this.components);
            this.gbShoppingDescription = new System.Windows.Forms.GroupBox();
            this.rtbShoppingDescription = new System.Windows.Forms.RichTextBox();
            this.gbShoppingFlag = new System.Windows.Forms.GroupBox();
            this.checkShoppingFlag = new System.Windows.Forms.CheckBox();
            this.gbShoppingCost = new System.Windows.Forms.GroupBox();
            this.tbShoppingCost = new System.Windows.Forms.TextBox();
            this.tsShoppingList = new System.Windows.Forms.ToolStrip();
            this.tsbShopAdd = new System.Windows.Forms.ToolStripButton();
            this.tslShopAdd = new System.Windows.Forms.ToolStripLabel();
            this.tstbShopAdd = new System.Windows.Forms.ToolStripTextBox();
            this.tsbShopCanselAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbShopDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPageProjects = new System.Windows.Forms.TabPage();
            this.splitContainerProject = new System.Windows.Forms.SplitContainer();
            this.dgvProgectsList = new System.Windows.Forms.DataGridView();
            this.gbProjectSteps = new System.Windows.Forms.GroupBox();
            this.dgvProgectSteps = new System.Windows.Forms.DataGridView();
            this.tsProjectStep = new System.Windows.Forms.ToolStrip();
            this.tsbProjectStepAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbProjectStepDelete = new System.Windows.Forms.ToolStripButton();
            this.gbProgectDescription = new System.Windows.Forms.GroupBox();
            this.rtbProjectDescription = new System.Windows.Forms.RichTextBox();
            this.gbProgectDate = new System.Windows.Forms.GroupBox();
            this.dtpProjectDate = new System.Windows.Forms.DateTimePicker();
            this.tsProjectList = new System.Windows.Forms.ToolStrip();
            this.tsbProjectAdd = new System.Windows.Forms.ToolStripButton();
            this.tslProjectAdd = new System.Windows.Forms.ToolStripLabel();
            this.tstbProjectName = new System.Windows.Forms.ToolStripTextBox();
            this.tsbProjectCanselAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbProjectDelete = new System.Windows.Forms.ToolStripButton();
            this.ColumnProjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProjectStepNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProjectStepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProjectStepDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProjectStepFlag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.tabPageTargets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTarget)).BeginInit();
            this.splitContainerTarget.Panel1.SuspendLayout();
            this.splitContainerTarget.Panel2.SuspendLayout();
            this.splitContainerTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetList)).BeginInit();
            this.gbTargetSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetSteps)).BeginInit();
            this.tsTargetStep.SuspendLayout();
            this.pTargetComplete.SuspendLayout();
            this.gbTargetDescription.SuspendLayout();
            this.gbTargetDateEnd.SuspendLayout();
            this.gbTargetDateStart.SuspendLayout();
            this.tsTargetList.SuspendLayout();
            this.tabPageShopping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerShop)).BeginInit();
            this.splitContainerShop.Panel1.SuspendLayout();
            this.splitContainerShop.Panel2.SuspendLayout();
            this.splitContainerShop.SuspendLayout();
            this.gbShoppingDescription.SuspendLayout();
            this.gbShoppingFlag.SuspendLayout();
            this.gbShoppingCost.SuspendLayout();
            this.tsShoppingList.SuspendLayout();
            this.tabPageProjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProject)).BeginInit();
            this.splitContainerProject.Panel1.SuspendLayout();
            this.splitContainerProject.Panel2.SuspendLayout();
            this.splitContainerProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgectsList)).BeginInit();
            this.gbProjectSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgectSteps)).BeginInit();
            this.tsProjectStep.SuspendLayout();
            this.gbProgectDescription.SuspendLayout();
            this.gbProgectDate.SuspendLayout();
            this.tsProjectList.SuspendLayout();
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
            // ColumnFutureNumber
            // 
            this.ColumnFutureNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle22.Format = "N0";
            dataGridViewCellStyle22.NullValue = "0";
            this.ColumnFutureNumber.DefaultCellStyle = dataGridViewCellStyle22;
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
            this.tabPageTargets.Controls.Add(this.splitContainerTarget);
            this.tabPageTargets.Controls.Add(this.tsTargetList);
            this.tabPageTargets.Location = new System.Drawing.Point(4, 22);
            this.tabPageTargets.Name = "tabPageTargets";
            this.tabPageTargets.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTargets.Size = new System.Drawing.Size(910, 544);
            this.tabPageTargets.TabIndex = 1;
            this.tabPageTargets.Text = "Цели";
            this.tabPageTargets.UseVisualStyleBackColor = true;
            // 
            // splitContainerTarget
            // 
            this.splitContainerTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTarget.Location = new System.Drawing.Point(3, 28);
            this.splitContainerTarget.Name = "splitContainerTarget";
            // 
            // splitContainerTarget.Panel1
            // 
            this.splitContainerTarget.Panel1.Controls.Add(this.dgvTargetList);
            // 
            // splitContainerTarget.Panel2
            // 
            this.splitContainerTarget.Panel2.Controls.Add(this.gbTargetSteps);
            this.splitContainerTarget.Panel2.Controls.Add(this.pTargetComplete);
            this.splitContainerTarget.Panel2.Controls.Add(this.gbTargetDescription);
            this.splitContainerTarget.Panel2.Controls.Add(this.gbTargetDateEnd);
            this.splitContainerTarget.Panel2.Controls.Add(this.gbTargetDateStart);
            this.splitContainerTarget.Size = new System.Drawing.Size(904, 513);
            this.splitContainerTarget.SplitterDistance = 170;
            this.splitContainerTarget.TabIndex = 1;
            // 
            // dgvTargetList
            // 
            this.dgvTargetList.AllowUserToAddRows = false;
            this.dgvTargetList.AllowUserToDeleteRows = false;
            this.dgvTargetList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTargetList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTargetName});
            this.dgvTargetList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTargetList.Location = new System.Drawing.Point(0, 0);
            this.dgvTargetList.MultiSelect = false;
            this.dgvTargetList.Name = "dgvTargetList";
            this.dgvTargetList.ReadOnly = true;
            this.dgvTargetList.RowHeadersVisible = false;
            this.dgvTargetList.Size = new System.Drawing.Size(170, 513);
            this.dgvTargetList.TabIndex = 0;
            this.dgvTargetList.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvTargetList_CellStateChanged);
            // 
            // ColumnTargetName
            // 
            this.ColumnTargetName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTargetName.HeaderText = "Имя";
            this.ColumnTargetName.Name = "ColumnTargetName";
            this.ColumnTargetName.ReadOnly = true;
            // 
            // gbTargetSteps
            // 
            this.gbTargetSteps.Controls.Add(this.dgvTargetSteps);
            this.gbTargetSteps.Controls.Add(this.tsTargetStep);
            this.gbTargetSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTargetSteps.Location = new System.Drawing.Point(0, 181);
            this.gbTargetSteps.Name = "gbTargetSteps";
            this.gbTargetSteps.Size = new System.Drawing.Size(730, 295);
            this.gbTargetSteps.TabIndex = 4;
            this.gbTargetSteps.TabStop = false;
            this.gbTargetSteps.Text = "Шаги достижения";
            // 
            // dgvTargetSteps
            // 
            this.dgvTargetSteps.AllowUserToAddRows = false;
            this.dgvTargetSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTargetSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTargetStepNumber,
            this.ColumnStepName,
            this.ColumnStepDescription,
            this.ColumnStepFlag});
            this.dgvTargetSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTargetSteps.Location = new System.Drawing.Point(27, 16);
            this.dgvTargetSteps.MultiSelect = false;
            this.dgvTargetSteps.Name = "dgvTargetSteps";
            this.dgvTargetSteps.RowHeadersVisible = false;
            this.dgvTargetSteps.Size = new System.Drawing.Size(700, 276);
            this.dgvTargetSteps.TabIndex = 0;
            // 
            // ColumnTargetStepNumber
            // 
            this.ColumnTargetStepNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle23.Format = "N0";
            dataGridViewCellStyle23.NullValue = null;
            this.ColumnTargetStepNumber.DefaultCellStyle = dataGridViewCellStyle23;
            this.ColumnTargetStepNumber.HeaderText = "Номер шага";
            this.ColumnTargetStepNumber.MinimumWidth = 50;
            this.ColumnTargetStepNumber.Name = "ColumnTargetStepNumber";
            this.ColumnTargetStepNumber.Width = 87;
            // 
            // ColumnStepName
            // 
            this.ColumnStepName.HeaderText = "Название";
            this.ColumnStepName.Name = "ColumnStepName";
            // 
            // ColumnStepDescription
            // 
            this.ColumnStepDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStepDescription.HeaderText = "Описание";
            this.ColumnStepDescription.MinimumWidth = 100;
            this.ColumnStepDescription.Name = "ColumnStepDescription";
            // 
            // ColumnStepFlag
            // 
            this.ColumnStepFlag.HeaderText = "Отметка о завершении";
            this.ColumnStepFlag.Name = "ColumnStepFlag";
            // 
            // tsTargetStep
            // 
            this.tsTargetStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsTargetStep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTargetStepAdd,
            this.tspTargetStepDelete});
            this.tsTargetStep.Location = new System.Drawing.Point(3, 16);
            this.tsTargetStep.Name = "tsTargetStep";
            this.tsTargetStep.Size = new System.Drawing.Size(24, 276);
            this.tsTargetStep.TabIndex = 1;
            this.tsTargetStep.Text = "toolStrip1";
            // 
            // tsbTargetStepAdd
            // 
            this.tsbTargetStepAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTargetStepAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbTargetStepAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTargetStepAdd.Name = "tsbTargetStepAdd";
            this.tsbTargetStepAdd.Size = new System.Drawing.Size(21, 20);
            this.tsbTargetStepAdd.Text = "Добавить шаг";
            this.tsbTargetStepAdd.Click += new System.EventHandler(this.tsbTargetStepAdd_Click);
            // 
            // tspTargetStepDelete
            // 
            this.tspTargetStepDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tspTargetStepDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tspTargetStepDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspTargetStepDelete.Name = "tspTargetStepDelete";
            this.tspTargetStepDelete.Size = new System.Drawing.Size(21, 20);
            this.tspTargetStepDelete.Text = "Удалить шаг";
            this.tspTargetStepDelete.Click += new System.EventHandler(this.tspTargetStepDelete_Click);
            // 
            // pTargetComplete
            // 
            this.pTargetComplete.Controls.Add(this.checkTargetCompleteFlag);
            this.pTargetComplete.Controls.Add(this.label1);
            this.pTargetComplete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pTargetComplete.Location = new System.Drawing.Point(0, 476);
            this.pTargetComplete.Name = "pTargetComplete";
            this.pTargetComplete.Size = new System.Drawing.Size(730, 37);
            this.pTargetComplete.TabIndex = 3;
            // 
            // checkTargetCompleteFlag
            // 
            this.checkTargetCompleteFlag.AutoSize = true;
            this.checkTargetCompleteFlag.Location = new System.Drawing.Point(143, 10);
            this.checkTargetCompleteFlag.Name = "checkTargetCompleteFlag";
            this.checkTargetCompleteFlag.Size = new System.Drawing.Size(15, 14);
            this.checkTargetCompleteFlag.TabIndex = 1;
            this.checkTargetCompleteFlag.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отметка о завершении";
            // 
            // gbTargetDescription
            // 
            this.gbTargetDescription.Controls.Add(this.rtbTargetDescription);
            this.gbTargetDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTargetDescription.Location = new System.Drawing.Point(0, 90);
            this.gbTargetDescription.Name = "gbTargetDescription";
            this.gbTargetDescription.Size = new System.Drawing.Size(730, 91);
            this.gbTargetDescription.TabIndex = 2;
            this.gbTargetDescription.TabStop = false;
            this.gbTargetDescription.Text = "Описание";
            // 
            // rtbTargetDescription
            // 
            this.rtbTargetDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTargetDescription.Location = new System.Drawing.Point(3, 16);
            this.rtbTargetDescription.Name = "rtbTargetDescription";
            this.rtbTargetDescription.Size = new System.Drawing.Size(724, 72);
            this.rtbTargetDescription.TabIndex = 0;
            this.rtbTargetDescription.Text = "";
            // 
            // gbTargetDateEnd
            // 
            this.gbTargetDateEnd.Controls.Add(this.dtpTargetDateEnd);
            this.gbTargetDateEnd.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTargetDateEnd.Location = new System.Drawing.Point(0, 45);
            this.gbTargetDateEnd.Name = "gbTargetDateEnd";
            this.gbTargetDateEnd.Size = new System.Drawing.Size(730, 45);
            this.gbTargetDateEnd.TabIndex = 1;
            this.gbTargetDateEnd.TabStop = false;
            this.gbTargetDateEnd.Text = "Примерная дата завершения";
            // 
            // dtpTargetDateEnd
            // 
            this.dtpTargetDateEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTargetDateEnd.Location = new System.Drawing.Point(3, 16);
            this.dtpTargetDateEnd.Name = "dtpTargetDateEnd";
            this.dtpTargetDateEnd.Size = new System.Drawing.Size(724, 20);
            this.dtpTargetDateEnd.TabIndex = 0;
            // 
            // gbTargetDateStart
            // 
            this.gbTargetDateStart.Controls.Add(this.dtpTargetDateStart);
            this.gbTargetDateStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTargetDateStart.Location = new System.Drawing.Point(0, 0);
            this.gbTargetDateStart.Name = "gbTargetDateStart";
            this.gbTargetDateStart.Size = new System.Drawing.Size(730, 45);
            this.gbTargetDateStart.TabIndex = 0;
            this.gbTargetDateStart.TabStop = false;
            this.gbTargetDateStart.Text = "Дата начала реализации";
            // 
            // dtpTargetDateStart
            // 
            this.dtpTargetDateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTargetDateStart.Location = new System.Drawing.Point(3, 16);
            this.dtpTargetDateStart.Name = "dtpTargetDateStart";
            this.dtpTargetDateStart.Size = new System.Drawing.Size(724, 20);
            this.dtpTargetDateStart.TabIndex = 0;
            // 
            // tsTargetList
            // 
            this.tsTargetList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbTargetAdd,
            this.tslTargetAdd,
            this.tstbTargetName,
            this.tsbTargetCanselAdd,
            this.tsbTargetDelete});
            this.tsTargetList.Location = new System.Drawing.Point(3, 3);
            this.tsTargetList.Name = "tsTargetList";
            this.tsTargetList.Size = new System.Drawing.Size(904, 25);
            this.tsTargetList.TabIndex = 0;
            this.tsTargetList.Text = "toolStrip1";
            // 
            // tsbTargetAdd
            // 
            this.tsbTargetAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTargetAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbTargetAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTargetAdd.Name = "tsbTargetAdd";
            this.tsbTargetAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbTargetAdd.Text = "Добавить";
            this.tsbTargetAdd.Click += new System.EventHandler(this.tsbTargetAdd_Click);
            // 
            // tslTargetAdd
            // 
            this.tslTargetAdd.Name = "tslTargetAdd";
            this.tslTargetAdd.Size = new System.Drawing.Size(136, 22);
            this.tslTargetAdd.Text = "Введите название цели:";
            this.tslTargetAdd.Visible = false;
            // 
            // tstbTargetName
            // 
            this.tstbTargetName.Name = "tstbTargetName";
            this.tstbTargetName.Size = new System.Drawing.Size(100, 25);
            this.tstbTargetName.Visible = false;
            this.tstbTargetName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbTargetName_KeyDown);
            // 
            // tsbTargetCanselAdd
            // 
            this.tsbTargetCanselAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTargetCanselAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_clear_black_36dp;
            this.tsbTargetCanselAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTargetCanselAdd.Name = "tsbTargetCanselAdd";
            this.tsbTargetCanselAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbTargetCanselAdd.Text = "Отменить добавление";
            this.tsbTargetCanselAdd.Visible = false;
            this.tsbTargetCanselAdd.Click += new System.EventHandler(this.tsbTargetCanselAdd_Click);
            // 
            // tsbTargetDelete
            // 
            this.tsbTargetDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTargetDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbTargetDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTargetDelete.Name = "tsbTargetDelete";
            this.tsbTargetDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbTargetDelete.Text = "Удалить";
            this.tsbTargetDelete.Click += new System.EventHandler(this.tsbTargetDelete_Click);
            // 
            // tabPageShopping
            // 
            this.tabPageShopping.Controls.Add(this.splitContainerShop);
            this.tabPageShopping.Controls.Add(this.tsShoppingList);
            this.tabPageShopping.Location = new System.Drawing.Point(4, 22);
            this.tabPageShopping.Name = "tabPageShopping";
            this.tabPageShopping.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShopping.Size = new System.Drawing.Size(910, 544);
            this.tabPageShopping.TabIndex = 2;
            this.tabPageShopping.Text = "Список покупок";
            this.tabPageShopping.UseVisualStyleBackColor = true;
            // 
            // splitContainerShop
            // 
            this.splitContainerShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerShop.Location = new System.Drawing.Point(3, 28);
            this.splitContainerShop.Name = "splitContainerShop";
            // 
            // splitContainerShop.Panel1
            // 
            this.splitContainerShop.Panel1.Controls.Add(this.tvShoppingList);
            // 
            // splitContainerShop.Panel2
            // 
            this.splitContainerShop.Panel2.Controls.Add(this.gbShoppingDescription);
            this.splitContainerShop.Panel2.Controls.Add(this.gbShoppingFlag);
            this.splitContainerShop.Panel2.Controls.Add(this.gbShoppingCost);
            this.splitContainerShop.Size = new System.Drawing.Size(904, 513);
            this.splitContainerShop.SplitterDistance = 170;
            this.splitContainerShop.TabIndex = 1;
            // 
            // tvShoppingList
            // 
            this.tvShoppingList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvShoppingList.ImageIndex = 1;
            this.tvShoppingList.ImageList = this.imageListShopping;
            this.tvShoppingList.Location = new System.Drawing.Point(0, 0);
            this.tvShoppingList.Name = "tvShoppingList";
            this.tvShoppingList.SelectedImageIndex = 2;
            this.tvShoppingList.Size = new System.Drawing.Size(170, 513);
            this.tvShoppingList.TabIndex = 0;
            this.tvShoppingList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvShoppingList_AfterSelect);
            // 
            // imageListShopping
            // 
            this.imageListShopping.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListShopping.ImageStream")));
            this.imageListShopping.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListShopping.Images.SetKeyName(0, "baseline_done_black_36dp.png");
            this.imageListShopping.Images.SetKeyName(1, "baseline_label_black_36dp.png");
            this.imageListShopping.Images.SetKeyName(2, "baseline_hourglass_empty_black_36dp.png");
            // 
            // gbShoppingDescription
            // 
            this.gbShoppingDescription.Controls.Add(this.rtbShoppingDescription);
            this.gbShoppingDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbShoppingDescription.Location = new System.Drawing.Point(0, 100);
            this.gbShoppingDescription.Name = "gbShoppingDescription";
            this.gbShoppingDescription.Size = new System.Drawing.Size(730, 413);
            this.gbShoppingDescription.TabIndex = 2;
            this.gbShoppingDescription.TabStop = false;
            this.gbShoppingDescription.Text = "Описание";
            // 
            // rtbShoppingDescription
            // 
            this.rtbShoppingDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbShoppingDescription.Location = new System.Drawing.Point(3, 16);
            this.rtbShoppingDescription.Name = "rtbShoppingDescription";
            this.rtbShoppingDescription.Size = new System.Drawing.Size(724, 394);
            this.rtbShoppingDescription.TabIndex = 0;
            this.rtbShoppingDescription.Text = "";
            this.rtbShoppingDescription.TextChanged += new System.EventHandler(this.rtbShoppingDescription_TextChanged);
            // 
            // gbShoppingFlag
            // 
            this.gbShoppingFlag.Controls.Add(this.checkShoppingFlag);
            this.gbShoppingFlag.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbShoppingFlag.Location = new System.Drawing.Point(0, 50);
            this.gbShoppingFlag.Name = "gbShoppingFlag";
            this.gbShoppingFlag.Size = new System.Drawing.Size(730, 50);
            this.gbShoppingFlag.TabIndex = 1;
            this.gbShoppingFlag.TabStop = false;
            this.gbShoppingFlag.Text = "Отметка о выполнении";
            // 
            // checkShoppingFlag
            // 
            this.checkShoppingFlag.AutoSize = true;
            this.checkShoppingFlag.Location = new System.Drawing.Point(6, 19);
            this.checkShoppingFlag.Name = "checkShoppingFlag";
            this.checkShoppingFlag.Size = new System.Drawing.Size(236, 17);
            this.checkShoppingFlag.TabIndex = 0;
            this.checkShoppingFlag.Text = "Позиция приобретена/покупка отменена";
            this.checkShoppingFlag.UseVisualStyleBackColor = true;
            this.checkShoppingFlag.CheckedChanged += new System.EventHandler(this.checkShoppingFlag_CheckedChanged);
            // 
            // gbShoppingCost
            // 
            this.gbShoppingCost.Controls.Add(this.tbShoppingCost);
            this.gbShoppingCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbShoppingCost.Location = new System.Drawing.Point(0, 0);
            this.gbShoppingCost.Name = "gbShoppingCost";
            this.gbShoppingCost.Size = new System.Drawing.Size(730, 50);
            this.gbShoppingCost.TabIndex = 0;
            this.gbShoppingCost.TabStop = false;
            this.gbShoppingCost.Text = "Цена";
            // 
            // tbShoppingCost
            // 
            this.tbShoppingCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbShoppingCost.Location = new System.Drawing.Point(3, 16);
            this.tbShoppingCost.Name = "tbShoppingCost";
            this.tbShoppingCost.Size = new System.Drawing.Size(724, 20);
            this.tbShoppingCost.TabIndex = 0;
            this.tbShoppingCost.TextChanged += new System.EventHandler(this.tbShoppingCost_TextChanged);
            this.tbShoppingCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbShoppingCost_KeyPress);
            // 
            // tsShoppingList
            // 
            this.tsShoppingList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbShopAdd,
            this.tslShopAdd,
            this.tstbShopAdd,
            this.tsbShopCanselAdd,
            this.tsbShopDelete});
            this.tsShoppingList.Location = new System.Drawing.Point(3, 3);
            this.tsShoppingList.Name = "tsShoppingList";
            this.tsShoppingList.Size = new System.Drawing.Size(904, 25);
            this.tsShoppingList.TabIndex = 0;
            this.tsShoppingList.Text = "toolStrip2";
            // 
            // tsbShopAdd
            // 
            this.tsbShopAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShopAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbShopAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShopAdd.Name = "tsbShopAdd";
            this.tsbShopAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbShopAdd.Text = "Добавить";
            this.tsbShopAdd.Click += new System.EventHandler(this.tsbShopAdd_Click);
            // 
            // tslShopAdd
            // 
            this.tslShopAdd.Name = "tslShopAdd";
            this.tslShopAdd.Size = new System.Drawing.Size(106, 22);
            this.tslShopAdd.Text = "Введите название:";
            this.tslShopAdd.Visible = false;
            // 
            // tstbShopAdd
            // 
            this.tstbShopAdd.Name = "tstbShopAdd";
            this.tstbShopAdd.Size = new System.Drawing.Size(100, 25);
            this.tstbShopAdd.Visible = false;
            this.tstbShopAdd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbShopAdd_KeyDown);
            // 
            // tsbShopCanselAdd
            // 
            this.tsbShopCanselAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShopCanselAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_clear_black_36dp;
            this.tsbShopCanselAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShopCanselAdd.Name = "tsbShopCanselAdd";
            this.tsbShopCanselAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbShopCanselAdd.Text = "Отмена";
            this.tsbShopCanselAdd.Visible = false;
            this.tsbShopCanselAdd.Click += new System.EventHandler(this.tsbShopCanselAdd_Click);
            // 
            // tsbShopDelete
            // 
            this.tsbShopDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbShopDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbShopDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShopDelete.Name = "tsbShopDelete";
            this.tsbShopDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbShopDelete.Text = "Удалить";
            this.tsbShopDelete.Click += new System.EventHandler(this.tsbShopDelete_Click);
            // 
            // tabPageProjects
            // 
            this.tabPageProjects.Controls.Add(this.splitContainerProject);
            this.tabPageProjects.Controls.Add(this.tsProjectList);
            this.tabPageProjects.Location = new System.Drawing.Point(4, 22);
            this.tabPageProjects.Name = "tabPageProjects";
            this.tabPageProjects.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProjects.Size = new System.Drawing.Size(910, 544);
            this.tabPageProjects.TabIndex = 3;
            this.tabPageProjects.Text = "Проекты";
            this.tabPageProjects.UseVisualStyleBackColor = true;
            // 
            // splitContainerProject
            // 
            this.splitContainerProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerProject.Location = new System.Drawing.Point(3, 28);
            this.splitContainerProject.Name = "splitContainerProject";
            // 
            // splitContainerProject.Panel1
            // 
            this.splitContainerProject.Panel1.Controls.Add(this.dgvProgectsList);
            // 
            // splitContainerProject.Panel2
            // 
            this.splitContainerProject.Panel2.Controls.Add(this.gbProjectSteps);
            this.splitContainerProject.Panel2.Controls.Add(this.gbProgectDescription);
            this.splitContainerProject.Panel2.Controls.Add(this.gbProgectDate);
            this.splitContainerProject.Size = new System.Drawing.Size(904, 513);
            this.splitContainerProject.SplitterDistance = 170;
            this.splitContainerProject.TabIndex = 1;
            // 
            // dgvProgectsList
            // 
            this.dgvProgectsList.AllowUserToAddRows = false;
            this.dgvProgectsList.AllowUserToDeleteRows = false;
            this.dgvProgectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgectsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProjectName});
            this.dgvProgectsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgectsList.Location = new System.Drawing.Point(0, 0);
            this.dgvProgectsList.MultiSelect = false;
            this.dgvProgectsList.Name = "dgvProgectsList";
            this.dgvProgectsList.ReadOnly = true;
            this.dgvProgectsList.RowHeadersVisible = false;
            this.dgvProgectsList.Size = new System.Drawing.Size(170, 513);
            this.dgvProgectsList.TabIndex = 0;
            this.dgvProgectsList.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvProgectsList_CellStateChanged);
            // 
            // gbProjectSteps
            // 
            this.gbProjectSteps.Controls.Add(this.dgvProgectSteps);
            this.gbProjectSteps.Controls.Add(this.tsProjectStep);
            this.gbProjectSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProjectSteps.Location = new System.Drawing.Point(0, 163);
            this.gbProjectSteps.Name = "gbProjectSteps";
            this.gbProjectSteps.Size = new System.Drawing.Size(730, 350);
            this.gbProjectSteps.TabIndex = 2;
            this.gbProjectSteps.TabStop = false;
            this.gbProjectSteps.Text = "Шаги реализации проекта";
            // 
            // dgvProgectSteps
            // 
            this.dgvProgectSteps.AllowUserToAddRows = false;
            this.dgvProgectSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgectSteps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProjectStepNumber,
            this.ColumnProjectStepName,
            this.ColumnProjectStepDescription,
            this.ColumnProjectStepFlag});
            this.dgvProgectSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProgectSteps.Location = new System.Drawing.Point(27, 16);
            this.dgvProgectSteps.MultiSelect = false;
            this.dgvProgectSteps.Name = "dgvProgectSteps";
            this.dgvProgectSteps.RowHeadersVisible = false;
            this.dgvProgectSteps.Size = new System.Drawing.Size(700, 331);
            this.dgvProgectSteps.TabIndex = 1;
            // 
            // tsProjectStep
            // 
            this.tsProjectStep.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsProjectStep.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProjectStepAdd,
            this.tsbProjectStepDelete});
            this.tsProjectStep.Location = new System.Drawing.Point(3, 16);
            this.tsProjectStep.Name = "tsProjectStep";
            this.tsProjectStep.Size = new System.Drawing.Size(24, 331);
            this.tsProjectStep.TabIndex = 0;
            this.tsProjectStep.Text = "toolStrip1";
            // 
            // tsbProjectStepAdd
            // 
            this.tsbProjectStepAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProjectStepAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbProjectStepAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProjectStepAdd.Name = "tsbProjectStepAdd";
            this.tsbProjectStepAdd.Size = new System.Drawing.Size(29, 20);
            this.tsbProjectStepAdd.Text = "Добавить шаг";
            this.tsbProjectStepAdd.Click += new System.EventHandler(this.tsbProjectStepAdd_Click);
            // 
            // tsbProjectStepDelete
            // 
            this.tsbProjectStepDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProjectStepDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbProjectStepDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProjectStepDelete.Name = "tsbProjectStepDelete";
            this.tsbProjectStepDelete.Size = new System.Drawing.Size(29, 20);
            this.tsbProjectStepDelete.Text = "Удалить шаг";
            this.tsbProjectStepDelete.Click += new System.EventHandler(this.tsbProjectStepDelete_Click);
            // 
            // gbProgectDescription
            // 
            this.gbProgectDescription.Controls.Add(this.rtbProjectDescription);
            this.gbProgectDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProgectDescription.Location = new System.Drawing.Point(0, 45);
            this.gbProgectDescription.Name = "gbProgectDescription";
            this.gbProgectDescription.Size = new System.Drawing.Size(730, 118);
            this.gbProgectDescription.TabIndex = 1;
            this.gbProgectDescription.TabStop = false;
            this.gbProgectDescription.Text = "Описание";
            // 
            // rtbProjectDescription
            // 
            this.rtbProjectDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbProjectDescription.Location = new System.Drawing.Point(3, 16);
            this.rtbProjectDescription.Name = "rtbProjectDescription";
            this.rtbProjectDescription.Size = new System.Drawing.Size(724, 99);
            this.rtbProjectDescription.TabIndex = 0;
            this.rtbProjectDescription.Text = "";
            // 
            // gbProgectDate
            // 
            this.gbProgectDate.Controls.Add(this.dtpProjectDate);
            this.gbProgectDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbProgectDate.Location = new System.Drawing.Point(0, 0);
            this.gbProgectDate.Name = "gbProgectDate";
            this.gbProgectDate.Size = new System.Drawing.Size(730, 45);
            this.gbProgectDate.TabIndex = 0;
            this.gbProgectDate.TabStop = false;
            this.gbProgectDate.Text = "Дата начала проекта";
            // 
            // dtpProjectDate
            // 
            this.dtpProjectDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpProjectDate.Location = new System.Drawing.Point(3, 16);
            this.dtpProjectDate.Name = "dtpProjectDate";
            this.dtpProjectDate.Size = new System.Drawing.Size(724, 20);
            this.dtpProjectDate.TabIndex = 0;
            // 
            // tsProjectList
            // 
            this.tsProjectList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProjectAdd,
            this.tsbProjectDelete,
            this.tslProjectAdd,
            this.tstbProjectName,
            this.tsbProjectCanselAdd});
            this.tsProjectList.Location = new System.Drawing.Point(3, 3);
            this.tsProjectList.Name = "tsProjectList";
            this.tsProjectList.Size = new System.Drawing.Size(904, 25);
            this.tsProjectList.TabIndex = 0;
            // 
            // tsbProjectAdd
            // 
            this.tsbProjectAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProjectAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbProjectAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProjectAdd.Name = "tsbProjectAdd";
            this.tsbProjectAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbProjectAdd.Text = "Добавить";
            this.tsbProjectAdd.Click += new System.EventHandler(this.tsbProjectAdd_Click);
            // 
            // tslProjectAdd
            // 
            this.tslProjectAdd.Name = "tslProjectAdd";
            this.tslProjectAdd.Size = new System.Drawing.Size(62, 22);
            this.tslProjectAdd.Text = "Название:";
            this.tslProjectAdd.Visible = false;
            // 
            // tstbProjectName
            // 
            this.tstbProjectName.Name = "tstbProjectName";
            this.tstbProjectName.Size = new System.Drawing.Size(100, 25);
            this.tstbProjectName.Visible = false;
            this.tstbProjectName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbProjectName_KeyDown);
            // 
            // tsbProjectCanselAdd
            // 
            this.tsbProjectCanselAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProjectCanselAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_clear_black_36dp;
            this.tsbProjectCanselAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProjectCanselAdd.Name = "tsbProjectCanselAdd";
            this.tsbProjectCanselAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbProjectCanselAdd.Text = "Отменить добавление";
            this.tsbProjectCanselAdd.Visible = false;
            this.tsbProjectCanselAdd.Click += new System.EventHandler(this.tsbProjectCanselAdd_Click);
            // 
            // tsbProjectDelete
            // 
            this.tsbProjectDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProjectDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbProjectDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProjectDelete.Name = "tsbProjectDelete";
            this.tsbProjectDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbProjectDelete.Text = "Удалить";
            this.tsbProjectDelete.Click += new System.EventHandler(this.tsbProjectDelete_Click);
            // 
            // ColumnProjectName
            // 
            this.ColumnProjectName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProjectName.HeaderText = "Название проекта";
            this.ColumnProjectName.MinimumWidth = 50;
            this.ColumnProjectName.Name = "ColumnProjectName";
            this.ColumnProjectName.ReadOnly = true;
            // 
            // ColumnProjectStepNumber
            // 
            this.ColumnProjectStepNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle24.Format = "N0";
            dataGridViewCellStyle24.NullValue = "0";
            this.ColumnProjectStepNumber.DefaultCellStyle = dataGridViewCellStyle24;
            this.ColumnProjectStepNumber.HeaderText = "Номер шага";
            this.ColumnProjectStepNumber.Name = "ColumnProjectStepNumber";
            this.ColumnProjectStepNumber.Width = 94;
            // 
            // ColumnProjectStepName
            // 
            this.ColumnProjectStepName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnProjectStepName.HeaderText = "Название шага";
            this.ColumnProjectStepName.MinimumWidth = 100;
            this.ColumnProjectStepName.Name = "ColumnProjectStepName";
            this.ColumnProjectStepName.Width = 101;
            // 
            // ColumnProjectStepDescription
            // 
            this.ColumnProjectStepDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProjectStepDescription.HeaderText = "Описание";
            this.ColumnProjectStepDescription.MinimumWidth = 105;
            this.ColumnProjectStepDescription.Name = "ColumnProjectStepDescription";
            // 
            // ColumnProjectStepFlag
            // 
            this.ColumnProjectStepFlag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnProjectStepFlag.HeaderText = "Отметка о выполнении";
            this.ColumnProjectStepFlag.Name = "ColumnProjectStepFlag";
            this.ColumnProjectStepFlag.Width = 118;
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
            this.tabPageTargets.ResumeLayout(false);
            this.tabPageTargets.PerformLayout();
            this.splitContainerTarget.Panel1.ResumeLayout(false);
            this.splitContainerTarget.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTarget)).EndInit();
            this.splitContainerTarget.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetList)).EndInit();
            this.gbTargetSteps.ResumeLayout(false);
            this.gbTargetSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTargetSteps)).EndInit();
            this.tsTargetStep.ResumeLayout(false);
            this.tsTargetStep.PerformLayout();
            this.pTargetComplete.ResumeLayout(false);
            this.pTargetComplete.PerformLayout();
            this.gbTargetDescription.ResumeLayout(false);
            this.gbTargetDateEnd.ResumeLayout(false);
            this.gbTargetDateStart.ResumeLayout(false);
            this.tsTargetList.ResumeLayout(false);
            this.tsTargetList.PerformLayout();
            this.tabPageShopping.ResumeLayout(false);
            this.tabPageShopping.PerformLayout();
            this.splitContainerShop.Panel1.ResumeLayout(false);
            this.splitContainerShop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerShop)).EndInit();
            this.splitContainerShop.ResumeLayout(false);
            this.gbShoppingDescription.ResumeLayout(false);
            this.gbShoppingFlag.ResumeLayout(false);
            this.gbShoppingFlag.PerformLayout();
            this.gbShoppingCost.ResumeLayout(false);
            this.gbShoppingCost.PerformLayout();
            this.tsShoppingList.ResumeLayout(false);
            this.tsShoppingList.PerformLayout();
            this.tabPageProjects.ResumeLayout(false);
            this.tabPageProjects.PerformLayout();
            this.splitContainerProject.Panel1.ResumeLayout(false);
            this.splitContainerProject.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerProject)).EndInit();
            this.splitContainerProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgectsList)).EndInit();
            this.gbProjectSteps.ResumeLayout(false);
            this.gbProjectSteps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgectSteps)).EndInit();
            this.tsProjectStep.ResumeLayout(false);
            this.tsProjectStep.PerformLayout();
            this.gbProgectDescription.ResumeLayout(false);
            this.gbProgectDate.ResumeLayout(false);
            this.tsProjectList.ResumeLayout(false);
            this.tsProjectList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPlans;
        private System.Windows.Forms.TabPage tabPageFuture;
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
        private System.Windows.Forms.TabPage tabPageTargets;
        private System.Windows.Forms.SplitContainer splitContainerTarget;
        private System.Windows.Forms.DataGridView dgvTargetList;
        private System.Windows.Forms.ToolStrip tsTargetList;
        private System.Windows.Forms.GroupBox gbTargetDateStart;
        private System.Windows.Forms.GroupBox gbTargetDescription;
        private System.Windows.Forms.RichTextBox rtbTargetDescription;
        private System.Windows.Forms.GroupBox gbTargetDateEnd;
        private System.Windows.Forms.DateTimePicker dtpTargetDateEnd;
        private System.Windows.Forms.DateTimePicker dtpTargetDateStart;
        private System.Windows.Forms.GroupBox gbTargetSteps;
        private System.Windows.Forms.DataGridView dgvTargetSteps;
        private System.Windows.Forms.Panel pTargetComplete;
        private System.Windows.Forms.CheckBox checkTargetCompleteFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsTargetStep;
        private System.Windows.Forms.ToolStripButton tsbTargetStepAdd;
        private System.Windows.Forms.ToolStripButton tspTargetStepDelete;
        private System.Windows.Forms.ToolStripButton tsbTargetAdd;
        private System.Windows.Forms.ToolStripLabel tslTargetAdd;
        private System.Windows.Forms.ToolStripTextBox tstbTargetName;
        private System.Windows.Forms.ToolStripButton tsbTargetCanselAdd;
        private System.Windows.Forms.ToolStripButton tsbTargetDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTargetName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTargetStepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStepDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnStepFlag;
        private System.Windows.Forms.SplitContainer splitContainerShop;
        private System.Windows.Forms.ToolStrip tsShoppingList;
        private System.Windows.Forms.TreeView tvShoppingList;
        private System.Windows.Forms.ImageList imageListShopping;
        private System.Windows.Forms.GroupBox gbShoppingFlag;
        private System.Windows.Forms.CheckBox checkShoppingFlag;
        private System.Windows.Forms.GroupBox gbShoppingCost;
        private System.Windows.Forms.TextBox tbShoppingCost;
        private System.Windows.Forms.GroupBox gbShoppingDescription;
        private System.Windows.Forms.RichTextBox rtbShoppingDescription;
        private System.Windows.Forms.ToolStripButton tsbShopAdd;
        private System.Windows.Forms.ToolStripLabel tslShopAdd;
        private System.Windows.Forms.ToolStripTextBox tstbShopAdd;
        private System.Windows.Forms.ToolStripButton tsbShopCanselAdd;
        private System.Windows.Forms.ToolStripButton tsbShopDelete;
        private System.Windows.Forms.SplitContainer splitContainerProject;
        private System.Windows.Forms.ToolStrip tsProjectList;
        private System.Windows.Forms.ToolStripButton tsbProjectAdd;
        private System.Windows.Forms.ToolStripLabel tslProjectAdd;
        private System.Windows.Forms.ToolStripTextBox tstbProjectName;
        private System.Windows.Forms.ToolStripButton tsbProjectCanselAdd;
        private System.Windows.Forms.ToolStripButton tsbProjectDelete;
        private System.Windows.Forms.DataGridView dgvProgectsList;
        private System.Windows.Forms.GroupBox gbProjectSteps;
        private System.Windows.Forms.DataGridView dgvProgectSteps;
        private System.Windows.Forms.ToolStrip tsProjectStep;
        private System.Windows.Forms.GroupBox gbProgectDescription;
        private System.Windows.Forms.RichTextBox rtbProjectDescription;
        private System.Windows.Forms.GroupBox gbProgectDate;
        private System.Windows.Forms.DateTimePicker dtpProjectDate;
        private System.Windows.Forms.ToolStripButton tsbProjectStepAdd;
        private System.Windows.Forms.ToolStripButton tsbProjectStepDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProjectStepNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProjectStepName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProjectStepDescription;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnProjectStepFlag;
    }
}