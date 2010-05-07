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
        public Admin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Entity.CurrentPatient = null;
            Login.refreshPanel(new HomeHbC());
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new SecurityMgmtUI());
        }

        private void btnSections_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new SectionsUI());
        }

        private void btnCompounds_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new CompoundsUI());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new SiteConfigUI());
        }
    }
}
