using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBigNotebook.Forms
{
    public partial class FormFinansialAssistant : Form
    {
        private ClassFinansialAssistant finansialAssistant;
        public FormFinansialAssistant(ClassFinansialAssistant assistant)
        {
            InitializeComponent();
            finansialAssistant = assistant;            
            LoadExpensessToForm();
                     
        }

        private void LoadExpensessToForm()
        {
            dgvExpenses.Rows.Clear();
            foreach(Expenses expenses in finansialAssistant.Expensess)
            {
                dgvExpenses.Rows.Add();
                dgvExpenses.Rows[dgvExpenses.Rows.Count - 1].Cells[0].Value = expenses.Date.ToString();
                dgvExpenses.Rows[dgvExpenses.Rows.Count - 1].Cells[1].Value = expenses.Category;
                dgvExpenses.Rows[dgvExpenses.Rows.Count - 1].Cells[2].Value = expenses.Name;
                dgvExpenses.Rows[dgvExpenses.Rows.Count - 1].Cells[3].Value = expenses.Summ;
                dgvExpenses.Rows[dgvExpenses.Rows.Count - 1].Cells[4].Value = expenses.Currency;
                dgvExpenses.Rows[dgvExpenses.Rows.Count - 1].Cells[5].Value = expenses.IsPeriodic;
            }
        }

        private void toolStripButtonAddExpenses_Click(object sender, EventArgs e)
        {
            FormAddFinansial form = new FormAddFinansial("Expenses");
            if (form.ShowDialog()==DialogResult.OK)
            {
                if (form.expenses != null)
                {
                    finansialAssistant.Expensess.Add(form.expenses);
                    LoadExpensessToForm();
                }
            }
        }

        private void dgvExpenses_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Expenses expenses in finansialAssistant.Expensess)
            {

                if ( dgvExpenses.Rows[e.RowIndex].Cells[0].Value.ToString() == expenses.Date.ToString()
                    && dgvExpenses.Rows[e.RowIndex].Cells[1].Value.ToString() == expenses.Category
                    && dgvExpenses.Rows[e.RowIndex].Cells[2].Value.ToString() == expenses.Name  )
                        switch(e.ColumnIndex)
                    {
                        case 3:
                            expenses.Summ = Convert.ToDouble(dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                            break;
                        case 4:
                            expenses.Currency = dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            break;
                        case 5:
                            expenses.IsPeriodic = Convert.ToBoolean(dgvExpenses.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                            break;
                    }

            }
        }

        private void toolStripButtonDelExpenses_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить выбранную запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { DataGridViewCell cell = dgvExpenses.SelectedCells[0];
                foreach (Expenses expenses in finansialAssistant.Expensess)
                    if (dgvExpenses.Rows[cell.RowIndex].Cells[0].Value.ToString() == expenses.Date.ToString()
                    && dgvExpenses.Rows[cell.RowIndex].Cells[1].Value.ToString() == expenses.Category
                    && dgvExpenses.Rows[cell.RowIndex].Cells[2].Value.ToString() == expenses.Name)
                    {
                        finansialAssistant.Expensess.Remove(expenses);
                        LoadExpensessToForm();
                        break;
                    }
            }

        }
    }
}
