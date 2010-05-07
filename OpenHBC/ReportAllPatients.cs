using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace OpenHBC
{
    public partial class ReportAllPatients : UserControl
    {
        public ReportAllPatients()
        {
            MysqlDbUtility db = new MysqlDbUtility();
            InitializeComponent();
            ReportDocument reportdoc = new ReportDocument();
            string sql = "SELECT r.`patientID`, r.`firstname`, r.`middle_name`, r.`surname`, r.`Sex`, r.`dateofbirth`, r.`nrc_number` FROM registration r;";
            DataSet s = db.getDataSet(sql);
            s.Tables[0].TableName = "Command";
            int count = s.Tables[0].Rows.Count;
            string printer = reportdoc.PrintOptions.PrinterName;
           
            reportdoc.Load(Application.StartupPath + "\\rpt-all_patients.rpt");
            reportdoc.SetDataSource(s);
            //crystalReportViewer1.ReportSource = Application.StartupPath + "\\patientList.rpt";
            crystalReportViewer1.ReportSource = reportdoc;
            crystalReportViewer1.ShowFirstPage();
            this.Show();

            //this.crystalReportViewer1.ShowFirstPage(); 
            this.Visible = true;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
