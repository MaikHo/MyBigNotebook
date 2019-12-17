using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MyBigNotebook.Classes;

namespace MyBigNotebook.Forms
{
    public partial class FormNotes : Form
    {
        private ClassNotes Notes;
        public FormNotes(ClassNotes notes)
        {
            InitializeComponent();
            Notes = notes;
            LoadPasswordsToForm();
            LoadIdeasToForm();
            LoadRecordsToForm();
            setIdeaVisible(false);
            setPassVisible(false);
            setRecordsVisible(false);
        }

        private void tspPassAdd_Click(object sender, EventArgs e)
        {
            tsbPassAdd.Visible = false;
            tsbPassCanselAdd.Visible = true;
            tslPassAdd.Visible = true;
            tssPass.Visible = true;
            tstbPassName.Visible = true;
        }

        private void tsbPassCanselAdd_Click(object sender, EventArgs e)
        {
            tsbPassAdd.Visible = true;
            tsbPassCanselAdd.Visible = false;
            tslPassAdd.Visible = false;
            tssPass.Visible = false;
            tstbPassName.Visible = false;
            tstbPassName.Text = "";
        }

        private void LoadPasswordsToForm()
        {
            dgvPass.Rows.Clear();
            foreach (Password password in Notes.passwords)
                dgvPass.Rows.Add(new object[] { password.Name });
        }

        private void tstbPassName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Notes.passwords.Add(new Password(tstbPassName.Text));
                LoadPasswordsToForm();
                tsbPassCanselAdd_Click(sender, new EventArgs());
            }
        }

        private void tsbPassDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Вы точно хотите удалить запись {dgvPass.SelectedCells[0].Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Password password = Notes.passwords.Where(t => t.Name == dgvPass.SelectedCells[0].Value.ToString()).First();
                    Notes.passwords.Remove(password);
                    LoadPasswordsToForm();
                }
            }
            catch { }
        }

        private void dgvPass_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs eventArg)
        {
            try
            {
                if (eventArg.StateChanged == DataGridViewElementStates.Selected)
                {
                    if (eventArg.Cell.Selected)
                    {
                        setPassVisible(true);
                        Password password = Notes.passwords.Where(t => t.Name == eventArg.Cell.Value.ToString()).First();
                        tbPassLink.Text = password.Link;
                        tbPassPass.Text = password.Pass;
                        TbPassLogin.Text = password.Login;
                    }
                    else
                    {
                        Password password = Notes.passwords.Where(t => t.Name == eventArg.Cell.Value.ToString()).First();
                        password.Pass = tbPassPass.Text;
                        password.Login = TbPassLogin.Text;
                        password.Link = tbPassLink.Text;
                    }
                }
            }
            catch { }
        }

        private void tsbIdeaAdd_Click(object sender, EventArgs e)
        {
            tsbIdeaAdd.Visible = false;
            tslIdeaAdd.Visible = true;
            tstbIdeaName.Visible = true;
            tsbIdeaCanselAdd.Visible = true;
            tssIdeaAdd.Visible = true;

        }

        private void tsbIdeaCanselAdd_Click(object sender, EventArgs e)
        {
            tsbIdeaAdd.Visible = true;
            tslIdeaAdd.Visible = false;
            tstbIdeaName.Visible = false;
            tsbIdeaCanselAdd.Visible = false;
            tssIdeaAdd.Visible = false;
            tstbIdeaName.Text = "";
        }

        private void LoadIdeasToForm()
        {
            dgvIdea.Rows.Clear();
            foreach (Idea idea in Notes.ideas)
                dgvIdea.Rows.Add(new object[] { idea.Name });
            

        }

        private void tstbIdeaName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Notes.ideas.Add(new Idea(tstbIdeaName.Text));
                LoadIdeasToForm();
                tsbIdeaCanselAdd_Click(sender, new EventArgs());
            }
        }

        private void tsbIdeaDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Вы точно хотите удалить запись {dgvIdea.SelectedCells[0].Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Idea idea = Notes.ideas.Where(t => t.Name == dgvIdea.SelectedCells[0].Value.ToString()).First();
                    Notes.ideas.Remove(idea);
                    LoadIdeasToForm();
                }
            }
            catch { }
        }

        private void dgvIdea_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs ev)
        {
            if(ev.StateChanged == DataGridViewElementStates.Selected)
            {
                try
                {
                    if (ev.Cell.Selected)
                    {
                        setIdeaVisible(true);
                        Idea idea = Notes.ideas.Where(t => t.Name == ev.Cell.Value.ToString()).First();
                        rtbIdeaRext.Text = idea.Text;
                        tbIdeaKeys.Text =ClassConvert.getKeyString(idea.keyWords);
                    }
                    else
                    {
                        Idea idea = Notes.ideas.Where(t => t.Name == ev.Cell.Value.ToString()).First();
                        idea.Text = rtbIdeaRext.Text;
                        idea.keyWords = ClassConvert.getKeysList(tbIdeaKeys.Text);
                    }
                }
                catch { }
            }
        }


        private void LoadRecordsToForm()
        {
            dgvRecord.Rows.Clear();
            foreach (Record record in Notes.records)
                dgvRecord.Rows.Add(new object[] { record.Name });
        }


        private void tsbRecordAdd_Click(object sender, EventArgs e)
        {
            tsbRecordAdd.Visible = false;
            tslrecordAdd.Visible = true;
            tstbRecordName.Visible = true;
            tssRecordSep.Visible = true;
            tsbRecordCanselAdd.Visible = true;
        }

        private void tsbRecordCanselAdd_Click(object sender, EventArgs e)
        {
            tsbRecordAdd.Visible = true;
            tslrecordAdd.Visible = false;
            tstbRecordName.Visible = false;
            tssRecordSep.Visible = false;
            tsbRecordCanselAdd.Visible = false;
        }

        private void tstbRecordName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Notes.records.Add(new Record(tstbRecordName.Text));
                tsbRecordCanselAdd_Click(sender, new EventArgs());
                LoadRecordsToForm();
            }
        }

        private void dgvRecord_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs ev)
        {
            try
            {
                if (ev.StateChanged == DataGridViewElementStates.Selected)
                {
                    Record record = Notes.records.Where(t => t.Name == ev.Cell.Value.ToString()).First();
                    if (ev.Cell.Selected)
                    {
                        setRecordsVisible(true);
                        tbRecordsKeys.Text = ClassConvert.getKeyString(record.keyWords);
                        rtbRecordsText.Text = record.Text;
                    }
                    else
                    {
                        record.Text = rtbRecordsText.Text;
                        record.keyWords = ClassConvert.getKeysList(tbRecordsKeys.Text);
                    }
                }
            }
            catch { }
        }

        private void FormNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvPass.SelectedCells)
                cell.Selected = false;
            foreach (DataGridViewCell cell in dgvIdea.SelectedCells)
                cell.Selected = false;
            foreach (DataGridViewCell cell in dgvRecord.SelectedCells)
                cell.Selected = false;
        }

        private void tsbRecordDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"Вы точно хотите удалить запись {dgvRecord.SelectedCells[0].Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Record record = Notes.records.Where(t => t.Name == dgvRecord.SelectedCells[0].Value.ToString()).First();
                    Notes.records.Remove(record);
                    LoadRecordsToForm();
                }
            }
            catch { }
        }

        private void setPassVisible(bool visibled)
        {
            gbPassLink.Visible = visibled;
            gbPassLogin.Visible = visibled;
            gbPassPass.Visible = visibled;
        }

        private void setIdeaVisible(bool visibled)
        {
            gbIdeaKeys.Visible = visibled;
            gbIdeaText.Visible = visibled;
        }

        private void setRecordsVisible(bool visibled)
        {
            gbRecordKeys.Visible = visibled;
            gbRecordsText.Visible = visibled;
        }
    }
}
