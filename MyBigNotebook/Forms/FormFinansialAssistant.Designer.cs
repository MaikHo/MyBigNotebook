namespace MyBigNotebook.Forms
{
    partial class FormFinansialAssistant
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinansialAssistant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageExpensess = new System.Windows.Forms.TabPage();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeriodic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripExpenses = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddExpenses = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelExpenses = new System.Windows.Forms.ToolStripButton();
            this.tabPageProfits = new System.Windows.Forms.TabPage();
            this.dgvProfits = new System.Windows.Forms.DataGridView();
            this.ColumnProfitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfitCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfitSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfitCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfitSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProfitPeriodic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripProfits = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddProfits = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonProfitsDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPageCashSaving = new System.Windows.Forms.TabPage();
            this.dgvCashSaving = new System.Windows.Forms.DataGridView();
            this.ColumnCashDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCashSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCashCyrrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCashSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripCash = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCashAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCashDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPageDebts = new System.Windows.Forms.TabPage();
            this.dgvDebts = new System.Windows.Forms.DataGridView();
            this.ColumnDebtCreditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtsDebtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtCurrency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDebtReturned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripDebt = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDebtAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDebtDel = new System.Windows.Forms.ToolStripButton();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.ColumnReportInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReportSumm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelReportMenu = new System.Windows.Forms.Panel();
            this.buttonReportExpepses = new System.Windows.Forms.Button();
            this.buttonReportProfit = new System.Windows.Forms.Button();
            this.buttonReportAll = new System.Windows.Forms.Button();
            this.dateTimePickerReportPo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerReportS = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageExpensess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.toolStripExpenses.SuspendLayout();
            this.tabPageProfits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).BeginInit();
            this.toolStripProfits.SuspendLayout();
            this.tabPageCashSaving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashSaving)).BeginInit();
            this.toolStripCash.SuspendLayout();
            this.tabPageDebts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).BeginInit();
            this.toolStripDebt.SuspendLayout();
            this.tabPageReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panelReportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageExpensess);
            this.tabControlMain.Controls.Add(this.tabPageProfits);
            this.tabControlMain.Controls.Add(this.tabPageCashSaving);
            this.tabControlMain.Controls.Add(this.tabPageDebts);
            this.tabControlMain.Controls.Add(this.tabPageReports);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(800, 450);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageExpensess
            // 
            this.tabPageExpensess.Controls.Add(this.dgvExpenses);
            this.tabPageExpensess.Controls.Add(this.toolStripExpenses);
            this.tabPageExpensess.Location = new System.Drawing.Point(4, 22);
            this.tabPageExpensess.Name = "tabPageExpensess";
            this.tabPageExpensess.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpensess.Size = new System.Drawing.Size(792, 424);
            this.tabPageExpensess.TabIndex = 0;
            this.tabPageExpensess.Text = "Траты";
            this.tabPageExpensess.UseVisualStyleBackColor = true;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToResizeColumns = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDate,
            this.ColumnCategory,
            this.ColumnName,
            this.ColumnSymm,
            this.ColumnCoin,
            this.ColumnPeriodic});
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenses.Location = new System.Drawing.Point(3, 28);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.Size = new System.Drawing.Size(786, 393);
            this.dgvExpenses.TabIndex = 1;
            this.dgvExpenses.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellEndEdit);
            // 
            // ColumnDate
            // 
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.ColumnDate.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnDate.HeaderText = "Дата";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.HeaderText = "Категория";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnSymm
            // 
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.ColumnSymm.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnSymm.HeaderText = "Сумма";
            this.ColumnSymm.Name = "ColumnSymm";
            // 
            // ColumnCoin
            // 
            this.ColumnCoin.HeaderText = "Валюта";
            this.ColumnCoin.Name = "ColumnCoin";
            // 
            // ColumnPeriodic
            // 
            this.ColumnPeriodic.HeaderText = "Периодичность";
            this.ColumnPeriodic.Name = "ColumnPeriodic";
            // 
            // toolStripExpenses
            // 
            this.toolStripExpenses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddExpenses,
            this.toolStripButtonDelExpenses});
            this.toolStripExpenses.Location = new System.Drawing.Point(3, 3);
            this.toolStripExpenses.Name = "toolStripExpenses";
            this.toolStripExpenses.Size = new System.Drawing.Size(786, 25);
            this.toolStripExpenses.TabIndex = 0;
            this.toolStripExpenses.Text = "toolStrip1";
            // 
            // toolStripButtonAddExpenses
            // 
            this.toolStripButtonAddExpenses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddExpenses.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddExpenses.Image")));
            this.toolStripButtonAddExpenses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddExpenses.Name = "toolStripButtonAddExpenses";
            this.toolStripButtonAddExpenses.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddExpenses.Text = "Добавить запись";
            this.toolStripButtonAddExpenses.Click += new System.EventHandler(this.toolStripButtonAddExpenses_Click);
            // 
            // toolStripButtonDelExpenses
            // 
            this.toolStripButtonDelExpenses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelExpenses.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelExpenses.Image")));
            this.toolStripButtonDelExpenses.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelExpenses.Name = "toolStripButtonDelExpenses";
            this.toolStripButtonDelExpenses.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDelExpenses.Text = "Удалить запись";
            this.toolStripButtonDelExpenses.Click += new System.EventHandler(this.toolStripButtonDelExpenses_Click);
            // 
            // tabPageProfits
            // 
            this.tabPageProfits.Controls.Add(this.dgvProfits);
            this.tabPageProfits.Controls.Add(this.toolStripProfits);
            this.tabPageProfits.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfits.Name = "tabPageProfits";
            this.tabPageProfits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfits.Size = new System.Drawing.Size(792, 424);
            this.tabPageProfits.TabIndex = 1;
            this.tabPageProfits.Text = "Доходы";
            this.tabPageProfits.UseVisualStyleBackColor = true;
            // 
            // dgvProfits
            // 
            this.dgvProfits.AllowUserToAddRows = false;
            this.dgvProfits.AllowUserToDeleteRows = false;
            this.dgvProfits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProfitDate,
            this.ColumnProfitCategory,
            this.ColumnProfitName,
            this.ColumnProfitSumm,
            this.ColumnProfitCurrency,
            this.ColumnProfitSource,
            this.ColumnProfitPeriodic});
            this.dgvProfits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfits.Location = new System.Drawing.Point(3, 28);
            this.dgvProfits.Name = "dgvProfits";
            this.dgvProfits.Size = new System.Drawing.Size(786, 393);
            this.dgvProfits.TabIndex = 1;
            this.dgvProfits.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfits_CellEndEdit);
            // 
            // ColumnProfitDate
            // 
            this.ColumnProfitDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnProfitDate.HeaderText = "Дата";
            this.ColumnProfitDate.Name = "ColumnProfitDate";
            this.ColumnProfitDate.ReadOnly = true;
            this.ColumnProfitDate.Width = 58;
            // 
            // ColumnProfitCategory
            // 
            this.ColumnProfitCategory.HeaderText = "Категория";
            this.ColumnProfitCategory.Name = "ColumnProfitCategory";
            this.ColumnProfitCategory.ReadOnly = true;
            // 
            // ColumnProfitName
            // 
            this.ColumnProfitName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnProfitName.HeaderText = "Имя";
            this.ColumnProfitName.MinimumWidth = 50;
            this.ColumnProfitName.Name = "ColumnProfitName";
            this.ColumnProfitName.ReadOnly = true;
            // 
            // ColumnProfitSumm
            // 
            this.ColumnProfitSumm.HeaderText = "Сумма";
            this.ColumnProfitSumm.Name = "ColumnProfitSumm";
            // 
            // ColumnProfitCurrency
            // 
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.ColumnProfitCurrency.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnProfitCurrency.HeaderText = "Валюта";
            this.ColumnProfitCurrency.Name = "ColumnProfitCurrency";
            // 
            // ColumnProfitSource
            // 
            this.ColumnProfitSource.HeaderText = "Источник";
            this.ColumnProfitSource.Name = "ColumnProfitSource";
            this.ColumnProfitSource.ReadOnly = true;
            // 
            // ColumnProfitPeriodic
            // 
            this.ColumnProfitPeriodic.HeaderText = "Периодичность";
            this.ColumnProfitPeriodic.Name = "ColumnProfitPeriodic";
            // 
            // toolStripProfits
            // 
            this.toolStripProfits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddProfits,
            this.toolStripButtonProfitsDelete});
            this.toolStripProfits.Location = new System.Drawing.Point(3, 3);
            this.toolStripProfits.Name = "toolStripProfits";
            this.toolStripProfits.Size = new System.Drawing.Size(786, 25);
            this.toolStripProfits.TabIndex = 0;
            this.toolStripProfits.Text = "toolStrip2";
            // 
            // toolStripButtonAddProfits
            // 
            this.toolStripButtonAddProfits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddProfits.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddProfits.Image")));
            this.toolStripButtonAddProfits.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddProfits.Name = "toolStripButtonAddProfits";
            this.toolStripButtonAddProfits.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAddProfits.Text = "Добавить";
            this.toolStripButtonAddProfits.Click += new System.EventHandler(this.toolStripButtonAddProfits_Click);
            // 
            // toolStripButtonProfitsDelete
            // 
            this.toolStripButtonProfitsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonProfitsDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonProfitsDelete.Image")));
            this.toolStripButtonProfitsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonProfitsDelete.Name = "toolStripButtonProfitsDelete";
            this.toolStripButtonProfitsDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonProfitsDelete.Text = "Удалить";
            this.toolStripButtonProfitsDelete.Click += new System.EventHandler(this.toolStripButtonProfitsDelete_Click);
            // 
            // tabPageCashSaving
            // 
            this.tabPageCashSaving.Controls.Add(this.dgvCashSaving);
            this.tabPageCashSaving.Controls.Add(this.toolStripCash);
            this.tabPageCashSaving.Location = new System.Drawing.Point(4, 22);
            this.tabPageCashSaving.Name = "tabPageCashSaving";
            this.tabPageCashSaving.Size = new System.Drawing.Size(792, 424);
            this.tabPageCashSaving.TabIndex = 2;
            this.tabPageCashSaving.Text = "Накопления";
            this.tabPageCashSaving.UseVisualStyleBackColor = true;
            // 
            // dgvCashSaving
            // 
            this.dgvCashSaving.AllowUserToAddRows = false;
            this.dgvCashSaving.AllowUserToDeleteRows = false;
            this.dgvCashSaving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCashSaving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCashDate,
            this.ColumnCashSumm,
            this.ColumnCashCyrrency,
            this.ColumnCashSource});
            this.dgvCashSaving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCashSaving.Location = new System.Drawing.Point(0, 25);
            this.dgvCashSaving.Name = "dgvCashSaving";
            this.dgvCashSaving.Size = new System.Drawing.Size(792, 399);
            this.dgvCashSaving.TabIndex = 1;
            this.dgvCashSaving.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCashSaving_CellEndEdit);
            // 
            // ColumnCashDate
            // 
            this.ColumnCashDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnCashDate.HeaderText = "Дата";
            this.ColumnCashDate.Name = "ColumnCashDate";
            this.ColumnCashDate.ReadOnly = true;
            this.ColumnCashDate.Width = 58;
            // 
            // ColumnCashSumm
            // 
            this.ColumnCashSumm.HeaderText = "Сумма";
            this.ColumnCashSumm.Name = "ColumnCashSumm";
            // 
            // ColumnCashCyrrency
            // 
            this.ColumnCashCyrrency.HeaderText = "Валюта";
            this.ColumnCashCyrrency.Name = "ColumnCashCyrrency";
            // 
            // ColumnCashSource
            // 
            this.ColumnCashSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCashSource.HeaderText = "Место хранения";
            this.ColumnCashSource.MinimumWidth = 90;
            this.ColumnCashSource.Name = "ColumnCashSource";
            // 
            // toolStripCash
            // 
            this.toolStripCash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCashAdd,
            this.toolStripButtonCashDelete});
            this.toolStripCash.Location = new System.Drawing.Point(0, 0);
            this.toolStripCash.Name = "toolStripCash";
            this.toolStripCash.Size = new System.Drawing.Size(792, 25);
            this.toolStripCash.TabIndex = 0;
            this.toolStripCash.Text = "toolStrip1";
            // 
            // toolStripButtonCashAdd
            // 
            this.toolStripButtonCashAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCashAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCashAdd.Image")));
            this.toolStripButtonCashAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCashAdd.Name = "toolStripButtonCashAdd";
            this.toolStripButtonCashAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCashAdd.Text = "Добавить";
            this.toolStripButtonCashAdd.Click += new System.EventHandler(this.toolStripButtonCashAdd_Click);
            // 
            // toolStripButtonCashDelete
            // 
            this.toolStripButtonCashDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCashDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCashDelete.Image")));
            this.toolStripButtonCashDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCashDelete.Name = "toolStripButtonCashDelete";
            this.toolStripButtonCashDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCashDelete.Text = "Удалить";
            this.toolStripButtonCashDelete.Click += new System.EventHandler(this.toolStripButtonCashDelete_Click);
            // 
            // tabPageDebts
            // 
            this.tabPageDebts.Controls.Add(this.dgvDebts);
            this.tabPageDebts.Controls.Add(this.toolStripDebt);
            this.tabPageDebts.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebts.Name = "tabPageDebts";
            this.tabPageDebts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebts.Size = new System.Drawing.Size(792, 424);
            this.tabPageDebts.TabIndex = 4;
            this.tabPageDebts.Text = "Долги";
            this.tabPageDebts.UseVisualStyleBackColor = true;
            // 
            // dgvDebts
            // 
            this.dgvDebts.AllowUserToAddRows = false;
            this.dgvDebts.AllowUserToDeleteRows = false;
            this.dgvDebts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDebtCreditor,
            this.ColumnDebtsDebtor,
            this.ColumnDebtSumm,
            this.ColumnDebtCurrency,
            this.ColumnDebtIssueDate,
            this.ColumnDebtReturnDate,
            this.ColumnDebtReturned});
            this.dgvDebts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebts.Location = new System.Drawing.Point(3, 28);
            this.dgvDebts.Name = "dgvDebts";
            this.dgvDebts.Size = new System.Drawing.Size(786, 393);
            this.dgvDebts.TabIndex = 1;
            this.dgvDebts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebts_CellEndEdit);
            // 
            // ColumnDebtCreditor
            // 
            this.ColumnDebtCreditor.HeaderText = "Кто должен";
            this.ColumnDebtCreditor.Name = "ColumnDebtCreditor";
            this.ColumnDebtCreditor.ReadOnly = true;
            // 
            // ColumnDebtsDebtor
            // 
            this.ColumnDebtsDebtor.HeaderText = "Кому должен";
            this.ColumnDebtsDebtor.Name = "ColumnDebtsDebtor";
            this.ColumnDebtsDebtor.ReadOnly = true;
            // 
            // ColumnDebtSumm
            // 
            this.ColumnDebtSumm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.ColumnDebtSumm.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnDebtSumm.HeaderText = "Сумма";
            this.ColumnDebtSumm.MinimumWidth = 50;
            this.ColumnDebtSumm.Name = "ColumnDebtSumm";
            // 
            // ColumnDebtCurrency
            // 
            this.ColumnDebtCurrency.HeaderText = "Валюта";
            this.ColumnDebtCurrency.Name = "ColumnDebtCurrency";
            // 
            // ColumnDebtIssueDate
            // 
            dataGridViewCellStyle12.Format = "G";
            dataGridViewCellStyle12.NullValue = null;
            this.ColumnDebtIssueDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnDebtIssueDate.HeaderText = "Дата выдачи";
            this.ColumnDebtIssueDate.Name = "ColumnDebtIssueDate";
            this.ColumnDebtIssueDate.ReadOnly = true;
            // 
            // ColumnDebtReturnDate
            // 
            dataGridViewCellStyle13.Format = "G";
            dataGridViewCellStyle13.NullValue = null;
            this.ColumnDebtReturnDate.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnDebtReturnDate.HeaderText = "Дата возврата";
            this.ColumnDebtReturnDate.Name = "ColumnDebtReturnDate";
            // 
            // ColumnDebtReturned
            // 
            this.ColumnDebtReturned.HeaderText = "Отдан ли";
            this.ColumnDebtReturned.Name = "ColumnDebtReturned";
            // 
            // toolStripDebt
            // 
            this.toolStripDebt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDebtAdd,
            this.toolStripButtonDebtDel});
            this.toolStripDebt.Location = new System.Drawing.Point(3, 3);
            this.toolStripDebt.Name = "toolStripDebt";
            this.toolStripDebt.Size = new System.Drawing.Size(786, 25);
            this.toolStripDebt.TabIndex = 0;
            this.toolStripDebt.Text = "toolStrip2";
            // 
            // toolStripButtonDebtAdd
            // 
            this.toolStripButtonDebtAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDebtAdd.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDebtAdd.Image")));
            this.toolStripButtonDebtAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDebtAdd.Name = "toolStripButtonDebtAdd";
            this.toolStripButtonDebtAdd.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDebtAdd.Text = "Добавить";
            this.toolStripButtonDebtAdd.Click += new System.EventHandler(this.toolStripButtonDebtAdd_Click);
            // 
            // toolStripButtonDebtDel
            // 
            this.toolStripButtonDebtDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDebtDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDebtDel.Image")));
            this.toolStripButtonDebtDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDebtDel.Name = "toolStripButtonDebtDel";
            this.toolStripButtonDebtDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDebtDel.Text = "Удалить запись";
            this.toolStripButtonDebtDel.Click += new System.EventHandler(this.toolStripButtonDebtDel_Click);
            // 
            // tabPageReports
            // 
            this.tabPageReports.Controls.Add(this.dgvReport);
            this.tabPageReports.Controls.Add(this.panelReportMenu);
            this.tabPageReports.Location = new System.Drawing.Point(4, 22);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Size = new System.Drawing.Size(792, 424);
            this.tabPageReports.TabIndex = 3;
            this.tabPageReports.Text = "Отчет";
            this.tabPageReports.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnReportInfo,
            this.ColumnReportSumm});
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 37);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(792, 387);
            this.dgvReport.TabIndex = 1;
            // 
            // ColumnReportInfo
            // 
            this.ColumnReportInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnReportInfo.HeaderText = "Инфо";
            this.ColumnReportInfo.MinimumWidth = 100;
            this.ColumnReportInfo.Name = "ColumnReportInfo";
            this.ColumnReportInfo.ReadOnly = true;
            // 
            // ColumnReportSumm
            // 
            this.ColumnReportSumm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.ColumnReportSumm.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnReportSumm.HeaderText = "Сумма";
            this.ColumnReportSumm.MinimumWidth = 100;
            this.ColumnReportSumm.Name = "ColumnReportSumm";
            this.ColumnReportSumm.ReadOnly = true;
            // 
            // panelReportMenu
            // 
            this.panelReportMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReportMenu.Controls.Add(this.buttonReportExpepses);
            this.panelReportMenu.Controls.Add(this.buttonReportProfit);
            this.panelReportMenu.Controls.Add(this.buttonReportAll);
            this.panelReportMenu.Controls.Add(this.dateTimePickerReportPo);
            this.panelReportMenu.Controls.Add(this.label2);
            this.panelReportMenu.Controls.Add(this.dateTimePickerReportS);
            this.panelReportMenu.Controls.Add(this.label1);
            this.panelReportMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportMenu.Location = new System.Drawing.Point(0, 0);
            this.panelReportMenu.Name = "panelReportMenu";
            this.panelReportMenu.Size = new System.Drawing.Size(792, 37);
            this.panelReportMenu.TabIndex = 0;
            // 
            // buttonReportExpepses
            // 
            this.buttonReportExpepses.Location = new System.Drawing.Point(553, 5);
            this.buttonReportExpepses.Name = "buttonReportExpepses";
            this.buttonReportExpepses.Size = new System.Drawing.Size(75, 23);
            this.buttonReportExpepses.TabIndex = 6;
            this.buttonReportExpepses.Text = "Расходы";
            this.buttonReportExpepses.UseVisualStyleBackColor = true;
            this.buttonReportExpepses.Click += new System.EventHandler(this.buttonReportExpepses_Click);
            // 
            // buttonReportProfit
            // 
            this.buttonReportProfit.Location = new System.Drawing.Point(472, 5);
            this.buttonReportProfit.Name = "buttonReportProfit";
            this.buttonReportProfit.Size = new System.Drawing.Size(75, 23);
            this.buttonReportProfit.TabIndex = 5;
            this.buttonReportProfit.Text = "Доходы";
            this.buttonReportProfit.UseVisualStyleBackColor = true;
            this.buttonReportProfit.Click += new System.EventHandler(this.buttonReportProfit_Click);
            // 
            // buttonReportAll
            // 
            this.buttonReportAll.Location = new System.Drawing.Point(391, 5);
            this.buttonReportAll.Name = "buttonReportAll";
            this.buttonReportAll.Size = new System.Drawing.Size(75, 23);
            this.buttonReportAll.TabIndex = 4;
            this.buttonReportAll.Text = "Общий";
            this.buttonReportAll.UseVisualStyleBackColor = true;
            this.buttonReportAll.Click += new System.EventHandler(this.buttonReportAll_Click);
            // 
            // dateTimePickerReportPo
            // 
            this.dateTimePickerReportPo.Location = new System.Drawing.Point(238, 6);
            this.dateTimePickerReportPo.Name = "dateTimePickerReportPo";
            this.dateTimePickerReportPo.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerReportPo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "по";
            // 
            // dateTimePickerReportS
            // 
            this.dateTimePickerReportS.Location = new System.Drawing.Point(67, 6);
            this.dateTimePickerReportS.Name = "dateTimePickerReportS";
            this.dateTimePickerReportS.Size = new System.Drawing.Size(140, 20);
            this.dateTimePickerReportS.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Период с";
            // 
            // FormFinansialAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormFinansialAssistant";
            this.Text = "FormFinansialAssistant";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageExpensess.ResumeLayout(false);
            this.tabPageExpensess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.toolStripExpenses.ResumeLayout(false);
            this.toolStripExpenses.PerformLayout();
            this.tabPageProfits.ResumeLayout(false);
            this.tabPageProfits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfits)).EndInit();
            this.toolStripProfits.ResumeLayout(false);
            this.toolStripProfits.PerformLayout();
            this.tabPageCashSaving.ResumeLayout(false);
            this.tabPageCashSaving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCashSaving)).EndInit();
            this.toolStripCash.ResumeLayout(false);
            this.toolStripCash.PerformLayout();
            this.tabPageDebts.ResumeLayout(false);
            this.tabPageDebts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebts)).EndInit();
            this.toolStripDebt.ResumeLayout(false);
            this.toolStripDebt.PerformLayout();
            this.tabPageReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panelReportMenu.ResumeLayout(false);
            this.panelReportMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageExpensess;
        private System.Windows.Forms.TabPage tabPageProfits;
        private System.Windows.Forms.TabPage tabPageCashSaving;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.ToolStrip toolStripExpenses;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCoin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPeriodic;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelExpenses;
        private System.Windows.Forms.ToolStrip toolStripProfits;
        private System.Windows.Forms.DataGridView dgvProfits;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddProfits;
        private System.Windows.Forms.ToolStripButton toolStripButtonProfitsDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfitCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfitSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfitCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProfitSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnProfitPeriodic;
        private System.Windows.Forms.ToolStrip toolStripCash;
        private System.Windows.Forms.TabPage tabPageDebts;
        private System.Windows.Forms.DataGridView dgvCashSaving;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCashDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCashSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCashCyrrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCashSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonCashAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonCashDelete;
        private System.Windows.Forms.ToolStrip toolStripDebt;
        private System.Windows.Forms.DataGridView dgvDebts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebtCreditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebtsDebtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebtSumm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebtCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebtIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDebtReturnDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDebtReturned;
        private System.Windows.Forms.ToolStripButton toolStripButtonDebtAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonDebtDel;
        private System.Windows.Forms.Panel panelReportMenu;
        private System.Windows.Forms.Button buttonReportExpepses;
        private System.Windows.Forms.Button buttonReportProfit;
        private System.Windows.Forms.Button buttonReportAll;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportPo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReportS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReportInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReportSumm;
    }
}