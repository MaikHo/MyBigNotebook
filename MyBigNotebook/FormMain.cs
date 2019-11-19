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
           
           
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            FormCalendar calendar = new FormCalendar(data.calendar);
            if (calendar.ShowDialog() == DialogResult.OK)
            {
               
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.SaveData();
        }
    }
}
