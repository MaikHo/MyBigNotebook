using System;
using System.Windows.Forms;

namespace MyBigNotebook.Forms
{
    public partial class FormDiary : Form
    {
        private ClassDiary diary;
        public FormDiary(ClassDiary Diary)
        {
            InitializeComponent();
            diary = Diary;
            LoadDateToForm();
            
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = true;
        }

        private void buttonNoAdd_Click(object sender, EventArgs e)
        {
            panelAdd.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;
            foreach (DiaryRec diaryRec in diary.DiaryRecs)
                if (dateTimePickerDate.Value.Date == diaryRec.Date.Date)
                {
                    MessageBox.Show("Данная дата уже есть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flag = false;
                }

            if (flag)
            {
                DiaryRec rec = new DiaryRec();
                rec.Date = dateTimePickerDate.Value;
                rec.Text = "";
                diary.DiaryRecs.Add(rec);
                panelAdd.Visible = false;
                LoadDateToForm();
            }
        }

        private void LoadDateToForm()
        {
            dgvDate.Rows.Clear();
            foreach (DiaryRec rec in diary.DiaryRecs)
            {
                dgvDate.Rows.Add();
                dgvDate.Rows[dgvDate.Rows.Count - 1].Cells[0].Value = rec.Date.ToLongDateString();
            }
        }

        private void dgvDate_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    tbText.Visible = true;
                    if (e.Cell.Selected)
                    {
                        foreach (DiaryRec rec in diary.DiaryRecs)
                            if (rec.Date.ToLongDateString() == e.Cell.Value.ToString())
                                tbText.Text = rec.Text;
                    }
                    else
                    {
                        foreach (DiaryRec rec in diary.DiaryRecs)
                            if (rec.Date.ToLongDateString() == e.Cell.Value.ToString())
                                rec.Text = tbText.Text;
                    }
                }
            }
            catch { }
            
        }

        private void FormDiary_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvDate.SelectedCells)
                cell.Selected = false;
        }
    }
}
