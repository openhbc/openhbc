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
    public partial class ReportPainManagement : UserControl
    {
        Login parent;
        ReportDocument reportdoc = new ReportDocument();
        MysqlDbUtility db = new MysqlDbUtility();
        string reportSql;
        DataSet reportDataSet;
        string reportPath;

        private static DateTime _startDate;
        private static DateTime _endDate;


        public ReportPainManagement(string reportName, Login parent)
        {
            this.parent = parent;
            InitializeComponent();

            //Get text from the text property of the buttons that have been pressed
            switch (reportName) 
            {
                case "Pain Management": CreatePainManagementReport(); break;
                case "All Patients": CreateReportAllPatients(); break;
                case "Female Patients": CreateReportAllFemalePatients() ; break;
                case "Male Patients": CreateReportAllMalePatients() ; break;
                case "Patients Under 15 yrs": CreateReportPatientsUnder15() ; break;
                case "Confirmed HIV+": CreateReportConfirmedStatus() ; break;
                case "Under 15 yrs Confirmed HIV+": CreateReportConfirmedStatusUnder15() ; break;
                default: MessageBox.Show("There is no implementation for the requested report"); return;
            }
            

            InitialiseAndShowReport();

            //this.crystalReportViewer1.ShowFirstPage(); 
            this.Visible = true;
        }

        public static DateTime StartDate
        {
            set {
                _startDate = value;
            }
        }
        public static DateTime EndDate
        {
            set
            {
                _endDate= value;
            }
        }

        private void InitialiseAndShowReport()
        {
            reportDataSet = db.getDataSet(reportSql);
            reportDataSet.Tables[0].TableName = "Command";
            int count = reportDataSet.Tables[0].Rows.Count;
            string printer = reportdoc.PrintOptions.PrinterName;

            reportdoc.Load(reportPath);
            reportdoc.SetDataSource(reportDataSet);
            //crystalReportViewer1.ReportSource = Application.StartupPath + "\\patientList.rpt";
            crystalReportViewer1.ReportSource = reportdoc;
            crystalReportViewer1.ShowFirstPage();
            this.Show();
        }

        private void CreatePainManagementReport()
        {
            string format = "yyyy-MM-dd";
            reportSql = string.Format("SELECT r.patientid, r.firstname compid, r.surname compname from registration r, monthly_care_visit m where m.receivedpainmanagement = 1 and m.patientid = r.patientid and m.visit_date between '{0}' and '{1}'", _startDate.ToString(format), _endDate.ToString(format));
            reportPath = Application.StartupPath + "\\rpt-pmgt_patients.rpt";
            
        }

        private void CreateReportAllPatients()
        {
            string format1 = "yyyy-MM-dd";
            //r.`patientID` = m.`patientID` and 
            reportSql = string.Format("SELECT r.`patientID`, r.`firstname`, r.`middle_name`, r.`surname`, r.`Sex`,  r.`dateofbirth`, r.`nrc_number` FROM registration r where r.`assesment_date` between '{0}' and '{1}'", _startDate.ToString(format1), _endDate.ToString(format1));
            reportPath = Application.StartupPath + "\\rpt-all_patients.rpt";

        }
        private void CreateReportAllMalePatients()
        {
            string format = "yyyy-MM-dd";
            reportSql = string.Format("SELECT r.`patientID`, r.`firstname`, r.`middle_name`, r.`surname`, r.`Sex`, r.`dateofbirth`, r.`nrc_number` FROM registration r where r.`Sex`= 'Male' and r.`assesment_date` between '{0}' and '{1}'", _startDate.ToString(format), _endDate.ToString(format));
            reportPath = Application.StartupPath + "\\rpt-all_patients.rpt";

        }
        private void CreateReportAllFemalePatients()
        {
            string format = "yyyy-MM-dd";
            reportSql = string.Format("SELECT r.`patientID`, r.`firstname`, r.`middle_name`, r.`surname`, r.`Sex`,  r.`dateofbirth`, r.`nrc_number` FROM registration r where r.`Sex`= 'Female' and r.`assesment_date` between '{0}' and '{1}'", _startDate.ToString(format), _endDate.ToString(format));
            reportPath = Application.StartupPath + "\\rpt-all_patients.rpt";

        }
        private void CreateReportPatientsUnder15()
        {   //this is for getting the current date current_date-string
            string currentdate_format = "yyyy-MM-dd";
            DateTime mymsg1 = System.DateTime.Now;
            string current_date_string = mymsg1.ToString(currentdate_format);
            
            string format = "yyyy-MM-dd";
            reportSql = string.Format("SELECT r.`patientID`, r.`firstname`, r.`middle_name`, r.`surname`, r.`Sex`,  r.`dateofbirth`, r.`nrc_number` FROM registration r where '" + current_date_string + "' - r.`dateofbirth` is <15 and r.`assesment_date` between '{0}' and '{1}'", _startDate.ToString(format), _endDate.ToString(format));
            reportPath = Application.StartupPath + "\\rpt-all_patients.rpt";

        }
        private void CreateReportConfirmedStatus()
        {
            string format = "yyyy-MM-dd";
            reportSql = string.Format("SELECT r.`patientID`, r.`Sex`,  r.`dateofbirth` FROM registration r , monthly_care_visit m where r.`patientId` = m.`patientId` and m.`confirmedhivstatus`=1 and m.visit_date between '{0}' and '{1}'", _startDate.ToString(format), _endDate.ToString(format));
            reportPath = Application.StartupPath + "\\rpt-all_patients.rpt";

        }
        private void CreateReportConfirmedStatusUnder15()
        {
            string format = "yyyy-MM-dd";
            reportSql = string.Format("SELECT r.`patientID`, r.`Sex`,  r.`dateofbirth` FROM registration r , monthly_care_visit m where r.`patientId` = m.`patientId` and m.`confirmedhivstatus`=1 and r.`dateofbirth`>= '1994-01-01 00:00:00' and m.visit_date between '{0}' and '{1}'", _startDate.ToString(format), _endDate.ToString(format));
            reportPath = Application.StartupPath + "\\rpt-all_patients.rpt";

        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            //string sql = "SELECT r.patientid, r.firstname compid, r.surname compname from registration r, monthly_care_visit m where m.receivedpainmanagement = 1 and m.patientid = r.patientid";
        }


        void PainManagementReport()
        {
           
        }

        private void btnBackToReportList_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new ReportsBrowser(parent));
        }

        private void btnBackToReportList_Click_1(object sender, EventArgs e)
        {
            parent.SetUserControl(new ReportsBrowser(parent));
        }

    }
}
