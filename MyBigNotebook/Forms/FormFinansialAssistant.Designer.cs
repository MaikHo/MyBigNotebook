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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinansialAssistant));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageExpensess = new System.Windows.Forms.TabPage();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeriodic = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddExpenses = new System.Windows.Forms.ToolStripButton();
            this.tabPageProfits = new System.Windows.Forms.TabPage();
            this.tabPageCashSaving = new System.Windows.Forms.TabPage();
            this.tabPageReports = new System.Windows.Forms.TabPage();
            this.toolStripButtonDelExpenses = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain.SuspendLayout();
            this.tabPageExpensess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageExpensess);
            this.tabControlMain.Controls.Add(this.tabPageProfits);
            this.tabControlMain.Controls.Add(this.tabPageCashSaving);
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
            this.tabPageExpensess.Controls.Add(this.toolStrip1);
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnDate.DefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.ColumnSymm.DefaultCellStyle = dataGridViewCellStyle2;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddExpenses,
            this.toolStripButtonDelExpenses});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // tabPageProfits
            // 
            this.tabPageProfits.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfits.Name = "tabPageProfits";
            this.tabPageProfits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfits.Size = new System.Drawing.Size(792, 424);
            this.tabPageProfits.TabIndex = 1;
            this.tabPageProfits.Text = "Доходы";
            this.tabPageProfits.UseVisualStyleBackColor = true;
            // 
            // tabPageCashSaving
            // 
            this.tabPageCashSaving.Location = new System.Drawing.Point(4, 22);
            this.tabPageCashSaving.Name = "tabPageCashSaving";
            this.tabPageCashSaving.Size = new System.Drawing.Size(792, 424);
            this.tabPageCashSaving.TabIndex = 2;
            this.tabPageCashSaving.Text = "Накопления";
            this.tabPageCashSaving.UseVisualStyleBackColor = true;
            // 
            // tabPageReports
            // 
            this.tabPageReports.Location = new System.Drawing.Point(4, 22);
            this.tabPageReports.Name = "tabPageReports";
            this.tabPageReports.Size = new System.Drawing.Size(792, 424);
            this.tabPageReports.TabIndex = 3;
            this.tabPageReports.Text = "Отчет";
            this.tabPageReports.UseVisualStyleBackColor = true;
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageExpensess;
        private System.Windows.Forms.TabPage tabPageProfits;
        private System.Windows.Forms.TabPage tabPageCashSaving;
        private System.Windows.Forms.TabPage tabPageReports;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSymm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCoin;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnPeriodic;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelExpenses;
    }
}