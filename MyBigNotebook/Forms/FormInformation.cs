using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MyBigNotebook.Forms
{
    public partial class FormInformation : Form
    {
        private ClassInformation classInformation;

        private int idDossierPhoto = 0;
        private Dossier NowDossier;
        public FormInformation(ClassInformation information)
        {
            InitializeComponent();
            classInformation = information;
            LoadDossierListToForm();
            LoadHelpfullLinksToForm();
        }

        private void LoadDossierListToForm()
        {
            dgvDossierList.Rows.Clear();
            foreach (Dossier dossier in classInformation.Dossiers)
                dgvDossierList.Rows.Add(new object[] { dossier.idDossier, $"{dossier.LastName} {dossier.Name} {dossier.SurName}" });
        }

        private void dgvDossierList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if (e.Cell.Selected)
                {
                    foreach (Dossier rec in classInformation.Dossiers)
                        if (rec.idDossier.ToString() == dgvDossierList.Rows[e.Cell.RowIndex].Cells[0].Value.ToString())
                        {
                            tbName.Text = rec.Name;
                            tbLastName.Text = rec.LastName;
                            tbSurName.Text = rec.SurName;
                            dtpBirthDay.Value = rec.BirthDay;
                            tbInterests.Text = rec.Interests;
                            tbDescription.Text = rec.Description;
                            tbAdditionalInformation.Text = rec.AdditionalInformation;
                            tbFamilyStatus.Text = rec.FamilyStatus;
                            tbEduLevel.Text = rec.EducationLevel;
                            tbSpec.Text = rec.EducatonLocationAndSpec;
                            tbWorkPlace.Text = rec.WorkPlace;
                            tbWorkPost.Text = rec.WorkPosition;

                            if(rec.Photos.Count>0)
                            {
                                pictureBoxDossierPhoto.Image = MyBigNotebook.Classes.ClassConvert.ConvertBase64ToImage(rec.Photos[0]);
                                idDossierPhoto = 0;
                            }
                            dgvDossierContakts.Rows.Clear();
                            foreach (Kontact kontact in rec.Kontacts)
                            {
                                dgvDossierContakts.Rows.Add(new object[] { kontact.System, kontact.Number });
                            }
                            NowDossier = rec;

                        }
                }
                else
                {
                    foreach (Dossier rec in classInformation.Dossiers)
                        if (rec.idDossier.ToString() == dgvDossierList.Rows[e.Cell.RowIndex].Cells[0].Value.ToString())
                        {
                            rec.Name = tbName.Text;
                            rec.LastName = tbLastName.Text;
                            rec.SurName = tbSurName.Text;
                            rec.BirthDay = dtpBirthDay.Value;
                            rec.Interests = tbInterests.Text;
                            rec.Description = tbDescription.Text;
                            rec.AdditionalInformation = tbAdditionalInformation.Text;
                            rec.FamilyStatus = tbFamilyStatus.Text;
                            rec.EducationLevel = tbEduLevel.Text;
                            rec.EducatonLocationAndSpec = tbSpec.Text;
                            rec.WorkPlace = tbWorkPlace.Text;
                            rec.WorkPosition = tbWorkPost.Text;

                            rec.Kontacts.Clear();
                            foreach (DataGridViewRow row in dgvDossierContakts.Rows)
                                rec.Kontacts.Add(new Kontact(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString()));
                        }
                }
            }
        }

        private void contextMenuStripDossierContakts_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripButtonAddDossier_Click(object sender, EventArgs e)
        {
            Dossier dossier = new Dossier();
            dossier.idDossier = classInformation.GetNewDossierID();
            classInformation.Dossiers.Add(dossier);
            LoadDossierListToForm();
        }

        private void toolStripButtonAddPhoto_Click(object sender, EventArgs e)
        {
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
                NowDossier.Photos.Add(Classes.ClassConvert.ConvertImageToBase64(openFileDialogPhoto.FileName));
        }

        private void toolStripButtonLeft_Click(object sender, EventArgs e)
        {
            if (idDossierPhoto > 0) idDossierPhoto--;

            pictureBoxDossierPhoto.Image = MyBigNotebook.Classes.ClassConvert.ConvertBase64ToImage(NowDossier.Photos[idDossierPhoto]);
           
        }

        private void toolStripButtonRingt_Click(object sender, EventArgs e)
        {
            if (idDossierPhoto < NowDossier.Photos.Count-1) idDossierPhoto++;

            pictureBoxDossierPhoto.Image = MyBigNotebook.Classes.ClassConvert.ConvertBase64ToImage(NowDossier.Photos[idDossierPhoto]);
        }

        private void FormInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvDossierList.SelectedCells)
                cell.Selected = false;
        }

        private void toolStripButtonDelPhoto_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show("Удалить выбранное фото?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NowDossier.Photos.Remove(NowDossier.Photos[idDossierPhoto]);

                if (NowDossier.Photos.Count >  0)
                {
                    idDossierPhoto = 0;
                    pictureBoxDossierPhoto.Image = MyBigNotebook.Classes.ClassConvert.ConvertBase64ToImage(NowDossier.Photos[idDossierPhoto]);
                }

            }
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            dgvDossierContakts.Rows.Add();
        }

        private void toolStripButtonDeleteDossier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите удалить личное дело {dgvDossierList.SelectedCells[0].Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                foreach (Dossier rec in classInformation.Dossiers)
                    if (rec.idDossier.ToString() == dgvDossierList.Rows[dgvDossierList.SelectedCells[0].RowIndex].Cells[0].Value.ToString())
                    {
                        classInformation.Dossiers.Remove(rec);
                        LoadDossierListToForm();
                    }
        }

        private void toolStripMenuItemDelete_Click(object sender, EventArgs e)
        {

            DataGridViewCell cell = dgvDossierContakts.SelectedCells[0];
            if (MessageBox.Show($"Удалить выбранную запись?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvDossierContakts.Rows.Remove(dgvDossierContakts.Rows[cell.RowIndex]);

            }

        }

        private void buttonEditLink_Click(object sender, EventArgs e)
        {
            linkLabelmain.Visible = false;
            textBoxLink.Text = linkLabelmain.Text;
            textBoxLink.Visible = true;
        }


        private void LoadHelpfullLinksToForm()
        {
            foreach (HelpfullLink link in classInformation.HelpfullLinks)
                listBoxLinks.Items.Add(link.Name);
        }

        private void listBoxLinks_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (HelpfullLink link in classInformation.HelpfullLinks)
                if (link.Name == listBoxLinks.SelectedItem.ToString())
                {
                    rtbLinkDescription.Text = link.Description;
                    linkLabelmain.Text = link.Link;
                }
        }

        private void toolStripButtonLinkAdd_Click(object sender, EventArgs e)
        {
            HelpfullLink link = new HelpfullLink();
            link.Link = "https://pikabu.ru/";
            link.Name = "Пикабу";
            link.Description = "Что-то с чем-то";
            classInformation.HelpfullLinks.Add(link);
            LoadHelpfullLinksToForm();
        }

      

        private void linkLabelmain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = linkLabelmain.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "https://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            linkLabelmain.LinkVisited = true;
        }
    }
}
