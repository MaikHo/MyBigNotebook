using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBigNotebook.Forms;

namespace MyBigNotebook
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// хранилище данных
        /// </summary>
        private ClassData data;
        public FormMain()
        {
            InitializeComponent();

            data = new ClassData();           
            data.LoadData();
            notifyIconMain.Visible = true;
           
           
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            FormCalendar calendar = new FormCalendar(data.calendar);
            calendar.Show();
            
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.SaveData();
        }

        private void buttonDiary_Click(object sender, EventArgs e)
        {
            FormDiary form = new FormDiary(data.diary);
            form.Show();

        }

        private void buttonFinansial_Click(object sender, EventArgs e)
        {
            FormFinansialAssistant form = new FormFinansialAssistant(data.finansialAssistant);
            form.Show();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            FormInformation form = new FormInformation(data.information);
            form.Show();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            FormNotes form = new FormNotes(data.notes);
            form.Show();
        }
    }
}
