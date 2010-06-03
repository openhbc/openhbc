using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Interfaces;
using OpenHBC.Security;

namespace OpenHBC
{
    public partial class PatientSummary : UserControl, ISecureableUI
    {
        Patient patient;
        Login parent;
        public PatientSummary(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
            secure();
        }
        public PatientSummary(Patient patient, Login p)
        {
            parent = p;
            InitializeComponent();
            this.patient = patient;
            //PopulateDataGridView();
            secure();
        }

        public void secure()
        {
            if (Entity.CurrentUser.UserRole.HasRight(Rights.DATA_ENTRY.ToString()))
            {
                gbxBioSummary.Enabled = true;
                btnEdit.Enabled = true;
                btnNewVisit.Enabled = true;
                btnEditVisit.Enabled = true;
                btnDeleteVisit.Enabled = true;
                btnCancel.Enabled = true;
                
            }
        }

        private void PatientSummary_Load(object sender, EventArgs e)
        {
            try
            {
                txtFirstName.Text = patient.FirstName;
                txtSurname.Text = patient.Surname;
                txtMiddleName.Text = patient.MiddleName;
                txtDateofbirth.Text = Entity.formartDateForMySQL(patient.DateOfBirth);//.Date.ToString("dd-MMMM-yy");
                txtGender.Text = patient.Sex;

                PopulateDataGridView();
            }catch(Exception ex)
            {
                parent.SetUserControl(new HomeHbC(parent));
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new RegPatient(Entity.CurrentPatient));
        }

        private void btnNewVisit_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new HbcVisit(parent));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Entity.CurrentPatient = null;
            parent.SetUserControl(new HomeHbC(parent));
        }

        private void PopulateDataGridView()
        {
            
            dataGridView1.Rows.Clear();
            if (Entity.CurrentPatient.Visits != null)
            {
                foreach (Object s in Entity.CurrentPatient.Visits)
                {
                    if (s == null) break;
                    Visit v = (Visit) s;
                    dataGridView1.Rows.Add(
                        new string[] {Entity.formartDateForMySQL(v.VisitDate), v.VisitName, v.UserId.ToString(), v.VisitId.ToString()});
                }
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView array = (DataGridView)sender;
            if(e.RowIndex==-1) return;
            CareVisit vis = getSelectedVisit(e);
            parent.SetUserControl(new HbcVisit(vis,parent));

        }

        private CareVisit getSelectedVisit(DataGridViewCellEventArgs e)
        {
            DataGridViewRow s = dataGridView1.Rows[e.RowIndex];
            DataGridViewCell t = s.Cells[3];
            int id = Int32.Parse(t.Value.ToString());

            //MysqlDbUtility test = new MysqlDbUtility();

            //this.btnBack.Text = test.getValue();
            CareVisit vis = getSelectedVisit(id);
            return vis;
        }

        private CareVisit getSelectedVisit(int rowId)
        {
            int tmpIndex = -1;
            bool temp = false;
            CareVisit vis = new CareVisit();
            foreach (object v in Entity.CurrentPatient.Visits)
            {
                tmpIndex++;

                if(((CareVisit)v).VisitId == rowId)
                {
                    temp = true;
                    vis = (CareVisit)v;
                    break;

                }
                
            }
            return vis;
        }

        private void visitsGrid_SelectionChanged(object sender, EventArgs e)
        {
            int i = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            txtClinicalFindings.Clear();
            txtRemarks.Clear();
            txtTreatment.Clear();
            CareVisit vis = getSelectedVisit(i);
            txtClinicalFindings.Text = vis.ClinicalFindings;
            txtRemarks.Text = vis.Remarks;
            txtTreatment.Text = vis.Treatment;
        }

        private void btnEditVisit_Click(object sender, EventArgs e)
        {
            try
            {
                int i = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                CareVisit vis = getSelectedVisit(i);
                parent.SetUserControl(new HbcVisit(vis,parent));
            }
            catch(Exception exc)
            {
                
            }
        }

        private void btnDeleteVisit_Click(object sender, EventArgs e)
        {
            if(Entity.CurrentPatient.Visits.Count==0)
            {
                return;
            }
            
            int i = Int32.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            CareVisit vis = getSelectedVisit(i);
            
            if (Entity.CurrentPatient.Visits.Contains(vis))
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to delete this Visit?", "Delete Visit WARNING", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if(result==DialogResult.Yes)
                {
                    Entity.deleteVisit(vis.VisitId, Entity.CurrentPatient.PatientId);
                    Entity.CurrentPatient.Visits.Remove(vis);
                }
            }
            PopulateDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
