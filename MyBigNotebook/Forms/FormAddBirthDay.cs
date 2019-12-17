using System;
using System.Windows.Forms;

namespace MyBigNotebook
{
    public partial class FormAddBirthDay : Form
    {
        public BirthDay birthDay;
        public FormAddBirthDay(DateTime date)
        {                    
            InitializeComponent();
            dateTimePickerDate.Value = date;            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            birthDay = new BirthDay();
            birthDay.Date = dateTimePickerDate.Value;
            birthDay.FIO = textBoxFIO.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
