using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.AdminUI.Sections;
using OpenHBC.AdminUI.Compounds;
using OpenHBC.AdminUI.SiteConfig;

namespace OpenHBC.AdminUI
{
    public partial class Admin : UserControl
    {
        Login parent;
        public Admin(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Entity.CurrentPatient = null;
            parent.SetUserControl(new HomeHbC(parent));
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new SecurityMgmtUI(parent));
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new SectionsUI(parent));
        }

        private void btnCompounds_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new CompoundsUI(parent));
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new SiteConfigUI(parent));
        }
    }
}
