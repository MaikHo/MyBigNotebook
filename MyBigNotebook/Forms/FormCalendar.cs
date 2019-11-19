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
            FormAddBirthDay formAddBirthDay = new FormAddBirthDay(monthCalendarMain.SelectionStart);

            if (formAddBirthDay.ShowDialog() == DialogResult.OK)
            {
                Calendar.BirthDays.Add(formAddBirthDay.birthDay);
                LoadToCalendar();
            }
        }

        private void FormCalendar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Сравнение двух дат по дню и месяцу
        /// </summary>
        /// <param name="date1"></param>
        /// <param name="date2"></param>
        /// <returns></returns>
        private bool DayAndMonthQuality(DateTime date1, DateTime date2)
        {
            if (date1.Date.Date.Day == date2.Date.Day && date1.Date.Date.Month == date2.Date.Month)
                return true;
            else return false;
        }


        private void monthCalendarMain_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBoxDayInfo.Text = "";
            foreach (BirthDay birthDay in Calendar.BirthDays)
            {
                if (DayAndMonthQuality(birthDay.Date, e.Start))
                    textBoxDayInfo.Text += $"День рождения у {birthDay.FIO}. {e.Start.Year - birthDay.Date.Year} лет.{Environment.NewLine}";
            }

            foreach (MemorableDate memorableDate in Calendar.MemorableDates)
            {
                if (DayAndMonthQuality(memorableDate.Date, e.Start))
                    textBoxDayInfo.Text += $"{memorableDate.Name}{Environment.NewLine}  {memorableDate.Description}{Environment.NewLine}";
            }

            foreach (Reminder reminder in Calendar.Reminders)
            {
                if (reminder.Time.Date == e.Start.Date)
                    textBoxDayInfo.Text += $"{reminder.Name}{Environment.NewLine}   {reminder.Text}{Environment.NewLine}";
            }
        }

        private void tbAddMemorable_Click(object sender, EventArgs e)
        {
            FormAddMemorableDate formAddMemorable = new FormAddMemorableDate(monthCalendarMain.SelectionStart);
            if(formAddMemorable.ShowDialog()==DialogResult.OK)
            {
                Calendar.MemorableDates.Add(formAddMemorable.memorableDate);
                LoadToCalendar();
            }
        }

        private void tbAddReminder_Click(object sender, EventArgs e)
        {
            FormAddReminder formAdd = new FormAddReminder(monthCalendarMain.SelectionStart);
            if(formAdd.ShowDialog()==DialogResult.OK)
            {
                Calendar.Reminders.Add(formAdd.reminder);
                LoadToCalendar();
            }
        }
    }
}
