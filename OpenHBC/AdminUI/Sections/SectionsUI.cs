using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Managers;
using OpenHBC.Utilities;

namespace OpenHBC.AdminUI.Sections
{
    public partial class SectionsUI : UserControl
    {
        public SectionsUI()
        {
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            this.dataGridSections.Rows.Clear();
            if (SectionsMgr.sectionList() != null)
            {
                foreach (string[] s in SectionsMgr.sectionList())
                {
                    if (s == null) break;
                    dataGridSections.Rows.Add(
                        new string[] { s[0], s[3], s[1], s[2] });
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new AddSectionUI());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new Admin());
        }

        private void btnDeleteSection_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to delete this SECTION?", "Delete User WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                int id = Int32.Parse(DataGridUtility.GetValue(dataGridSections.CurrentRow, 3).ToString());

                SectionsMgr.deleteSection(id.ToString());
                Login.refreshPanel(new SectionsUI());
            }
        }

        private void btnEditSection_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(DataGridUtility.GetValue(dataGridSections.CurrentRow, 3).ToString());
            /*SectionsMgr.EditSection(id, DataGridUtility.GetValue(dataGridSections.CurrentRow, 0).ToString(),
                                    DataGridUtility.GetValue(dataGridSections.CurrentRow, 1).ToString(),
                                    DataGridUtility.GetValue(dataGridSections.CurrentRow, 2).ToString());
            */
            string Comments = DataGridUtility.GetValue(dataGridSections.CurrentRow, 2).ToString(); //1 0 is sectname
            string SiteName = DataGridUtility.GetValue(dataGridSections.CurrentRow, 1).ToString(); //2 1 is sitename
            string SectionName = DataGridUtility.GetValue(dataGridSections.CurrentRow, 0).ToString();   //2 is comment


            Login.refreshPanel(new AddSectionUI(id, SectionName, Comments, SiteName));
        }

        
    }
}
