using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.AdminUI;
using OpenHBC.Interfaces;
using OpenHBC.Security;

namespace OpenHBC
{
    public partial class HomeHbC : UserControl,ISecureableUI
    {
        Login parent;
        public HomeHbC(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
            secure();
        }

        public void secure()
        {
            if(!Entity.CurrentUser.UserRole.HasRight(Rights.DO_EXPORT.ToString())) 
            {
                 btnExport.Enabled = false;
            }

            if(!Entity.CurrentUser.UserRole.HasRight(Rights.DO_IMPORT.ToString()))
            {
                btnImport.Enabled = false;
            }

            if(!Entity.CurrentUser.UserRole.HasRight(Rights.VIEW_REPORTS.ToString()))
            {
                btnReport.Enabled = false;
            }
            
            if (Entity.CurrentUser.UserRole.HasRight(Rights.APP_CONFIG.ToString())||Entity.CurrentUser.UserRole.HasRight(Rights.CREATE_ROLE.ToString())||Entity.CurrentUser.UserRole.HasRight(Rights.CREATE_USER.ToString())||Entity.CurrentUser.UserRole.HasRight(Rights.DELETE_ROLE.ToString())||Entity.CurrentUser.UserRole.HasRight(Rights.DELETE_USER.ToString()))
            {
                btnAdmin.Enabled = true;
               
            }

            if (Entity.CurrentUser.UserRole.HasRight(Rights.DATA_ENTRY.ToString()))
            {
                txtFirstName.Enabled = true;
                txtSurname.Enabled = true;
                txtId.Enabled = true;
                btnSearch.Enabled = true;
                btnNewPatient.Enabled = true;
            }
            if(Entity.CurrentUser.UserRole.HasRight(Rights.DO_SEARCH.ToString()))
            {
                btnSearch.Enabled = true;
                txtFirstName.Enabled = true;
                txtSurname.Enabled = true;
                txtId.Enabled = true;
            }

            


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PatientSearchList pat = new PatientSearchList(txtSurname.Text,txtFirstName.Text,txtId.Text,parent);
            parent.SetUserControl(pat);
            
        }

        private void HomeHbC_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                btnSearch.PerformClick();
                e.Handled = true;
            }
            
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new RegPatient(parent));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MysqlDbUtility db = new MysqlDbUtility();
            DataSet1 ds = db.GetAllPatients();
            parent.SetUserControl(new ReportsBrowser(parent));
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new Admin(parent));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Entity.ClearCurrentState();

            parent.SetUserControl(new MainLogin(parent));
        }
    }
}
