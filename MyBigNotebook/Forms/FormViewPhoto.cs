using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyBigNotebook.Forms
{
    public partial class FormViewPhoto : Form
    {
     
        public FormViewPhoto(Image image)
        {
            InitializeComponent();
           
            pictureBoxPhoto.Image = image;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog.FileName);
                using (Stream s = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write))
                {
                    try
                    {
                        Bitmap bitmap = new Bitmap(pictureBoxPhoto.Image);
                        bitmap.Save(s, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
