using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            LoadProfitToForm();
            LoadCashSavingToForm();
            LoadDebtsToForm();
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

        private void toolStripButtonAddProfits_Click(object sender, EventArgs e)
        {

            FormAddFinansial form = new FormAddFinansial("Profits");
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.profit != null)
                {
                    finansialAssistant.Profits.Add(form.profit);
                    LoadProfitToForm();
                }
            }
        }

        private void LoadProfitToForm()
        {
            dgvProfits.Rows.Clear();
            foreach(Profit profit in finansialAssistant.Profits)
            {
                dgvProfits.Rows.Add(new object[] { profit.Date, profit.Category, profit.Name, profit.Summ, profit.Currency, profit.Source, profit.IsPeriodic });               
            }
        }

        private void dgvProfits_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Profit profit in finansialAssistant.Profits)
            {

                if (dgvProfits.Rows[e.RowIndex].Cells[0].Value.ToString() == profit.Date.ToString()
                    && dgvProfits.Rows[e.RowIndex].Cells[1].Value.ToString() == profit.Category
                    && dgvProfits.Rows[e.RowIndex].Cells[2].Value.ToString() == profit.Name)
                    switch (e.ColumnIndex)
                    {
                        case 3:
                            profit.Summ = Convert.ToDouble(dgvProfits.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                            break;
                        case 4:
                            profit.Currency = dgvProfits.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            break;
                        case 6:
                            profit.IsPeriodic = Convert.ToBoolean(dgvProfits.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                            break;
                    }

            }
        }

        private void toolStripButtonProfitsDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить выбранную запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewCell cell = dgvProfits.SelectedCells[0];
                foreach (Profit profit in finansialAssistant.Profits)
                    if (dgvProfits.Rows[cell.RowIndex].Cells[0].Value.ToString() == profit.Date.ToString()
                    && dgvProfits.Rows[cell.RowIndex].Cells[1].Value.ToString() == profit.Category
                    && dgvProfits.Rows[cell.RowIndex].Cells[2].Value.ToString() == profit.Name)
                    {
                        finansialAssistant.Profits.Remove(profit);
                        LoadExpensessToForm();
                        break;
                    }
            }
        }


        private void LoadCashSavingToForm()
        {
            dgvCashSaving.Rows.Clear();
            foreach (CashSaving cash in finansialAssistant.CashSavings)
                dgvCashSaving.Rows.Add(new object[] {cash.Date.ToString(), cash.Summ, cash.Currency, cash.Storage });
        }

        private void toolStripButtonCashAdd_Click(object sender, EventArgs e)
        {
            FormAddFinansial form = new FormAddFinansial("CashSaving");
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.cashSaving != null)
                {
                    finansialAssistant.CashSavings.Add(form.cashSaving);
                    LoadCashSavingToForm();
                }
            }
        }

        private void toolStripButtonCashDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить выбранную запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewCell cell = dgvCashSaving.SelectedCells[0];
                foreach (CashSaving cash in finansialAssistant.CashSavings)
                    if (dgvCashSaving.Rows[cell.RowIndex].Cells[0].Value.ToString() == cash.Date.ToString()        )
                    {
                        finansialAssistant.CashSavings.Remove(cash);
                        LoadCashSavingToForm();
                        break;
                    }
            }
        }

        private void dgvCashSaving_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (CashSaving cash in finansialAssistant.CashSavings)
            {

                if (dgvCashSaving.Rows[e.RowIndex].Cells[0].Value.ToString() == cash.Date.ToString()        )
                    switch (e.ColumnIndex)
                    {
                        case 1:
                            cash.Summ = Convert.ToDouble(dgvCashSaving.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                            break;
                        case 2:
                            cash.Currency = dgvCashSaving.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            break;
                        case 3:
                            cash.Storage = dgvCashSaving.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            break;
                    }

            }
        }

        private void LoadDebtsToForm()
        {
            dgvDebts.Rows.Clear();
            foreach (Debt debt in finansialAssistant.Debts)
                dgvDebts.Rows.Add(new object[] { debt.Creditor, debt.Debtor, debt.Summ, debt.Currency, debt.IssueDate, debt.ReturnDate, debt.IsReturned});
        }

        private void toolStripButtonDebtAdd_Click(object sender, EventArgs e)
        {
            FormAddFinansial form = new FormAddFinansial("Debts");
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (form.debt != null)
                {
                    finansialAssistant.Debts.Add(form.debt);
                    LoadDebtsToForm();
                }
            }
        }

        private void toolStripButtonDebtDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить выбранную запись?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewCell cell = dgvDebts.SelectedCells[0];
                foreach (Debt debt in finansialAssistant.Debts)
                    if (dgvDebts.Rows[cell.RowIndex].Cells[0].Value.ToString() == debt.Creditor
                    && dgvDebts.Rows[cell.RowIndex].Cells[1].Value.ToString() == debt.Debtor
                    && dgvDebts.Rows[cell.RowIndex].Cells[4].Value.ToString() == debt.IssueDate.ToString())
                    {
                        finansialAssistant.Debts.Remove(debt);
                        LoadDebtsToForm();
                        break;
                    }
            }
        }

        private void dgvDebts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Debt debt in finansialAssistant.Debts)
            {

                if (dgvDebts.Rows[e.RowIndex].Cells[0].Value.ToString() == debt.Creditor
                    && dgvDebts.Rows[e.RowIndex].Cells[1].Value.ToString() == debt.Debtor
                    && dgvDebts.Rows[e.RowIndex].Cells[4].Value.ToString() == debt.IssueDate.ToString())
                    switch (e.ColumnIndex)
                    {
                        case 2:
                            debt.Summ = Convert.ToDouble(dgvDebts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                            break;
                        case 3:
                            debt.Currency = dgvDebts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                            break;
                        case 5:
                            debt.ReturnDate = Convert.ToDateTime( dgvDebts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                            break;
                        case 6:
                            debt.IsReturned = Convert.ToBoolean( dgvDebts.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                            break;
                    }

            }
        }

        private void buttonReportAll_Click(object sender, EventArgs e)
        {
            dgvReport.Rows.Clear();

            double SummExpenses = 0;
            var expensess = from i in finansialAssistant.Expensess where i.Date.Date<=dateTimePickerReportPo.Value.Date && i.Date.Date >= dateTimePickerReportS.Value.Date select i;            
            foreach (Expenses expenses in expensess)
                SummExpenses += expenses.Summ;

            double SummProfit=0;
            var profits = from i in finansialAssistant.Profits where i.Date.Date <= dateTimePickerReportPo.Value.Date && i.Date.Date >= dateTimePickerReportS.Value.Date select i;
            foreach (Profit profit in profits)
                SummProfit += profit.Summ;

            double SummCashSaving = 0;
            var cash = from i in finansialAssistant.CashSavings where i.Date.Date <= dateTimePickerReportPo.Value.Date && i.Date.Date >= dateTimePickerReportS.Value.Date select i;
            foreach (CashSaving cashSaving in cash)
                SummCashSaving += cashSaving.Summ;

            dgvReport.Rows.Add(new object[] {"Доход", SummProfit.ToString() });
            dgvReport.Rows.Add(new object[] {"Траты", SummExpenses.ToString() });
            dgvReport.Rows.Add(new object[] {"Баланс", (SummProfit - SummExpenses).ToString() });
            dgvReport.Rows.Add(new object[] {"Изменение накоплений", SummCashSaving.ToString() });
        }

        private void buttonReportProfit_Click(object sender, EventArgs e)
        {
            dgvReport.Rows.Clear();
            var profits = from i in finansialAssistant.Profits where i.Date.Date <= dateTimePickerReportPo.Value.Date && i.Date.Date >= dateTimePickerReportS.Value.Date select i;
            var Categories = from i in finansialAssistant.Profits where i.Date.Date <= dateTimePickerReportPo.Value.Date && i.Date.Date >= dateTimePickerReportS.Value.Date group i by i.Category;
            Dictionary<string, double> vs = new Dictionary<string,double>();

            foreach (var category in Categories)
            {               
                vs.Add(category.Key,0);
            }
            double Summ = 0;
            foreach (Profit profit in profits)
            {
                Summ += profit.Summ;
                vs[profit.Category] += profit.Summ;
            }
            dgvReport.Rows.Add(new object[] { "Сумма", Summ });
            dgvReport.Rows.Add(new object[] {"", "" });
            foreach (var a in vs)
                dgvReport.Rows.Add(new object[] { a.Key, a.Value });

        }

        private void buttonReportExpepses_Click(object sender, EventArgs e)
        {
            dgvReport.Rows.Clear();
            var expensess = from i in finansialAssistant.Expensess where i.Date.Date <= dateTimePickerReportPo.Value.Date && i.Date.Date >= dateTimePickerReportS.Value.Date select i;
            var Categories = from i in finansialAssistant.Expensess where i.Date.Date <= dateTimePickerReportPo.Value.Date && i.Date.Date >= dateTimePickerReportS.Value.Date group i by i.Category;
            Dictionary<string, double> vs = new Dictionary<string, double>();

            foreach (var category in Categories)
            {
                vs.Add(category.Key, 0);
            }
            double Summ = 0;
            foreach (Expenses expenses in expensess)
            {
                Summ += expenses.Summ;
                vs[expenses.Category] += expenses.Summ;
            }
            dgvReport.Rows.Add(new object[] { "Сумма", Summ });
            dgvReport.Rows.Add(new object[] { "", "" });
            foreach (var a in vs)
                dgvReport.Rows.Add(new object[] { a.Key, a.Value });
        }
    }
}
