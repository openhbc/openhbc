using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OpenHBC
{
    public partial class DateEntries : UserControl
    {
        Login parent;
        string reportNameSelected = "";

        public DateEntries(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        //Gets the name of the report from the text property of the button that has been pressed
        public DateEntries(string reportname, Login p)
        {
            parent = p;
            InitializeComponent();
            reportNameSelected = reportname;
        }

        private void dtEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRunReport_Click(object sender, EventArgs e)
        {
            ReportPainManagement.StartDate = dtStartDate.Value;
            ReportPainManagement.EndDate = dtEndDate.Value;
            
            parent.SetUserControl(new ReportPainManagement(reportNameSelected,parent));
        }

        private void DateEntries_Load(object sender, EventArgs e)
        {
           // reportNameSelected = ((Button)sender).Name;
        }

        private void btnBackToReportList_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new ReportsBrowser(parent));
        }
    }
}
