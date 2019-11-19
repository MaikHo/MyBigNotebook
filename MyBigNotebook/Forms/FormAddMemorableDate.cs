using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBigNotebook
{
    public partial class FormAddMemorableDate : Form
    {
        public MemorableDate memorableDate;
        public FormAddMemorableDate(DateTime date)
        {
            InitializeComponent();
            dateTimePickerDate.Value = date;
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            memorableDate = new MemorableDate();
            memorableDate.Date = dateTimePickerDate.Value;
            memorableDate.Description = textBoxDescription.Text;
            memorableDate.Name = textBoxName.Text;
            memorableDate.Promt = checkBoxPromt.Checked;
            this.DialogResult = DialogResult.OK;
        }
    }
}
