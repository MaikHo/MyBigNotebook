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
    public partial class FormCalendar : Form
    {
        private ClassCalendar Calendar;
        public FormCalendar(ClassCalendar classCalendar)
        {
            InitializeComponent();
            Calendar = classCalendar;
            panelAdd.Visible = false;
            LoadToCalendar();
        }


        private void LoadToCalendar()
        {
            foreach(BirthDay birthDay in Calendar.BirthDays)
            {
                monthCalendarMain.AddAnnuallyBoldedDate(birthDay.Date);
            }

            foreach(MemorableDate memorableDate in Calendar.MemorableDates)
            {
                monthCalendarMain.AddAnnuallyBoldedDate(memorableDate.Date);
            }

            foreach(Reminder  reminder in Calendar.Reminders)
            {
                monthCalendarMain.AddBoldedDate(reminder.Time);
            }
            monthCalendarMain.Refresh();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            BirthDay day = new BirthDay();
            day.Date = DateTime.Now;
            day.FIO = "qweqeqweq" + DateTime.Now.ToString();
            Calendar.BirthDays.Add(day);
            LoadToCalendar();
            panelAdd.Visible = true;
        }

        private void FormCalendar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
