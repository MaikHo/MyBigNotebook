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
            this.tabPageIdeas = new System.Windows.Forms.TabPage();
            this.tabPageRecords = new System.Windows.Forms.TabPage();
            this.toolStripPass = new System.Windows.Forms.ToolStrip();
            this.toolStripIdea = new System.Windows.Forms.ToolStrip();
            this.toolStripRecords = new System.Windows.Forms.ToolStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.dgvPass = new System.Windows.Forms.DataGridView();
            this.dgvIdea = new System.Windows.Forms.DataGridView();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.tabControlNotes.SuspendLayout();
            this.tabPagePassword.SuspendLayout();
            this.tabPageIdeas.SuspendLayout();
            this.tabPageRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
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
            this.tabControlNotes.Size = new System.Drawing.Size(691, 525);
            this.tabControlNotes.TabIndex = 0;
            // 
            // tabPagePassword
            // 
            this.tabPagePassword.Controls.Add(this.splitContainer1);
            this.tabPagePassword.Controls.Add(this.toolStripPass);
            this.tabPagePassword.Location = new System.Drawing.Point(4, 22);
            this.tabPagePassword.Name = "tabPagePassword";
            this.tabPagePassword.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePassword.Size = new System.Drawing.Size(683, 499);
            this.tabPagePassword.TabIndex = 0;
            this.tabPagePassword.Text = "Пароли";
            this.tabPagePassword.UseVisualStyleBackColor = true;
            // 
            // tabPageIdeas
            // 
            this.tabPageIdeas.Controls.Add(this.splitContainer2);
            this.tabPageIdeas.Controls.Add(this.toolStripIdea);
            this.tabPageIdeas.Location = new System.Drawing.Point(4, 22);
            this.tabPageIdeas.Name = "tabPageIdeas";
            this.tabPageIdeas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIdeas.Size = new System.Drawing.Size(683, 499);
            this.tabPageIdeas.TabIndex = 1;
            this.tabPageIdeas.Text = "Идеи";
            this.tabPageIdeas.UseVisualStyleBackColor = true;
            // 
            // tabPageRecords
            // 
            this.tabPageRecords.Controls.Add(this.splitContainer3);
            this.tabPageRecords.Controls.Add(this.toolStripRecords);
            this.tabPageRecords.Location = new System.Drawing.Point(4, 22);
            this.tabPageRecords.Name = "tabPageRecords";
            this.tabPageRecords.Size = new System.Drawing.Size(683, 499);
            this.tabPageRecords.TabIndex = 2;
            this.tabPageRecords.Text = "Записи";
            this.tabPageRecords.UseVisualStyleBackColor = true;
            // 
            // toolStripPass
            // 
            this.toolStripPass.Location = new System.Drawing.Point(3, 3);
            this.toolStripPass.Name = "toolStripPass";
            this.toolStripPass.Size = new System.Drawing.Size(677, 25);
            this.toolStripPass.TabIndex = 0;
            this.toolStripPass.Text = "toolStrip1";
            // 
            // toolStripIdea
            // 
            this.toolStripIdea.Location = new System.Drawing.Point(3, 3);
            this.toolStripIdea.Name = "toolStripIdea";
            this.toolStripIdea.Size = new System.Drawing.Size(677, 25);
            this.toolStripIdea.TabIndex = 0;
            this.toolStripIdea.Text = "toolStrip1";
            // 
            // toolStripRecords
            // 
            this.toolStripRecords.Location = new System.Drawing.Point(0, 0);
            this.toolStripRecords.Name = "toolStripRecords";
            this.toolStripRecords.Size = new System.Drawing.Size(683, 25);
            this.toolStripRecords.TabIndex = 0;
            this.toolStripRecords.Text = "toolStrip1";
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
            this.splitContainer1.Size = new System.Drawing.Size(677, 468);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer2.Size = new System.Drawing.Size(677, 468);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 1;
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
            this.splitContainer3.Size = new System.Drawing.Size(683, 474);
            this.splitContainer3.SplitterDistance = 227;
            this.splitContainer3.TabIndex = 1;
            // 
            // dgvPass
            // 
            this.dgvPass.AllowUserToAddRows = false;
            this.dgvPass.AllowUserToDeleteRows = false;
            this.dgvPass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPass.Location = new System.Drawing.Point(0, 0);
            this.dgvPass.MultiSelect = false;
            this.dgvPass.Name = "dgvPass";
            this.dgvPass.ReadOnly = true;
            this.dgvPass.RowHeadersVisible = false;
            this.dgvPass.Size = new System.Drawing.Size(225, 468);
            this.dgvPass.TabIndex = 0;
            // 
            // dgvIdea
            // 
            this.dgvIdea.AllowUserToAddRows = false;
            this.dgvIdea.AllowUserToDeleteRows = false;
            this.dgvIdea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIdea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIdea.Location = new System.Drawing.Point(0, 0);
            this.dgvIdea.MultiSelect = false;
            this.dgvIdea.Name = "dgvIdea";
            this.dgvIdea.ReadOnly = true;
            this.dgvIdea.RowHeadersVisible = false;
            this.dgvIdea.Size = new System.Drawing.Size(225, 468);
            this.dgvIdea.TabIndex = 0;
            // 
            // dgvRecord
            // 
            this.dgvRecord.AllowUserToAddRows = false;
            this.dgvRecord.AllowUserToDeleteRows = false;
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.Location = new System.Drawing.Point(0, 0);
            this.dgvRecord.MultiSelect = false;
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.ReadOnly = true;
            this.dgvRecord.RowHeadersVisible = false;
            this.dgvRecord.Size = new System.Drawing.Size(227, 474);
            this.dgvRecord.TabIndex = 0;
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 525);
            this.Controls.Add(this.tabControlNotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNotes";
            this.Text = "Записи";
            this.tabControlNotes.ResumeLayout(false);
            this.tabPagePassword.ResumeLayout(false);
            this.tabPagePassword.PerformLayout();
            this.tabPageIdeas.ResumeLayout(false);
            this.tabPageIdeas.PerformLayout();
            this.tabPageRecords.ResumeLayout(false);
            this.tabPageRecords.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIdea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvIdea;
        private System.Windows.Forms.DataGridView dgvRecord;
    }
}