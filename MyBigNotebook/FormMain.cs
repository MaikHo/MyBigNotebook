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
using Microsoft.Win32;
using System.Configuration;

namespace MyBigNotebook
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// хранилище данных
        /// </summary>
        private ClassData data;

        const string applicationName = "MyBigNotebook";
        const string pathRegistryKeyStartup =
                    "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public FormMain()
        {
            InitializeComponent();

            data = new ClassData();           
            data.LoadData();
            notifyIconMain.Visible = true;
            tsAutoRun.Checked = CheckAutoRun();
            SetSetting();

        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            if (!data.Crypted())
            {
                FormCalendar calendar = new FormCalendar(data.calendar);
                calendar.Show();
            }
            else MessageBox.Show("Данные зашифрованы и их просмотр недоступен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.SaveData();
        }

        private void buttonDiary_Click(object sender, EventArgs e)
        {
            if (!data.Crypted())
            {
                FormDiary form = new FormDiary(data.diary);
                form.Show();
            }
            else MessageBox.Show("Данные зашифрованы и их просмотр недоступен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void buttonFinansial_Click(object sender, EventArgs e)
        {
            if (!data.Crypted())
            {
                FormFinansialAssistant form = new FormFinansialAssistant(data.finansialAssistant);
                form.Show();
            }
            else MessageBox.Show("Данные зашифрованы и их просмотр недоступен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            if (!data.Crypted())
            {
                FormInformation form = new FormInformation(data.information);
                form.Show();
            }
            else MessageBox.Show("Данные зашифрованы и их просмотр недоступен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            if (!data.Crypted())
            {
                FormNotes form = new FormNotes(data.notes);
                form.Show();
            }
            else MessageBox.Show("Данные зашифрованы и их просмотр недоступен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonPhoto_Click(object sender, EventArgs e)
        {
            if (!data.Crypted())
            {
                FormPhotos form = new FormPhotos(data.photo);
                form.Show();
            }
            else MessageBox.Show("Данные зашифрованы и их просмотр недоступен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonPlants_Click(object sender, EventArgs e)
        {
            if (!data.Crypted())
            {
                FormPlans form = new FormPlans(data.plants);
                form.Show();
            }
            else MessageBox.Show("Данные зашифрованы и их просмотр недоступен", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (data.CryptKeyTest())
                        {
                            data.Decrypt();
                            MessageBox.Show("Операция завершена");
                        }
                        else MessageBox.Show("Неверный ключ!");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                }
                else
                {
                    MessageBox.Show("Дешифрование не выполнено, так как данные не зашифрованы", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tsAutoRun_Click(object sender, EventArgs e)
        {           

            using (RegistryKey registryKeyStartup =
                        Registry.CurrentUser.OpenSubKey(pathRegistryKeyStartup, true))
            {
                if (!CheckAutoRun())
                {
                    registryKeyStartup.SetValue(
                        applicationName,
                        $@"{System.Reflection.Assembly.GetExecutingAssembly().Location}");
                }
                else
                {
                    registryKeyStartup.DeleteValue(applicationName, false);
                }
            }
        }

        private bool CheckAutoRun()
        {
            const string pathRegistryKeyStartup =
                        "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            using (RegistryKey registryKeyStartup = Registry.CurrentUser.OpenSubKey(pathRegistryKeyStartup, true))
            {
                if (registryKeyStartup.GetValue(applicationName) != null) return true;
            }
            return false;
        }

        private void FormMain_DoubleClick(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void timerAutoSave_Tick(object sender, EventArgs e)
        {
            try
            {
                data.SaveData();
            }
            catch { }
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemSetting_Click(object sender, EventArgs e)
        {
            FormSetting form = new FormSetting();
            if( form.ShowDialog()==DialogResult.OK)
            {
                SetSetting();
            }
        }

        private void SetSetting()
        {
            timerAutoSave.Enabled = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("AutoSave"));
            timerAutoSave.Interval = Convert.ToInt32(ConfigurationManager.AppSettings.Get("TimeAutoSave"))*60*1000;
        }
    }
}
