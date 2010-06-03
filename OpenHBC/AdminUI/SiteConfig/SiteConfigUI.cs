using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OpenHBC.AdminUI.SiteConfig
{
    public partial class SiteConfigUI : UserControl
    {
        Login parent;
        private Concepts regConcepts = new Concepts();
        public SiteConfigUI(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
            InitialiseCombos();
        }

        private void InitialiseCombos()
        {
            //check if the site is already set, then
            //
            cbxSitesName.Items.AddRange(regConcepts.Sites);
        }

        private void SiteConfigUI_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LocationProvider.LocationProvider.SetCurrentSiteDetails(cbxSitesName.SelectedItem.ToString());
            parent.SetUserControl(new Admin(parent));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new Admin(parent));
        }
    }
}
