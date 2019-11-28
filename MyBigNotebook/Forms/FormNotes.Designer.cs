namespace MyBigNotebook.Forms
{
    partial class FormNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            this.tabControlNotes = new System.Windows.Forms.TabControl();
            this.tabPagePassword = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPass = new System.Windows.Forms.DataGridView();
            this.ColumnPassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPassLogin = new System.Windows.Forms.GroupBox();
            this.TbPassLogin = new System.Windows.Forms.TextBox();
            this.gbPassLink = new System.Windows.Forms.GroupBox();
            this.tbPassLink = new System.Windows.Forms.TextBox();
            this.gbPassPass = new System.Windows.Forms.GroupBox();
            this.tbPassPass = new System.Windows.Forms.TextBox();
            this.toolStripPass = new System.Windows.Forms.ToolStrip();
            this.tsbPassAdd = new System.Windows.Forms.ToolStripButton();
            this.tslPassAdd = new System.Windows.Forms.ToolStripLabel();
            this.tstbPassName = new System.Windows.Forms.ToolStripTextBox();
            this.tsbPassCanselAdd = new System.Windows.Forms.ToolStripButton();
            this.tssPass = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPassDel = new System.Windows.Forms.ToolStripButton();
            this.tabPageIdeas = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvIdea = new System.Windows.Forms.DataGridView();
            this.ColumnIdeaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbIdeaText = new System.Windows.Forms.GroupBox();
            this.rtbIdeaRext = new System.Windows.Forms.RichTextBox();
            this.gbIdeaKeys = new System.Windows.Forms.GroupBox();
            this.tbIdeaKeys = new System.Windows.Forms.TextBox();
            this.toolStripIdea = new System.Windows.Forms.ToolStrip();
            this.tsbIdeaAdd = new System.Windows.Forms.ToolStripButton();
            this.tslIdeaAdd = new System.Windows.Forms.ToolStripLabel();
            this.tstbIdeaName = new System.Windows.Forms.ToolStripTextBox();
            this.tsbIdeaCanselAdd = new System.Windows.Forms.ToolStripButton();
            this.tssIdeaAdd = new System.Windows.Forms.ToolStripSeparator();
            this.tsbIdeaDelete = new System.Windows.Forms.ToolStripButton();
            this.tabPageRecords = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.toolStripRecords = new System.Windows.Forms.ToolStrip();
            this.tsbRecordAdd = new System.Windows.Forms.ToolStripButton();
            this.tslrecordAdd = new System.Windows.Forms.ToolStripLabel();
            this.tstbRecordName = new System.Windows.Forms.ToolStripTextBox();
            this.tsbRecordCanselAdd = new System.Windows.Forms.ToolStripButton();
            this.tssRecordSep = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRecordDelete = new System.Windows.Forms.ToolStripButton();
            this.ColumnRecordName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbRecordKeys = new System.Windows.Forms.GroupBox();
            this.gbRecordsText = new System.Windows.Forms.GroupBox();
            this.rtbRecordsText = new System.Windows.Forms.RichTextBox();
            this.tbRecordsKeys = new System.Windows.Forms.TextBox();
            this.tabControlNotes.SuspendLayout();
            this.tabPagePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPass)).BeginInit();
            this.gbPassLogin.SuspendLayout();
            this.gbPassLink.SuspendLayout();
            this.gbPassPass.SuspendLayout();
            this.toolStripPass.SuspendLayout();
            this.tabPageIdeas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdea)).BeginInit();
            this.gbIdeaText.SuspendLayout();
            this.gbIdeaKeys.SuspendLayout();
            this.toolStripIdea.SuspendLayout();
            this.tabPageRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.toolStripRecords.SuspendLayout();
            this.gbRecordKeys.SuspendLayout();
            this.gbRecordsText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlNotes
            // 
            this.tabControlNotes.Controls.Add(this.tabPagePassword);
            this.tabControlNotes.Controls.Add(this.tabPageIdeas);
            this.tabControlNotes.Controls.Add(this.tabPageRecords);
            this.tabControlNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNotes.Location = new System.Drawing.Point(0, 0);
            this.tabControlNotes.Name = "tabControlNotes";
            this.tabControlNotes.SelectedIndex = 0;
            this.tabControlNotes.Size = new System.Drawing.Size(691, 522);
            this.tabControlNotes.TabIndex = 0;
            // 
            // tabPagePassword
            // 
            this.tabPagePassword.Controls.Add(this.splitContainer1);
            this.tabPagePassword.Controls.Add(this.toolStripPass);
            this.tabPagePassword.Location = new System.Drawing.Point(4, 22);
            this.tabPagePassword.Name = "tabPagePassword";
            this.tabPagePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePassword.Size = new System.Drawing.Size(683, 496);
            this.tabPagePassword.TabIndex = 0;
            this.tabPagePassword.Text = "Пароли";
            this.tabPagePassword.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPass);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbPassLogin);
            this.splitContainer1.Panel2.Controls.Add(this.gbPassLink);
            this.splitContainer1.Panel2.Controls.Add(this.gbPassPass);
            this.splitContainer1.Size = new System.Drawing.Size(677, 465);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvPass
            // 
            this.dgvPass.AllowUserToAddRows = false;
            this.dgvPass.AllowUserToDeleteRows = false;
            this.dgvPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPassName});
            this.dgvPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPass.Location = new System.Drawing.Point(0, 0);
            this.dgvPass.MultiSelect = false;
            this.dgvPass.Name = "dgvPass";
            this.dgvPass.ReadOnly = true;
            this.dgvPass.RowHeadersVisible = false;
            this.dgvPass.Size = new System.Drawing.Size(224, 465);
            this.dgvPass.TabIndex = 0;
            this.dgvPass.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvPass_CellStateChanged);
            // 
            // ColumnPassName
            // 
            this.ColumnPassName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPassName.HeaderText = "Название";
            this.ColumnPassName.Name = "ColumnPassName";
            this.ColumnPassName.ReadOnly = true;
            // 
            // gbPassLogin
            // 
            this.gbPassLogin.Controls.Add(this.TbPassLogin);
            this.gbPassLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPassLogin.Location = new System.Drawing.Point(0, 96);
            this.gbPassLogin.Name = "gbPassLogin";
            this.gbPassLogin.Size = new System.Drawing.Size(449, 47);
            this.gbPassLogin.TabIndex = 0;
            this.gbPassLogin.TabStop = false;
            this.gbPassLogin.Text = "Логин";
            // 
            // TbPassLogin
            // 
            this.TbPassLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbPassLogin.Location = new System.Drawing.Point(3, 16);
            this.TbPassLogin.Name = "TbPassLogin";
            this.TbPassLogin.Size = new System.Drawing.Size(443, 20);
            this.TbPassLogin.TabIndex = 0;
            // 
            // gbPassLink
            // 
            this.gbPassLink.Controls.Add(this.tbPassLink);
            this.gbPassLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPassLink.Location = new System.Drawing.Point(0, 48);
            this.gbPassLink.Name = "gbPassLink";
            this.gbPassLink.Size = new System.Drawing.Size(449, 48);
            this.gbPassLink.TabIndex = 2;
            this.gbPassLink.TabStop = false;
            this.gbPassLink.Text = "Ссылка";
            // 
            // tbPassLink
            // 
            this.tbPassLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassLink.Location = new System.Drawing.Point(3, 16);
            this.tbPassLink.Name = "tbPassLink";
            this.tbPassLink.Size = new System.Drawing.Size(443, 20);
            this.tbPassLink.TabIndex = 0;
            // 
            // gbPassPass
            // 
            this.gbPassPass.Controls.Add(this.tbPassPass);
            this.gbPassPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPassPass.Location = new System.Drawing.Point(0, 0);
            this.gbPassPass.Name = "gbPassPass";
            this.gbPassPass.Size = new System.Drawing.Size(449, 48);
            this.gbPassPass.TabIndex = 1;
            this.gbPassPass.TabStop = false;
            this.gbPassPass.Text = "Пароль";
            // 
            // tbPassPass
            // 
            this.tbPassPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPassPass.Location = new System.Drawing.Point(3, 16);
            this.tbPassPass.Name = "tbPassPass";
            this.tbPassPass.Size = new System.Drawing.Size(443, 20);
            this.tbPassPass.TabIndex = 0;
            // 
            // toolStripPass
            // 
            this.toolStripPass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPassAdd,
            this.tslPassAdd,
            this.tstbPassName,
            this.tsbPassCanselAdd,
            this.tssPass,
            this.tsbPassDel});
            this.toolStripPass.Location = new System.Drawing.Point(3, 3);
            this.toolStripPass.Name = "toolStripPass";
            this.toolStripPass.Size = new System.Drawing.Size(677, 25);
            this.toolStripPass.TabIndex = 0;
            this.toolStripPass.Text = "toolStrip1";
            // 
            // tsbPassAdd
            // 
            this.tsbPassAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPassAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbPassAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPassAdd.Name = "tsbPassAdd";
            this.tsbPassAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbPassAdd.Text = "Добавить";
            this.tsbPassAdd.Click += new System.EventHandler(this.tspPassAdd_Click);
            // 
            // tslPassAdd
            // 
            this.tslPassAdd.Name = "tslPassAdd";
            this.tslPassAdd.Size = new System.Drawing.Size(103, 22);
            this.tslPassAdd.Text = "Введите название";
            this.tslPassAdd.Visible = false;
            // 
            // tstbPassName
            // 
            this.tstbPassName.Name = "tstbPassName";
            this.tstbPassName.Size = new System.Drawing.Size(100, 25);
            this.tstbPassName.ToolTipText = "Enter для добавления";
            this.tstbPassName.Visible = false;
            this.tstbPassName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbPassName_KeyDown);
            // 
            // tsbPassCanselAdd
            // 
            this.tsbPassCanselAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPassCanselAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_clear_black_36dp;
            this.tsbPassCanselAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPassCanselAdd.Name = "tsbPassCanselAdd";
            this.tsbPassCanselAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbPassCanselAdd.Text = "Отмена";
            this.tsbPassCanselAdd.Visible = false;
            this.tsbPassCanselAdd.Click += new System.EventHandler(this.tsbPassCanselAdd_Click);
            // 
            // tssPass
            // 
            this.tssPass.Name = "tssPass";
            this.tssPass.Size = new System.Drawing.Size(6, 25);
            this.tssPass.Visible = false;
            // 
            // tsbPassDel
            // 
            this.tsbPassDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPassDel.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbPassDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPassDel.Name = "tsbPassDel";
            this.tsbPassDel.Size = new System.Drawing.Size(23, 22);
            this.tsbPassDel.Text = "Удалить";
            this.tsbPassDel.Click += new System.EventHandler(this.tsbPassDel_Click);
            // 
            // tabPageIdeas
            // 
            this.tabPageIdeas.Controls.Add(this.splitContainer2);
            this.tabPageIdeas.Controls.Add(this.toolStripIdea);
            this.tabPageIdeas.Location = new System.Drawing.Point(4, 22);
            this.tabPageIdeas.Name = "tabPageIdeas";
            this.tabPageIdeas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIdeas.Size = new System.Drawing.Size(683, 496);
            this.tabPageIdeas.TabIndex = 1;
            this.tabPageIdeas.Text = "Идеи";
            this.tabPageIdeas.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 28);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvIdea);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gbIdeaText);
            this.splitContainer2.Panel2.Controls.Add(this.gbIdeaKeys);
            this.splitContainer2.Size = new System.Drawing.Size(677, 465);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 1;
            // 
            // dgvIdea
            // 
            this.dgvIdea.AllowUserToAddRows = false;
            this.dgvIdea.AllowUserToDeleteRows = false;
            this.dgvIdea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdeaName});
            this.dgvIdea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIdea.Location = new System.Drawing.Point(0, 0);
            this.dgvIdea.MultiSelect = false;
            this.dgvIdea.Name = "dgvIdea";
            this.dgvIdea.ReadOnly = true;
            this.dgvIdea.RowHeadersVisible = false;
            this.dgvIdea.Size = new System.Drawing.Size(225, 465);
            this.dgvIdea.TabIndex = 0;
            this.dgvIdea.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvIdea_CellStateChanged);
            // 
            // ColumnIdeaName
            // 
            this.ColumnIdeaName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnIdeaName.HeaderText = "Название";
            this.ColumnIdeaName.Name = "ColumnIdeaName";
            this.ColumnIdeaName.ReadOnly = true;
            // 
            // gbIdeaText
            // 
            this.gbIdeaText.Controls.Add(this.rtbIdeaRext);
            this.gbIdeaText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbIdeaText.Location = new System.Drawing.Point(0, 0);
            this.gbIdeaText.Name = "gbIdeaText";
            this.gbIdeaText.Size = new System.Drawing.Size(448, 365);
            this.gbIdeaText.TabIndex = 1;
            this.gbIdeaText.TabStop = false;
            this.gbIdeaText.Text = "Текст";
            // 
            // rtbIdeaRext
            // 
            this.rtbIdeaRext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbIdeaRext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbIdeaRext.Location = new System.Drawing.Point(3, 16);
            this.rtbIdeaRext.Name = "rtbIdeaRext";
            this.rtbIdeaRext.Size = new System.Drawing.Size(442, 346);
            this.rtbIdeaRext.TabIndex = 0;
            this.rtbIdeaRext.Text = "";
            // 
            // gbIdeaKeys
            // 
            this.gbIdeaKeys.Controls.Add(this.tbIdeaKeys);
            this.gbIdeaKeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbIdeaKeys.Location = new System.Drawing.Point(0, 365);
            this.gbIdeaKeys.Name = "gbIdeaKeys";
            this.gbIdeaKeys.Size = new System.Drawing.Size(448, 100);
            this.gbIdeaKeys.TabIndex = 0;
            this.gbIdeaKeys.TabStop = false;
            this.gbIdeaKeys.Text = "Ключевые слова";
            // 
            // tbIdeaKeys
            // 
            this.tbIdeaKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbIdeaKeys.Location = new System.Drawing.Point(3, 16);
            this.tbIdeaKeys.Multiline = true;
            this.tbIdeaKeys.Name = "tbIdeaKeys";
            this.tbIdeaKeys.Size = new System.Drawing.Size(442, 81);
            this.tbIdeaKeys.TabIndex = 0;
            // 
            // toolStripIdea
            // 
            this.toolStripIdea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbIdeaAdd,
            this.tslIdeaAdd,
            this.tstbIdeaName,
            this.tsbIdeaCanselAdd,
            this.tssIdeaAdd,
            this.tsbIdeaDelete});
            this.toolStripIdea.Location = new System.Drawing.Point(3, 3);
            this.toolStripIdea.Name = "toolStripIdea";
            this.toolStripIdea.Size = new System.Drawing.Size(677, 25);
            this.toolStripIdea.TabIndex = 0;
            this.toolStripIdea.Text = "toolStrip1";
            // 
            // tsbIdeaAdd
            // 
            this.tsbIdeaAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIdeaAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbIdeaAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIdeaAdd.Name = "tsbIdeaAdd";
            this.tsbIdeaAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbIdeaAdd.Text = "Добавить запись";
            this.tsbIdeaAdd.Click += new System.EventHandler(this.tsbIdeaAdd_Click);
            // 
            // tslIdeaAdd
            // 
            this.tslIdeaAdd.Name = "tslIdeaAdd";
            this.tslIdeaAdd.Size = new System.Drawing.Size(91, 22);
            this.tslIdeaAdd.Text = "Название идеи:";
            this.tslIdeaAdd.Visible = false;
            // 
            // tstbIdeaName
            // 
            this.tstbIdeaName.Name = "tstbIdeaName";
            this.tstbIdeaName.Size = new System.Drawing.Size(100, 25);
            this.tstbIdeaName.Visible = false;
            this.tstbIdeaName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbIdeaName_KeyDown);
            // 
            // tsbIdeaCanselAdd
            // 
            this.tsbIdeaCanselAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIdeaCanselAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_clear_black_36dp;
            this.tsbIdeaCanselAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIdeaCanselAdd.Name = "tsbIdeaCanselAdd";
            this.tsbIdeaCanselAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbIdeaCanselAdd.Text = "Отмена";
            this.tsbIdeaCanselAdd.Visible = false;
            this.tsbIdeaCanselAdd.Click += new System.EventHandler(this.tsbIdeaCanselAdd_Click);
            // 
            // tssIdeaAdd
            // 
            this.tssIdeaAdd.Name = "tssIdeaAdd";
            this.tssIdeaAdd.Size = new System.Drawing.Size(6, 25);
            this.tssIdeaAdd.Visible = false;
            // 
            // tsbIdeaDelete
            // 
            this.tsbIdeaDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbIdeaDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbIdeaDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbIdeaDelete.Name = "tsbIdeaDelete";
            this.tsbIdeaDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbIdeaDelete.Text = "Удалить";
            this.tsbIdeaDelete.Click += new System.EventHandler(this.tsbIdeaDelete_Click);
            // 
            // tabPageRecords
            // 
            this.tabPageRecords.Controls.Add(this.splitContainer3);
            this.tabPageRecords.Controls.Add(this.toolStripRecords);
            this.tabPageRecords.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecords.Name = "tabPageRecords";
            this.tabPageRecords.Size = new System.Drawing.Size(683, 496);
            this.tabPageRecords.TabIndex = 2;
            this.tabPageRecords.Text = "Записи";
            this.tabPageRecords.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 25);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgvRecord);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gbRecordsText);
            this.splitContainer3.Panel2.Controls.Add(this.gbRecordKeys);
            this.splitContainer3.Size = new System.Drawing.Size(683, 471);
            this.splitContainer3.SplitterDistance = 227;
            this.splitContainer3.TabIndex = 1;
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnRecordName});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvRecord.MultiSelect = false;
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.Size = new System.Drawing.Size(227, 471);
            this.dgvRecord.TabIndex = 0;
            this.dgvRecord.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgvRecord_CellStateChanged);
            // 
            // toolStripRecords
            // 
            this.toolStripRecords.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRecordAdd,
            this.tslrecordAdd,
            this.tstbRecordName,
            this.tsbRecordCanselAdd,
            this.tssRecordSep,
            this.tsbRecordDelete});
            this.toolStripRecords.Location = new System.Drawing.Point(0, 0);
            this.toolStripRecords.Name = "toolStripRecords";
            this.toolStripRecords.Size = new System.Drawing.Size(683, 25);
            this.toolStripRecords.TabIndex = 0;
            this.toolStripRecords.Text = "toolStrip1";
            // 
            // tsbRecordAdd
            // 
            this.tsbRecordAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecordAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_add_black_36dp;
            this.tsbRecordAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecordAdd.Name = "tsbRecordAdd";
            this.tsbRecordAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbRecordAdd.Text = "Добавить";
            this.tsbRecordAdd.Click += new System.EventHandler(this.tsbRecordAdd_Click);
            // 
            // tslrecordAdd
            // 
            this.tslrecordAdd.Name = "tslrecordAdd";
            this.tslrecordAdd.Size = new System.Drawing.Size(109, 22);
            this.tslrecordAdd.Text = "Название заметки:";
            this.tslrecordAdd.Visible = false;
            // 
            // tstbRecordName
            // 
            this.tstbRecordName.Name = "tstbRecordName";
            this.tstbRecordName.Size = new System.Drawing.Size(150, 25);
            this.tstbRecordName.Visible = false;
            this.tstbRecordName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbRecordName_KeyDown);
            // 
            // tsbRecordCanselAdd
            // 
            this.tsbRecordCanselAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecordCanselAdd.Image = global::MyBigNotebook.Properties.Resources.baseline_clear_black_36dp;
            this.tsbRecordCanselAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecordCanselAdd.Name = "tsbRecordCanselAdd";
            this.tsbRecordCanselAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbRecordCanselAdd.Text = "Отмена";
            this.tsbRecordCanselAdd.Visible = false;
            this.tsbRecordCanselAdd.Click += new System.EventHandler(this.tsbRecordCanselAdd_Click);
            // 
            // tssRecordSep
            // 
            this.tssRecordSep.Name = "tssRecordSep";
            this.tssRecordSep.Size = new System.Drawing.Size(6, 25);
            this.tssRecordSep.Visible = false;
            // 
            // tsbRecordDelete
            // 
            this.tsbRecordDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecordDelete.Image = global::MyBigNotebook.Properties.Resources.baseline_delete_black_36dp;
            this.tsbRecordDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecordDelete.Name = "tsbRecordDelete";
            this.tsbRecordDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbRecordDelete.Text = "Удалить";
            this.tsbRecordDelete.Click += new System.EventHandler(this.tsbRecordDelete_Click);
            // 
            // ColumnRecordName
            // 
            this.ColumnRecordName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnRecordName.HeaderText = "Название";
            this.ColumnRecordName.Name = "ColumnRecordName";
            this.ColumnRecordName.ReadOnly = true;
            // 
            // gbRecordKeys
            // 
            this.gbRecordKeys.Controls.Add(this.tbRecordsKeys);
            this.gbRecordKeys.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbRecordKeys.Location = new System.Drawing.Point(0, 371);
            this.gbRecordKeys.Name = "gbRecordKeys";
            this.gbRecordKeys.Size = new System.Drawing.Size(452, 100);
            this.gbRecordKeys.TabIndex = 0;
            this.gbRecordKeys.TabStop = false;
            this.gbRecordKeys.Text = "Ключевые слова";
            // 
            // gbRecordsText
            // 
            this.gbRecordsText.Controls.Add(this.rtbRecordsText);
            this.gbRecordsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbRecordsText.Location = new System.Drawing.Point(0, 0);
            this.gbRecordsText.Name = "gbRecordsText";
            this.gbRecordsText.Size = new System.Drawing.Size(452, 371);
            this.gbRecordsText.TabIndex = 1;
            this.gbRecordsText.TabStop = false;
            this.gbRecordsText.Text = "Текст";
            // 
            // rtbRecordsText
            // 
            this.rtbRecordsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbRecordsText.Location = new System.Drawing.Point(3, 16);
            this.rtbRecordsText.Name = "rtbRecordsText";
            this.rtbRecordsText.Size = new System.Drawing.Size(446, 352);
            this.rtbRecordsText.TabIndex = 0;
            this.rtbRecordsText.Text = "";
            // 
            // tbRecordsKeys
            // 
            this.tbRecordsKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRecordsKeys.Location = new System.Drawing.Point(3, 16);
            this.tbRecordsKeys.Multiline = true;
            this.tbRecordsKeys.Name = "tbRecordsKeys";
            this.tbRecordsKeys.Size = new System.Drawing.Size(446, 81);
            this.tbRecordsKeys.TabIndex = 0;
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 522);
            this.Controls.Add(this.tabControlNotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotes";
            this.Text = "Записи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNotes_FormClosing);
            this.tabControlNotes.ResumeLayout(false);
            this.tabPagePassword.ResumeLayout(false);
            this.tabPagePassword.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPass)).EndInit();
            this.gbPassLogin.ResumeLayout(false);
            this.gbPassLogin.PerformLayout();
            this.gbPassLink.ResumeLayout(false);
            this.gbPassLink.PerformLayout();
            this.gbPassPass.ResumeLayout(false);
            this.gbPassPass.PerformLayout();
            this.toolStripPass.ResumeLayout(false);
            this.toolStripPass.PerformLayout();
            this.tabPageIdeas.ResumeLayout(false);
            this.tabPageIdeas.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdea)).EndInit();
            this.gbIdeaText.ResumeLayout(false);
            this.gbIdeaKeys.ResumeLayout(false);
            this.gbIdeaKeys.PerformLayout();
            this.toolStripIdea.ResumeLayout(false);
            this.toolStripIdea.PerformLayout();
            this.tabPageRecords.ResumeLayout(false);
            this.tabPageRecords.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.toolStripRecords.ResumeLayout(false);
            this.toolStripRecords.PerformLayout();
            this.gbRecordKeys.ResumeLayout(false);
            this.gbRecordKeys.PerformLayout();
            this.gbRecordsText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlNotes;
        private System.Windows.Forms.TabPage tabPagePassword;
        private System.Windows.Forms.TabPage tabPageIdeas;
        private System.Windows.Forms.TabPage tabPageRecords;
        private System.Windows.Forms.ToolStrip toolStripPass;
        private System.Windows.Forms.ToolStrip toolStripIdea;
        private System.Windows.Forms.ToolStrip toolStripRecords;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvPass;
        private System.Windows.Forms.GroupBox gbPassLogin;
        private System.Windows.Forms.DataGridView dgvIdea;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.ToolStripButton tsbPassAdd;
        private System.Windows.Forms.ToolStripLabel tslPassAdd;
        private System.Windows.Forms.ToolStripTextBox tstbPassName;
        private System.Windows.Forms.ToolStripButton tsbPassCanselAdd;
        private System.Windows.Forms.ToolStripSeparator tssPass;
        private System.Windows.Forms.ToolStripButton tsbPassDel;
        private System.Windows.Forms.GroupBox gbPassLink;
        private System.Windows.Forms.TextBox tbPassLink;
        private System.Windows.Forms.GroupBox gbPassPass;
        private System.Windows.Forms.TextBox tbPassPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdeaName;
        private System.Windows.Forms.ToolStripButton tsbIdeaAdd;
        private System.Windows.Forms.ToolStripLabel tslIdeaAdd;
        private System.Windows.Forms.ToolStripTextBox tstbIdeaName;
        private System.Windows.Forms.ToolStripButton tsbIdeaCanselAdd;
        private System.Windows.Forms.ToolStripSeparator tssIdeaAdd;
        private System.Windows.Forms.ToolStripButton tsbIdeaDelete;
        private System.Windows.Forms.GroupBox gbIdeaText;
        private System.Windows.Forms.RichTextBox rtbIdeaRext;
        private System.Windows.Forms.GroupBox gbIdeaKeys;
        private System.Windows.Forms.TextBox tbIdeaKeys;        
        private System.Windows.Forms.TextBox TbPassLogin;
        private System.Windows.Forms.ToolStripButton tsbRecordAdd;
        private System.Windows.Forms.ToolStripLabel tslrecordAdd;
        private System.Windows.Forms.ToolStripTextBox tstbRecordName;
        private System.Windows.Forms.ToolStripButton tsbRecordCanselAdd;
        private System.Windows.Forms.ToolStripSeparator tssRecordSep;
        private System.Windows.Forms.ToolStripButton tsbRecordDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRecordName;
        private System.Windows.Forms.GroupBox gbRecordsText;
        private System.Windows.Forms.RichTextBox rtbRecordsText;
        private System.Windows.Forms.GroupBox gbRecordKeys;
        private System.Windows.Forms.TextBox tbRecordsKeys;
    }
}