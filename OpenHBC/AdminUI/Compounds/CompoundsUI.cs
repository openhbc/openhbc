using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Managers;
using OpenHBC.Utilities;

namespace OpenHBC.AdminUI.Compounds
{
    public partial class CompoundsUI : UserControl
    {
        
        public CompoundsUI()
        {
           
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            this.dataGridCompounds.Rows.Clear();
            if (CompoundsMgr.compoundList() != null)
            {
                foreach (string[] s in CompoundsMgr.compoundList())
                {
                    if (s == null) break;
                     dataGridCompounds.Rows.Add(
                        new string[] { s[0], s[1], s[2], s[3] });
                }
            }

        }

        private void btnAddCompound_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new AddCompoundUI());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new Admin());
        }

        private void btnDeleteCompound_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to delete this Compound?", "Delete User WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                int id = Int32.Parse(DataGridUtility.GetValue(dataGridCompounds.CurrentRow, 3).ToString());

                CompoundsMgr.deleteCompound(id.ToString());
                Login.refreshPanel(new CompoundsUI());
            }
        }

        private void btnEditCompound_Click(object sender, EventArgs e)
        {
            DataGridView da = dataGridCompounds;
            DataGridViewRow darrow = da.CurrentRow;
            //DataGridViewCell cell = darrow.Cells;
            string tmp = DataGridUtility.GetValue(darrow, 3).ToString();
            int id = Int32.Parse(tmp);
            //CompoundsMgr.EditCompound(id, DataGridUtility.GetValue(dataGridCompounds.CurrentRow, 0).ToString(),
            //                           DataGridUtility.GetValue(dataGridCompounds.CurrentRow, 1).ToString(),
            //                           DataGridUtility.GetValue(dataGridCompounds.CurrentRow, 2).ToString());

            string Comments =    DataGridUtility.GetValue(dataGridCompounds.CurrentRow, 2).ToString();
            string SectionName = DataGridUtility.GetValue(dataGridCompounds.CurrentRow, 1).ToString();
            string CompundName = DataGridUtility.GetValue(dataGridCompounds.CurrentRow, 0).ToString();
            Login.refreshPanel(new AddCompoundUI(id , CompundName,SectionName, Comments));
        }

        private void dataGridCompounds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
