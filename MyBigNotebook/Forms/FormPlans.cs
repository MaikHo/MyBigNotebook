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
        private ClassPlants plants;
        public FormPlans(ClassPlants classPlants)
        {
            InitializeComponent();
            plants = classPlants;
            LoadFuturePlanToForm();
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
    }
}
