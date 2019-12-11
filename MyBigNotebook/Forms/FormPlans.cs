using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBigNotebook.Forms
{
    public partial class FormPlans : Form
    {
        private ShoppingList CurrentShopping = null;

        private ClassPlants plants;
        public FormPlans(ClassPlants classPlants)
        {
            InitializeComponent();
            plants = classPlants;
            setFutureVisible(false);
            setProjectVisible(false);
            setShoppingVisible(false);
            setTargetVisible(false);

            LoadFuturePlanToForm();
            LoadTargetsToForm();
            LoadShoppingTree();
            LoadProjectList();

            
        }

        private void LoadFuturePlanToForm()
        {
            dgvFutureList.Rows.Clear();
            foreach (FuturePlan future in plants.FuturePlans)
                dgvFutureList.Rows.Add(new object[] { future.NamePlan});
        }

        private void tsbFutureAdd_Click(object sender, EventArgs e)
        {
            tsbFutureAdd.Visible = false;
            tsbFutureDelete.Visible = false;

            TstbFutureAdd.Visible = true;
            tsbFutureAddClose.Visible = true;
            TstbFutureAdd.Focus();
        }

        private void tsbFutureAddClose_Click(object sender, EventArgs e)
        {
            tsbFutureAdd.Visible = true;
            tsbFutureDelete.Visible = true;
          
            TstbFutureAdd.Visible = false;
            tsbFutureAddClose.Visible = false;
        }

        private void TstbFutureAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                plants.FuturePlans.Add(new FuturePlan(TstbFutureAdd.Text));
                LoadFuturePlanToForm();
                tsbFutureAddClose_Click(sender, new EventArgs());
            }
        }

        private void tsbFutureDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = dgvFutureList.CurrentCell;
                if (MessageBox.Show($"Вы точно хотите удалить план {cell.Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FuturePlan plan = plants.FuturePlans.Where(p => p.NamePlan == cell.Value.ToString()).First();
                    plants.FuturePlans.Remove(plan);
                    LoadFuturePlanToForm();                   
                }
            }
            catch { }
        }

        private void dgvFutureList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                if(e.StateChanged ==DataGridViewElementStates.Selected)
                {
                    FuturePlan plan = plants.FuturePlans.Where(p => p.NamePlan == e.Cell.Value.ToString()).First();
                    if (e.Cell.Selected)
                    {
                        setFutureVisible(true);
                        dtpFutureRealiseDate.Value = plan.DateRealise;
                        dgvFuturePunkts.Rows.Clear();

                        foreach (PunktOfPlan punkt in plan.punktOfPlans)
                            dgvFuturePunkts.Rows.Add(new object[] {punkt.NumberPunkt, punkt.NamePunkt, punkt.CompleteFlag });
                        dgvFuturePunkts.Sort(dgvFuturePunkts.Columns[0], ListSortDirection.Ascending);
                    }
                    else
                    {
                        plan.DateRealise = dtpFutureRealiseDate.Value;
                        plan.punktOfPlans.Clear();

                        foreach (DataGridViewRow row in dgvFuturePunkts.Rows)
                            plan.punktOfPlans.Add(new PunktOfPlan( Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString(), Convert.ToBoolean( row.Cells[2].Value)));


                    }

                }

            }
            catch { }
        }

        private void tspFutureAddPunks_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Добавить в план еще пункт?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                dgvFuturePunkts.Rows.Add();
        }

        private void tsbFutureDelPunkt_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dgvFuturePunkts.CurrentCell;
            if (cell!= null)
            if (MessageBox.Show($"Удалить пунк плана #{dgvFuturePunkts.Rows[cell.RowIndex].Cells[0].Value.ToString()}?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                dgvFuturePunkts.Rows.RemoveAt(cell.RowIndex);
        }

        private void tsbTargetAdd_Click(object sender, EventArgs e)
        {
            tsbTargetAdd.Visible = false;
            tsbTargetDelete.Visible = false;

            tslTargetAdd.Visible = true;
            tstbTargetName.Visible = true;
            tsbTargetCanselAdd.Visible = true;
        }

        private void tsbTargetCanselAdd_Click(object sender, EventArgs e)
        {
            tsbTargetAdd.Visible = true;
            tsbTargetDelete.Visible = true;

            tslTargetAdd.Visible = false;
            tstbTargetName.Visible = false;
            tsbTargetCanselAdd.Visible = false;
        }

        private void LoadTargetsToForm()
        {
            dgvTargetList.Rows.Clear();
            foreach (Target target in plants.Targets)
                dgvTargetList.Rows.Add( new object[] {target.NameTarget});
        }

        private void tstbTargetName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData ==Keys.Enter)
            {
                plants.Targets.Add(new Target(tstbTargetName.Text));
                LoadTargetsToForm();
                tsbTargetCanselAdd_Click(sender, new EventArgs());
            }
        }

        private void tsbTargetDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = dgvTargetList.CurrentCell;
                if (MessageBox.Show($"Вы точно хотите удалить цель {cell.Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Target target = plants.Targets.Where(p => p.NameTarget == cell.Value.ToString()).First();
                    plants.Targets.Remove(target);
                    LoadTargetsToForm();
                }
            }
            catch { }
        }

        private void dgvTargetList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged == DataGridViewElementStates.Selected)
                {
                    Target target = plants.Targets.Where(t => t.NameTarget == e.Cell.Value.ToString()).First();
                    if (e.Cell.Selected)
                    {
                        setTargetVisible(true);
                        dtpTargetDateStart.Value = target.DateStartRealise;
                        dtpTargetDateEnd.Value = target.DateEndRealise;
                        rtbTargetDescription.Text = target.DescriptionTarget;
                        checkTargetCompleteFlag.Checked = target.CompleteFlag;

                        dgvTargetSteps.Rows.Clear();
                        foreach (Step step in target.Steps)
                            dgvTargetSteps.Rows.Add(new object[] { step.NumberStep, step.NameStep, step.DescriptionStep, step.CompleteFlag });

                        dgvTargetSteps.Sort(dgvTargetSteps.Columns[0], ListSortDirection.Ascending);

                    }
                    else
                    {
                        target.DateStartRealise = dtpTargetDateStart.Value;
                        target.DateEndRealise = dtpTargetDateEnd.Value;
                        target.DescriptionTarget = rtbTargetDescription.Text;
                        target.CompleteFlag = checkTargetCompleteFlag.Checked;

                        target.Steps.Clear();
                        try
                        {
                            foreach (DataGridViewRow row in dgvTargetSteps.Rows)
                                target.Steps.Add(new Step(Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), Convert.ToBoolean(row.Cells[3].Value)  ));
                        }
                        catch (Exception ex) { MessageBox.Show(ex.Message); }


                    }
                }
            }
            catch { }
        }

        private void tsbTargetStepAdd_Click(object sender, EventArgs e)
        {
            dgvTargetSteps.Rows.Add();
        }

        private void tspTargetStepDelete_Click(object sender, EventArgs e)
        {
            dgvTargetSteps.Rows.Remove( dgvTargetSteps.Rows[dgvTargetSteps.CurrentCell.RowIndex] );
        }


        private void LoadShoppingTree()
        {
            tvShoppingList.Nodes.Clear();
            foreach (ShoppingList shopping in plants.ShoppingLists)
            {
                if (shopping.CompleteFlag) 
                    tvShoppingList.Nodes.Add(shopping.NameItem, shopping.NameItem, 0);
                else tvShoppingList.Nodes.Add(shopping.NameItem, shopping.NameItem, 1);
            }
        }

        private void tbShoppingCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }

        }

        private void tsbShopAdd_Click(object sender, EventArgs e)
        {
            tsbShopAdd.Visible = false;
            tsbShopDelete.Visible = false;

            tsbShopCanselAdd.Visible = true;
            tslShopAdd.Visible = true;
            tstbShopAdd.Visible = true;
            tstbShopAdd.Text = "";
        }

        private void tsbShopCanselAdd_Click(object sender, EventArgs e)
        {
            tsbShopAdd.Visible = true;
            tsbShopDelete.Visible = true;

            tsbShopCanselAdd.Visible = false;
            tslShopAdd.Visible = false;
            tstbShopAdd.Visible = false;
        }

        private void tstbShopAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                plants.ShoppingLists.Add(new ShoppingList(tstbShopAdd.Text));
                LoadShoppingTree();
                tsbShopCanselAdd_Click(sender, new EventArgs());
            }
        }

        private void tsbShopDelete_Click(object sender, EventArgs e)
        {
            if (CurrentShopping != null)
                if (MessageBox.Show($"Вы точно хотите удалить покупку {CurrentShopping.NameItem}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    plants.ShoppingLists.Remove(CurrentShopping);
                    LoadShoppingTree();
                }
        }

        private void tvShoppingList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                CurrentShopping = plants.ShoppingLists.Where(s => s.NameItem == e.Node.Name).First();
                tbShoppingCost.Text = CurrentShopping.Cost.ToString();
                checkShoppingFlag.Checked = CurrentShopping.CompleteFlag;
                rtbShoppingDescription.Text = CurrentShopping.Description;
                setShoppingVisible(true);
            }
            catch { }
        }

        private void tbShoppingCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentShopping.Cost = Convert.ToDouble(tbShoppingCost.Text);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void checkShoppingFlag_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentShopping.CompleteFlag = checkShoppingFlag.Checked;
            }
            catch { }
        }

        private void rtbShoppingDescription_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentShopping.Description = rtbShoppingDescription.Text;
            }
            catch { }
        }

        private void tsbProjectAdd_Click(object sender, EventArgs e)
        {
            tsbProjectAdd.Visible = false;
            tsbProjectDelete.Visible = false;

            tsbProjectCanselAdd.Visible = true;
            tslProjectAdd.Visible = true;
            tstbProjectName.Visible = true;

            tstbProjectName.Focus();
            tstbProjectName.Text = "";
        }

        private void tsbProjectCanselAdd_Click(object sender, EventArgs e)
        {
            tsbProjectAdd.Visible = true;
            tsbProjectDelete.Visible = true;

            tsbProjectCanselAdd.Visible = false;
            tslProjectAdd.Visible = false;
            tstbProjectName.Visible = false;
        }


        private void LoadProjectList()
        {
            dgvProgectsList.Rows.Clear();
            foreach (Project project in plants.Projects)
                dgvProgectsList.Rows.Add(new object[] {project.NameProject });
        }

        private void tstbProjectName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                plants.Projects.Add(new Project(tstbProjectName.Text));
                LoadProjectList();
                tsbProjectCanselAdd_Click(sender, new EventArgs());
            }
        }

        private void tsbProjectDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = dgvProgectsList.CurrentCell;
                if (MessageBox.Show($"Вы точно хотите удалить проект {cell.Value.ToString()}?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Project project = plants.Projects.Where(p => p.NameProject == cell.Value.ToString()).First();
                    plants.Projects.Remove(project);
                    LoadProjectList();
                }
            }
            catch { }
        }

        private void tsbProjectStepAdd_Click(object sender, EventArgs e)
        {
            dgvProgectSteps.Rows.Add(new object[] { dgvProgectSteps.Rows.Count+1, "","", false} );
        }

        private void tsbProjectStepDelete_Click(object sender, EventArgs e)
        {
            if (dgvProgectSteps.CurrentCell !=  null)
            {
                dgvProgectSteps.Rows.RemoveAt(dgvProgectSteps.CurrentCell.RowIndex);
            }
        }

        private void dgvProgectsList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            try
            {
                switch (e.StateChanged)
                {
                    case DataGridViewElementStates.Selected:
                        Project project = plants.Projects.Where(p => p.NameProject == e.Cell.Value.ToString()).First();
                        if(e.Cell.Selected)
                        {
                            setProjectVisible(true);
                            dtpProjectDate.Value = project.DateStart;
                            rtbProjectDescription.Text = project.Description;
                            dgvProgectSteps.Rows.Clear();

                            foreach (ProjectStep step in project.ProjectSteps)
                                dgvProgectSteps.Rows.Add(new object[] {step.NumberStep, step.NameStep, step.Description, step.CombleteFlag });
                            dgvProgectSteps.Sort(dgvProgectSteps.Columns[0], ListSortDirection.Ascending);
                        }
                        else
                        {
                            project.DateStart = dtpProjectDate.Value;
                            project.Description = rtbProjectDescription.Text;
                            project.ProjectSteps.Clear();
                            foreach (DataGridViewRow row in dgvProgectSteps.Rows)
                                project.ProjectSteps.Add(new ProjectStep( Convert.ToInt32(row.Cells[0].Value), row.Cells[1].Value.ToString(),
                                    row.Cells[2].Value.ToString(), Convert.ToBoolean(row.Cells[3].Value)));
                        }

                        break;
                }
            }
            catch { }
        }

        private void FormPlans_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataGridViewCell cell in dgvFutureList.SelectedCells)
                cell.Selected = false;
            foreach (DataGridViewCell cell in dgvProgectsList.SelectedCells)
                cell.Selected = false;
            foreach (DataGridViewCell cell in dgvTargetList.SelectedCells)
                cell.Selected = false;
            
        }

        private void setFutureVisible(bool visibled)
        {
            gbFuturePunkts.Visible = visibled;
            gbFutureRealise.Visible = visibled;
        }

        private void setTargetVisible(bool visibled)
        {
            gbTargetDateEnd.Visible = visibled;
            gbTargetDateStart.Visible = visibled;
            gbTargetDescription.Visible = visibled;
            gbTargetSteps.Visible = visibled;
            pTargetComplete.Visible = visibled;
        }

        private void setShoppingVisible(bool visibled)
        {
            gbShoppingCost.Visible = visibled;
            gbShoppingDescription.Visible = visibled;
            gbShoppingFlag.Visible = visibled;
        }

        private void setProjectVisible(bool visibled)
        {
            gbProgectDate.Visible = visibled;
            gbProgectDescription.Visible = visibled;
            gbProjectSteps.Visible = visibled;
        }
    }
}
