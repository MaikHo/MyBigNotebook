using System;
using System.Windows.Forms;

namespace MyBigNotebook.Forms
{
    public partial class FormAddFinansial : Form
    {
        private string AddClasses;
        public Expenses expenses;
        public Profit profit;
        public CashSaving cashSaving;
        public Debt debt;

        public FormAddFinansial(string addClass)
        {
            InitializeComponent();
            AddClasses = addClass;

            switch (AddClasses)
            {
                case "Expenses":
                    this.Text = "Добавить позицию по расходам";
                    panelDate.Visible = true;
                    panelCategory.Visible = true;
                    panelName.Visible = true;
                    panelSumm.Visible = true;
                    panelCurrency.Visible = true;
                    panelIsPeriodic.Visible = true;
                    panelSource.Visible = false;
                    panelStorage.Visible = false;
                    panelCreditor.Visible = false;
                    panelDebtor.Visible = false;
                    panelIsReturned.Visible = false;
                    panelIssueDate.Visible = false;
                    panelReturnDate.Visible = false;
                    break;

                case "Profits":
                    this.Text = "Добавить позицию по доходам";
                    panelDate.Visible = true;
                    panelCategory.Visible = true;
                    panelName.Visible = true;
                    panelSumm.Visible = true;
                    panelCurrency.Visible = true;
                    panelIsPeriodic.Visible = true;
                    panelSource.Visible = true;
                    panelStorage.Visible = false;
                    panelCreditor.Visible = false;
                    panelDebtor.Visible = false;
                    panelIsReturned.Visible = false;
                    panelIssueDate.Visible = false;
                    panelReturnDate.Visible = false;
                    break;

                case "CashSaving":
                    this.Text = "Добавить позицию по накоплениям";
                    panelDate.Visible = true;
                    panelCategory.Visible = false;
                    panelName.Visible = false;
                    panelSumm.Visible = true;
                    panelCurrency.Visible = true;
                    panelIsPeriodic.Visible = false;
                    panelSource.Visible = false;
                    panelStorage.Visible = true;
                    panelCreditor.Visible = false;
                    panelDebtor.Visible = false;
                    panelIsReturned.Visible = false;
                    panelIssueDate.Visible = false;
                    panelReturnDate.Visible = false;
                    break;

                case "Debts":
                    this.Text = "Добавить позицию по долгам";
                    panelDate.Visible = false;
                    panelCategory.Visible = false;
                    panelName.Visible = false;
                    panelSumm.Visible = true;
                    panelCurrency.Visible = true;
                    panelIsPeriodic.Visible = false;
                    panelSource.Visible = false;
                    panelStorage.Visible = false;
                    panelCreditor.Visible = true;
                    panelDebtor.Visible = true;
                    panelIsReturned.Visible = true;
                    panelIssueDate.Visible = true;
                    panelReturnDate.Visible = true;
                    break;

                default:
                    MessageBox.Show("Не определен тип добавляемого элемента");
                    this.Close();
                    break;

            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (AddClasses)
            {
                case "Expenses":
                    expenses = new Expenses();
                    expenses.Category = textBoxCategory.Text;
                    expenses.Currency = comboBoxCurrency.Text;
                    expenses.Date = dateTimePickerDate.Value;
                    expenses.IsPeriodic = checkBoxIsPeriodic.Checked;
                    expenses.Name = textBoxName.Text;
                    expenses.Summ = Convert.ToDouble( textBoxSumm.Text);
                    break;

                case "Profits":
                    profit = new Profit();
                    profit.Category = textBoxCategory.Text;
                    profit.Currency = comboBoxCurrency.Text;
                    profit.Date = dateTimePickerDate.Value;
                    profit.IsPeriodic = checkBoxIsPeriodic.Checked;
                    profit.Name = textBoxName.Text;
                    profit.Source = textBoxSource.Text;
                    profit.Summ = Convert.ToDouble(textBoxSumm.Text);
                    break;

                case "CashSaving":
                    cashSaving = new CashSaving();
                    cashSaving.Currency = comboBoxCurrency.Text;
                    cashSaving.Date = dateTimePickerDate.Value;
                    cashSaving.Storage = textBoxStorage.Text;
                    cashSaving.Summ = Convert.ToDouble(textBoxSumm.Text);
                    break;

                case "Debts":
                    debt = new Debt();
                    debt.Creditor = textBoxCreditor.Text;
                    debt.Currency = comboBoxCurrency.Text;
                    debt.Summ = Convert.ToDouble(textBoxSumm.Text);
                    debt.Debtor = textBoxDebtor.Text;
                    debt.IsReturned = checkBoxIsReturned.Checked;
                    debt.IssueDate = dateTimePickerIssueDate.Value;
                    debt.ReturnDate = dateTimePickerReturnDate.Value;                   
                    break;

                default:
                    
                    break;

            }
            this.DialogResult = DialogResult.OK;
        }
    }
}
