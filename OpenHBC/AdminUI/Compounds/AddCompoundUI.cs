using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Managers;
using OpenHBC;

namespace OpenHBC.AdminUI.Compounds
{
    public partial class AddCompoundUI : UserControl
    {
        private Concepts regConcepts = new Concepts();
        private LocationProvider.LocationProvider locprov = new OpenHBC.LocationProvider.LocationProvider();
        public AddCompoundUI()
        {
            InitializeComponent();
            cbxParish.Items.AddRange(regConcepts.Sites);

        }

        public AddCompoundUI(int compid, string compname, string sectname, string comments )
        {
            string site = locprov.GetSiteFromSectName(sectname);

            InitializeComponent();
            cbxParish.Items.Clear();
            cbxParish.Items.AddRange(regConcepts.Sites);

            cbxParish.SelectedItem = site;


            string[][] strDistricts = locprov.GetSections(site);

            cbxSection.Items.Clear();
            if (strDistricts != null)
            {
                foreach (string[] s in strDistricts)
                {
                    cbxSection.Items.Add(s[1]);
                }
            }

            cbxSection.SelectedItem = sectname;

            txtComments.Text = comments;

            txtCompoundName.Text = compname;

            lblCompoundId.Text = compid.ToString();





            
        }

        private void EnableFields(bool enable)
        {
            cbxSection.Enabled = true;
            txtCompoundName.Enabled = true;
            txtComments.Enabled = true;
        }

        private void btnSaveCompound_Click(object sender, EventArgs e)
        {
            if (lblCompoundId.Text.Equals(""))
            {
                CompoundsMgr.AddNewCompound(txtCompoundName.Text, cbxSection.Text , txtComments.Text);
            }
            else
            {
                CompoundsMgr.EditCompound(Int32.Parse(lblCompoundId.Text), txtCompoundName.Text, cbxSection.Text ,txtComments.Text);
            }

            Login.refreshPanel(new CompoundsUI());
        }

        private void AddCompoundUI_Load(object sender, EventArgs e)
        {

        }

        private void cbxParish_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbxParish.SelectedItem.ToString();

            string[][] strDistricts = locprov.GetSections(selected);

            cbxSection.Items.Clear();
            if (strDistricts != null)
            {
                foreach (string[] s in strDistricts)
                {
                    cbxSection.Items.Add(s[1]);
                }
            }
            //cbxSection.Items.AddRange(strDistricts);

            cbxSection.Enabled = true;
        }

        private void cbxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCompoundName.Enabled = true;
            txtComments.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new CompoundsUI());
        }
    }
}
