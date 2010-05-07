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
    public partial class HbcVisit : UserControl,ISecureableUI
    {
        private CareVisit visit;
        public HbcVisit()
        {
            InitializeComponent();
            secure();
        }

        public HbcVisit(CareVisit cv)
        {
            InitializeComponent();
            this.visit = cv;
            secure();
            
        }

        public void secure()
        {
            if (Entity.CurrentUser.UserRole.HasRight(Rights.DATA_ENTRY.ToString()))
            {
                txtClinicalFindings.Enabled = true;
                txtComments.Enabled = true;
                txtDiagnosis.Enabled = true;
                btnSave.Enabled = true;
                dtpVisitDate.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new PatientSummary(Entity.CurrentPatient));
        }

        private void HbcVisit_Load(object sender, EventArgs e)
        {
            if(visit != null)
            {
                dtpVisitDate.Text = visit.VisitDate.Date.ToString();
                txtClinicalFindings.Text = visit.ClinicalFindings.ToString();
                txtDiagnosis.Text = visit.Treatment.ToString();
                
                txtComments.Text = visit.Remarks;

                if(visit.ConfirmedHivStatus=="1")
                {
                    chkbxConfirmedPositive.Checked = true;
                }

                
                if (visit.ReceivedCounselling == "1")
                {
                    chkbxCounseled.Checked = true;
                } 

                if(visit.IsOnART == "1")
                {
                    chkbxOnArt.Checked = true;
                }

                if(visit.IsAdhering == "1")
                {
                    rdIsAdheringYes.Checked = true;
                }
                else if(visit.IsAdhering == "0")
                {
                    rdIsAdheringNo.Checked = true;
                }

                if(visit.ReceivedSupplement == "1")
                {
                    chkbxReceivedSupp.Checked = true;
                    cboNameOfSuppliment.Text = visit.NameOfReceivedSupplement;
                }

                if (visit.DischargeOrTranfer == "1")
                {
                    txtTransferedto.Text = visit.TransferedTo;
                }
                if(visit.ReceivedPainManagement == "1")
                {
                    chkbxPainMgmnt.Checked = true;
                }
                if(visit.DischargeOrTranfer == "0")
                {
                    rdDischarge.Checked = true;
                }
                else if(visit.DischargeOrTranfer == "1")
                {
                    rdTransfer.Checked = true;
                }

                txtTransferedto.Text = visit.TransferedTo;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(visit==null)
            {
              visit = new CareVisit();  
            
              visit.VisitId = Entity.generateVisitId(visit.VisitType);
            }
            visit.PatientId = Entity.CurrentPatient.PatientId;
            visit.VisitDate = dtpVisitDate.Value;
            visit.UserId = Entity.CurrentUserId;
            visit.SiteId = Entity.CurrentSiteId;
            visit.ClinicalFindings = txtClinicalFindings.Text;
            
            visit.Treatment = txtDiagnosis.Text;
            visit.Remarks = txtComments.Text;

            if (chkbxConfirmedPositive.Checked)
            {
                visit.ConfirmedHivStatus = "1";
            }
            else
            {
                visit.ConfirmedHivStatus = "0";
            }

            if (chkbxOnArt.Checked)
            {
                visit.IsOnART = "1";
            }
            else
            {
                visit.IsOnART = "0";
            }
            if(rdIsAdheringNo.Checked)
            {
                visit.IsAdhering = "0";
            }
            else if(rdIsAdheringYes.Checked)
            {
                visit.IsAdhering = "1";
            }
            else
            {
                visit.IsAdhering = "0";
            }
            if (chkbxReceivedSupp.Checked)
            {
                visit.ReceivedSupplement = "1";
            }
            else
            {
                visit.ReceivedSupplement = null;
            }
            if (chkbxPainMgmnt.Checked)
            {
                visit.ReceivedPainManagement = "1";
            }
            else
            {
                visit.ReceivedPainManagement = "0";
            }
            if (rdDischarge.Checked)
            {
                visit.DischargeOrTranfer = "0";
            }
            else if (rdTransfer.Checked)
            {
                visit.DischargeOrTranfer = "1";
            }
            else
            {
                visit.DischargeOrTranfer = null;
            }
            if (chkbxCounseled.Checked)
            {
                visit.ReceivedCounselling = "1";
            }
            else
            {
                visit.ReceivedCounselling = "0";
            }

            visit.NameOfReceivedSupplement = cboNameOfSuppliment.Text;
            visit.TransferedTo = txtTransferedto.Text;
            



            Entity.saveVisit(visit);
            bool temp = false;
            int tmpIndex = -1;
            foreach (object v in Entity.CurrentPatient.Visits)
            {
                tmpIndex++;

                if(((Visit)v).VisitId == visit.VisitId)
                {
                    temp = true;
                    break;

                }
                
            }
            if (temp)
            {
                Entity.CurrentPatient.Visits.RemoveAt(tmpIndex);
                Entity.CurrentPatient.Visits.Add(visit);
            }
            else
            {
                Entity.CurrentPatient.Visits.Add(visit);
            }

            Login.refreshPanel(new PatientSummary(Entity.CurrentPatient));
        }

        private void chkbxConfirmedHIVStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxConfirmedPositive.Checked == true)
            {
                chkbxCounseled.Enabled = true;
                chkbxOnArt.Enabled = true;
                gpbxIsClientAdhering.Enabled = true;
                chkbxConfirmedNegative.Checked = false;
                
            }
            else
            {
                chkbxCounseled.Enabled = false;
                chkbxCounseled.Checked = false;
                chkbxOnArt.Enabled = false;
                chkbxOnArt.Checked = false;                
                gpbxIsClientAdhering.Enabled = false;
                rdIsAdheringNo.Checked = false;
                rdIsAdheringYes.Checked = false;
                
                
            }
        }

        private void chkbxConfirmedNegative_CheckedChanged(object sender, EventArgs e)
        {
            //if (chkbxConfirmedNegative.Checked == true)
            //{
                //chkbxConfirmedHIVStatus.Enabled = false;
                chkbxConfirmedPositive.Checked = false;
            //    rdIsAdheringYes.Checked = false;
            //    chkbxOnArt.Checked = false;
            //    chkbxCounseled.Checked = false;
            ////}
            //else
            //{
            //    chkbxConfirmedHIVStatus.Enabled = true;
            //}
        }
        
        private void chkbxPainMgmnt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxPainMgmnt.Checked==true)
            {
                cboLevel.Enabled = true;
            }
            else
            {
                cboLevel.SelectedIndex = 0;
                cboLevel.Enabled = false;
               
            }
        }

        private void cboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = "";
            selected = cboLevel.SelectedItem.ToString();
            if (selected == "3")
            {
                txtReferPMgt.Enabled = true;
            }
            else
            {
                txtReferPMgt.Enabled = false;
                txtReferPMgt.Clear();
            }
        }

        private void chkbxDied_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbxDied.Checked == true)
            {
                dtpDied.Enabled = true;
            }
            else
            {
                dtpDied.Enabled = false;
            }
        }

        private void chkbxOnArt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxOnArt.Checked == true)
            {
                rdIsAdheringYes.Checked = true;
                chkbxAdheranceCounselling.Enabled = true;
            }
            else
            {
                rdIsAdheringYes.Checked = false;
                rdIsAdheringNo.Checked = false;
                chkbxAdheranceCounselling.Enabled = false;
            }
        }

        private void rdDischarge_CheckedChanged(object sender, EventArgs e)
        {
            txtTransferedto.Enabled = false;
            txtRefer.Enabled = false;
        }

        
    }
}
