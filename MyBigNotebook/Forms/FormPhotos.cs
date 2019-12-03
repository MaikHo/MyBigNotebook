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
    public partial class FormPhotos : Form
    {
        private ClassPhoto Photos;
        private Photograph currentPhotograph;
        public FormPhotos(ClassPhoto photo)
        {
            InitializeComponent();
            Photos = photo;
            LoadPhotoToForm();
        }

        private IEnumerable<string> getCategories()
        {
            return Photos.Photographs.GroupBy(p => p.Category).Select(g => g.Key);
        }
        private void LoadPhotoToForm()
        {
            treeViewPhoto.Nodes.Clear();
            foreach (string s in getCategories())
            {
                
                treeViewPhoto.Nodes.Add(s, s);
            }

            foreach (Photograph photograph in Photos.Photographs)
            {
                try
                {                   

                    treeViewPhoto.Nodes[photograph.Category].Nodes.Add(photograph.Name, photograph.Name);
                } catch(Exception ex) { MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace); }
            }
            
            
        }

        private void tspAdd_Click(object sender, EventArgs e)
        {
            FormAddPhoto form = new FormAddPhoto(getCategories());
            if (form.ShowDialog()== DialogResult.OK)
            {
                Photos.Photographs.Add(form.photograph);
                LoadPhotoToForm();
            }
        }

       

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            TreeNode node = treeViewPhoto.SelectedNode;
            if (node.Level ==1)
            {
                if( MessageBox.Show($"Вы точно хотите удалить фото {node.Name}?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==DialogResult.Yes)
                {
                    Photos.Photographs.Remove(currentPhotograph);
                    currentPhotograph = null;
                    LoadPhotoToForm();
                    tbKeyWorlds.Text = "";
                    rtbDescription.Text = "";
                    pictureBoxPhoto.Image = null;
                }

            }
            LoadPhotoToForm();
        }


        private void treeViewPhoto_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node.Level ==1)
            {
                currentPhotograph = Photos.Photographs.Where(p => p.Name == e.Node.Name && p.Category == e.Node.Parent.Name).First();

                pictureBoxPhoto.Image = ClassConvert.ConvertBase64ToImage(currentPhotograph.Photo);
                tbKeyWorlds.Text = ClassConvert.getKeyString(currentPhotograph.KeyWords);
                rtbDescription.Text = currentPhotograph.Description;
            }
          
        }
       

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            if (currentPhotograph != null)
                currentPhotograph.Description = rtbDescription.Text;
        }

        private void tbKeyWorlds_TextChanged(object sender, EventArgs e)
        {
            if(currentPhotograph!=null)
                currentPhotograph.KeyWords = ClassConvert.getKeysList(tbKeyWorlds.Text);
        }

        private void pictureBoxPhoto_DoubleClick(object sender, EventArgs e)
        {
            FormViewPhoto form = new FormViewPhoto(pictureBoxPhoto.Image);
            form.Show();
        }
    }
}
