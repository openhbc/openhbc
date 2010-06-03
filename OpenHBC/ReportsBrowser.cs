using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting;

namespace OpenHBC
{
    public partial class ReportsBrowser : UserControl
    {
        Login parent;
        public ReportsBrowser(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Entity.CurrentPatient = null;
            parent.SetUserControl(new HomeHbC(parent));
        }

       

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Text;
            parent.SetUserControl(new DateEntries(btnName,parent));
            //Changed this to allow for some user interaction (for now just selecting the date)
            //Login.refreshPanel(new ReportPainManagement(btnName));
        }
        
    }
}
