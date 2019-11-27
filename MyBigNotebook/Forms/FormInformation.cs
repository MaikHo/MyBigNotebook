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
            LoadHelpfullInformationToForm();
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
                    try
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
                    catch { }
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
            foreach (DataGridViewCell cell in dgvInfoList.SelectedCells)
                cell.Selected = false;
            foreach (DataGridViewCell cell in dgvLinks.SelectedCells)
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
            dgvLinks.Rows.Clear();
            foreach (HelpfullLink link in classInformation.HelpfullLinks)
            {
                dgvLinks.Rows.Add(new object[] { link.Name });
            }
        }

       

        private void toolStripButtonLinkAdd_Click(object sender, EventArgs e)
        {
            toolStripButtonLinksCancelAdd.Visible = true;
            toolStripButtonLinkAdd.Visible = false;
            toolStripSeparatorLink2.Visible = true;
            toolStripLabelLinkAdd.Visible = true;
            toolStripTextBoxLinkAddName.Visible = true;
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

        private void dgvLinks_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.StateChanged == DataGridViewElementStates.Selected)
            {
                if(e.Cell.Selected)
                {
                    foreach (HelpfullLink link in classInformation.HelpfullLinks)
                        if (link.Name == e.Cell.Value.ToString())
                        {
                            linkLabelmain.Text = link.Link;
                            rtbLinkDescription.Text = link.Description;
                        }
                }
                else
                {
                    try
                    {
                        if (!linkLabelmain.Visible)
                        {
                            linkLabelmain.Text = textBoxLink.Text;
                            linkLabelmain.Visible = true;
                            textBoxLink.Visible = false;
                        }
                        HelpfullLink link = classInformation.HelpfullLinks.Where(t => t.Name == e.Cell.Value.ToString()).First();
                        link.Link = linkLabelmain.Text;
                        link.Description = rtbLinkDescription.Text;
                    }
                    catch { }
                }

            }
        }

        private void toolStripButtonLinkDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите удалить ссылку {dgvLinks.SelectedCells[0].Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HelpfullLink link = classInformation.HelpfullLinks.Where(t => t.Name == dgvLinks.SelectedCells[0].Value.ToString()).First();
                classInformation.HelpfullLinks.Remove(link);
                LoadHelpfullLinksToForm();
            }
        }

        private void toolStripTextBoxLinkAddName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData ==Keys.Enter)
            {
                toolStripButtonLinkAdd.Visible = true;
                toolStripButtonLinksCancelAdd.Visible = false;               
                toolStripSeparatorLink2.Visible = false;
                toolStripLabelLinkAdd.Visible = false;
                toolStripTextBoxLinkAddName.Visible = false;

                HelpfullLink link = new HelpfullLink();
                link.Name = toolStripTextBoxLinkAddName.Text;
                classInformation.HelpfullLinks.Add(link);
                LoadHelpfullLinksToForm();
                toolStripTextBoxLinkAddName.Text = "";
            }
        }

        private void textBoxLink_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData==Keys.Enter)
            {
                linkLabelmain.Text = textBoxLink.Text;
                linkLabelmain.Visible = true;
                textBoxLink.Visible = false;
            }
        }

        private void LoadHelpfullInformationToForm()
        {
            dgvInfoList.Rows.Clear();
            foreach (HelpfullInformation information in classInformation.HelpfullsInfo)
                dgvInfoList.Rows.Add(new object[] { information.Name });
        }

        private void toolStripButtonInfoAdd_Click(object sender, EventArgs e)
        {
            toolStripButtonInfoAdd.Visible = false;
            toolStripLabelInfoAdd.Visible = true;
            toolStripTextBoxInfoName.Visible = true;
            toolStripSeparatorInfo1.Visible = true;
            toolStripButtonInfoAddClose.Visible = true;
        }

        private void toolStripButtonLinksCancelAdd_Click(object sender, EventArgs e)
        {
            toolStripButtonLinkAdd.Visible = true;
            toolStripButtonLinksCancelAdd.Visible = false;
            toolStripSeparatorLink2.Visible = false;
            toolStripLabelLinkAdd.Visible = false;
            toolStripTextBoxLinkAddName.Visible = false;
        }

        private void toolStripTextBoxInfoName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                HelpfullInformation helpfull = new HelpfullInformation();
                helpfull.Name = toolStripTextBoxInfoName.Text;
                toolStripTextBoxInfoName.Text = "";
                classInformation.HelpfullsInfo.Add(helpfull);
                LoadHelpfullInformationToForm();

                toolStripButtonInfoAdd.Visible = true;
                toolStripButtonInfoAddClose.Visible = false;
                toolStripSeparatorInfo1.Visible = false;
                toolStripLabelInfoAdd.Visible = false;
                toolStripTextBoxInfoName.Visible = false;
            }
        }

        private void toolStripButtonInfoDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Вы точно хотите удалить пакет информации {dgvInfoList.SelectedCells[0].Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                HelpfullInformation information = classInformation.HelpfullsInfo.Where(t => t.Name == dgvInfoList.SelectedCells[0].Value.ToString()).First();
                classInformation.HelpfullsInfo.Remove(information);
                LoadHelpfullInformationToForm();
            }
        }

        private void dgvInfoList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs eCell)
        {
            if (eCell.StateChanged == DataGridViewElementStates.Selected)
                if(eCell.Cell.Selected)
                {                   
                    HelpfullInformation information = classInformation.HelpfullsInfo.Where(t => t.Name == eCell.Cell.Value.ToString()).First();
                    rtbInfo.Text = information.Text;
                    tbInfoKeys.Text = "";
                    foreach (string s in information.keyWords)
                        tbInfoKeys.Text += s + ", ";
                }
                else
                {
                    try
                    {
                        HelpfullInformation information = classInformation.HelpfullsInfo.Where(t => t.Name == eCell.Cell.Value.ToString()).First();
                        information.Text = rtbInfo.Text;
                        information.keyWords.Clear();
                        string[] str = tbInfoKeys.Text.Split(new char[] { ',', '\n' });
                        foreach (string s in str)
                            information.keyWords.Add(s.Trim());
                        int count = information.keyWords.Where(e => e == "").Count();
                        for (int i = 0; i < count; i++)
                            information.keyWords.Remove("");
                    }
                    catch { }

                }
        }

        private void toolStripButtonInfoAddClose_Click(object sender, EventArgs e)
        {
            toolStripButtonInfoAdd.Visible = true;
            toolStripButtonInfoAddClose.Visible = false;
            toolStripSeparatorInfo1.Visible = false;
            toolStripLabelInfoAdd.Visible = false;
            toolStripTextBoxInfoName.Visible = false;
        }
    }
}
