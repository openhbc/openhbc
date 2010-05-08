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
        public ReportsBrowser()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Entity.CurrentPatient = null;
            Login.refreshPanel(new HomeHbC());
        }

       

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string btnName = ((Button)sender).Text;
            Login.refreshPanel(new DateEntries(btnName));
            //Changed this to allow for some user interaction (for now just selecting the date)
            //Login.refreshPanel(new ReportPainManagement(btnName));
        }
        
    }
}
