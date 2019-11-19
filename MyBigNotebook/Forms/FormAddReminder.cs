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
    public partial class FormAddReminder : Form
    {
        public Reminder reminder;
        public FormAddReminder(DateTime date)
        {
            InitializeComponent();
            dateTimePickerDate.Value = date;
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            reminder = new Reminder();
            reminder.Time = dateTimePickerDate.Value;
            reminder.Time = reminder.Time.AddHours( Convert.ToDouble( numericUpDownHours.Value));
            reminder.Time = reminder.Time.AddMinutes(Convert.ToDouble(numericUpDownMinutes.Value));
            reminder.Name = textBoxName.Text;
            reminder.Text = textBoxText.Text;
            this.DialogResult = DialogResult.OK;

        }
    }
}
