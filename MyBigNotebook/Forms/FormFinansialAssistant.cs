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
    }
}
