using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBigNotebook.Classes;

namespace MyBigNotebook.Forms
{
    public partial class FormAddPhoto : Form
    {
        public Photograph photograph;
        public FormAddPhoto(IEnumerable<string> categories)
        {

            InitializeComponent();

            foreach (string s in categories)
                cbCategory.Items.Add(s);

        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openPhotoFileDialod.ShowDialog() == DialogResult.OK)
                tbPhotoFile.Text = openPhotoFileDialod.FileName;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            photograph = new Photograph();
            photograph.Name = tbName.Text;
            photograph.Category = cbCategory.Text;
            photograph.Description = tbDescription.Text;
            photograph.KeyWords = ClassConvert.getKeysList(tbKeyWorlds.Text);
            photograph.Photo = ClassConvert.ConvertImageToBase64(tbPhotoFile.Text);
            this.DialogResult = DialogResult.OK;
        }
    }
}
