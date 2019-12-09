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

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            FormPhotos form = new FormPhotos(data.photo);
            form.Show();
        }

        private void buttonPlants_Click(object sender, EventArgs e)
        {
            FormPlans form = new FormPlans(data.plants);
            form.Show();
        }

        private void contextMenuStripNotify_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButtonInTray_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void notifyIconMain_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }

        private void tsCrypt_Click(object sender, EventArgs e)
        {
            FormCryptKey form = new FormCryptKey("");
            if (!data.Crypted())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ClassCrypt.SetKey(form.textBoxKey.Text);
                        data.Encrypt();
                        MessageBox.Show("Операция завершена");
                    }
                    catch(Exception ex) { MessageBox.Show(ex.Message); }
                }
            } else
            {
                MessageBox.Show("Шифрование уже выполнено!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsDecrypt_Click(object sender, EventArgs e)
        {
            if (data.Crypted())
            {
                FormCryptKey form = new FormCryptKey("");
                if (form.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ClassCrypt.SetKey(form.textBoxKey.Text);
                        data.Decrypt();
                        MessageBox.Show("Операция завершена");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                }
                else
                {
                    MessageBox.Show("Шифрование не выполнено!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void TsDeleteAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Удалить все данные без возможности восстановления?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (data.DeleteData())
                    MessageBox.Show("Данные удалены");
                else MessageBox.Show("Что-то пошло не так");
            }
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = true;
        }
    }
}
