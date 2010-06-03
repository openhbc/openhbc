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
        Login parent;
        bool hivPositive = false;
        bool tbPositive = false;
        public HbcVisit(Login p)
        {
            parent = p;
            InitializeComponent();
            secure();
            patientNameLbl.Text = Entity.CurrentPatient.FirstName.ToUpper() + " " + Entity.CurrentPatient.Surname.ToUpper();
        }

        public HbcVisit(CareVisit cv, Login p)
        {
            parent = p;
            InitializeComponent();
            this.visit = cv;
            secure();
            patientNameLbl.Text = Entity.CurrentPatient.FirstName.ToUpper() + " " + Entity.CurrentPatient.Surname.ToUpper();
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
            parent.SetUserControl(new PatientSummary(Entity.CurrentPatient, parent));
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
                    onARTStatus.Text = visit.OnARTStatus;
                }
                if(visit.IsAdhering == "1")
                {
                    rdIsAdheringYes.Checked = true;
                }
                else if(visit.IsAdhering == "0")
                {
                    rdIsAdheringNo.Checked = true;
                }


                #region LOAD TB DATA

                if (visit.TBStatus == "1")
                {
                    tbConfirmedChkBox.Checked = true;
                    if (visit.HasTBCounselling == 1)
                    {
                        tbCounselChkBox.Checked = true;
                        if (visit.AdhereingToTBCounselling == 1)
                            tbAdherenceChkBox.Checked = true;
                        else
                            tbAdherenceChkBox.Checked = false;
                    }
                    else
                        tbCounselChkBox.Checked = false;

                    if (visit.IsOnDOTS == 1)
                    {
                        dotsChkBox.Checked = true;
                        if (visit.IsAdhereToDOTS == 1)
                            dotsRadioBtnYes.Checked = true;
                        else
                            dotsRadioBtnNo.Checked = true;
                    }
                    else
                        dotsChkBox.Checked = false;
                }
                else
                    tbConfirmedChkBox.Checked = false;

#endregion

                #region LOAD OTHER DISEASE

                if (visit.IsOtherDisease == 1)
                {
                    otherChkBox.Checked = true;
                    otherDiseaseTextBox.Text = visit.OtherDiseaseDetails;
                    otherDiseaseTextBox.Visible = true;
                }
                else
                    otherChkBox.Checked = false;

                #endregion


                if (visit.ReceivedSupplement == "1")
                {
                    chkbxReceivedSupp.Checked = true;
                    string supp = visit.NameOfReceivedSupplement;
                    if (supp.Contains("Other"))
                    {
                        cboNameOfSuppliment.Text = supp.Split('-')[0];
                        txtNameOfSupplement.Text = supp.Split('-')[1];
                        txtNameOfSupplement.Visible = true;
                        otherSupplementNamelbl.Visible = true;

                    }
                    else
                        cboNameOfSuppliment.Text = supp;
                }

                if (visit.DischargeOrTranfer == "1")
                {
                    txtTransferedto.Text = visit.TransferedTo;
                }
                if (visit.ReceivedPainManagement == "1")
                {
                    chkbxPainMgmnt.Checked = true;
                    int level = visit.PainManagementLevel;
                    if (level == 3)
                        txtReferPMgt.Text = visit.ReferPainManagement;
                    cboLevel.Text = visit.PainManagementLevel.ToString();
                }
                if(visit.DischargeOrTranfer == "0")
                {
                    rdDischarge.Checked = false;
                    
                }
                else if(visit.DischargeOrTranfer == "1")
                {
                    rdTransfer.Checked = true;
                }

               // txtTransferedto.Text = visit.TransferedTo;
                txtReferPMgt.Text = visit.ReferPainManagement;
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
            if (tbPositive)
            {
                visit.TBStatus = "1";
                if (tbCounselChkBox.Checked)
                {
                    visit.HasTBCounselling = 1;
                    if (tbAdherenceChkBox.Checked)
                        visit.AdhereingToTBCounselling = 1;
                    else
                        visit.AdhereingToTBCounselling = 0;
                }
                else
                {
                    visit.HasTBCounselling = 0;
                }
                if (dotsChkBox.Checked)
                {
                    visit.IsOnDOTS = 1;
                    if (dotsRadioBtnYes.Checked)
                        visit.IsAdhereToDOTS = 1;
                    else
                        visit.IsAdhereToDOTS = 0;
                }
                else
                {
                    visit.IsOnDOTS = 0;
                }
            }
            else
            {
                visit.TBStatus = "0";
                visit.HasTBCounselling = 0;
            }
            if(hivPositive)
            {
                visit.ConfirmedHivStatus = "1";
                if (onARTStatus.Text.Equals(""))
                    visit.OnARTStatus = "NON_OI";
                else
                    visit.OnARTStatus = onARTStatus.Text;
                if (chkbxOnArt.Checked)
                {
                    visit.IsOnART = "1";
                }
                else
                {
                    visit.IsOnART = "0";
                }
                if (rdIsAdheringNo.Checked)
                {
                    visit.IsAdhering = "0";
                }
                else if (rdIsAdheringYes.Checked)
                {
                    visit.IsAdhering = "1";
                }
                else
                {
                    visit.IsAdhering = "0";
                }
            }
            else
            {
                visit.ConfirmedHivStatus = "0";
                visit.IsOnART = "0";
                visit.IsAdhering = "0";
            }
            if (chkbxDied.Checked)
            {
                visit.HasDied = 1;
                visit.DateDied = dtpDied.Value;
            }
            else
            {
                visit.HasDied = 0;
                //visit.DateDied = Convert.ToDateTime("00/00/0000");
            }

            
            if (chkbxReceivedSupp.Checked)
            {
                visit.ReceivedSupplement = "1";
                if (cboNameOfSuppliment.Text.Equals("Other"))
                    visit.NameOfReceivedSupplement = "Other - " + txtNameOfSupplement.Text;
                else
                    visit.NameOfReceivedSupplement = cboNameOfSuppliment.Text;
            }
            else
            {
                visit.ReceivedSupplement = "0";
            }

            if (otherChkBox.Checked)
            {
                visit.IsOtherDisease = 1;
                visit.OtherDiseaseDetails = otherDiseaseTextBox.Text;
            }
            if (chkbxPainMgmnt.Checked)
            {
                visit.ReceivedPainManagement = "1";
                visit.PainManagementLevel = Int32.Parse(cboLevel.Text);
                if (cboLevel.Text == "3")
                {
                    visit.ReferPainManagement = txtReferPMgt.Text;
                }
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
                visit.DischargeOrTranfer = "0";
            }
            if (chkbxCounseled.Checked)
            {
                visit.ReceivedCounselling = "1";
            }
            else
            {
                visit.ReceivedCounselling = "0";
            }

            //visit.NameOfReceivedSupplement = cboNameOfSuppliment.Text;
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

            parent.SetUserControl(new PatientSummary(Entity.CurrentPatient,parent));
        }

        private void chkbxConfirmedHIVStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxConfirmedPositive.Checked == true)
            {
                hivPositive = true;                
                chkbxCounseled.Visible = true;
                chkbxOnArt.Visible = true;
                gpbxIsClientAdhering.Visible = true;                
                chkbxCounseled.Enabled = true;
                chkbxOnArt.Enabled = true;
                gpbxIsClientAdhering.Enabled = true;
                
                
            }
            else
            {
                hivPositive = false;
                chkbxCounseled.Visible = false;
                chkbxOnArt.Visible = false;
                chkbxOnArt.Checked = false;
                gpbxIsClientAdhering.Visible = false;
                chkbxOnArt.Visible = false;
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
            if (tbConfirmedChkBox.Checked == true)
            {
                tbPositive = true;
                tbCounselChkBox.Visible = true;
                dotsChkBox.Visible = true;
                tbAdherenceGrpBox.Visible = true;
                
            //    rdIsAdheringYes.Checked = false;
            //    chkbxOnArt.Checked = false;
            //    chkbxCounseled.Checked = false;
            }
            else
            {
                tbPositive = false;
                tbCounselChkBox.Visible = false;
                dotsChkBox.Visible = false;
                tbAdherenceGrpBox.Visible = false;
                //chkbxConfirmedHIVStatus.Enabled = true;
            }
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
                onARTStatus.Visible = true;
                onARTStatus.DisplayMember = "NON_OI";
                artStatuslbl.Visible = true;
                rdIsAdheringYes.Enabled = true;
                rdIsAdheringNo.Enabled = true;
                
            }
            else
            {
                onARTStatus.Visible = false;
                //onARTStatus.ValueMember = "NON OPPORTUNISTIC INFECTION";
                artStatuslbl.Visible = false;
                rdIsAdheringYes.Enabled = false;
                rdIsAdheringNo.Enabled = false;
                chkbxAdheranceCounselling.Enabled = false;
            }
        }

        private void rdDischarge_CheckedChanged(object sender, EventArgs e)
        {
            txtTransferedto.Enabled = false;
            txtRefer.Enabled = false;
        }

        private void dtpDied_ValueChanged(object sender, EventArgs e)
        {

        }

        private void otherChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (otherChkBox.Checked)
                otherGroupBox.Visible = true;
            else
                otherGroupBox.Visible = false;
        }

        private void tbCounselChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tbCounselChkBox.Checked)
                tbAdherenceChkBox.Enabled = true;
            else
                tbAdherenceChkBox.Enabled = false;
        }

        private void dotsChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dotsChkBox.Checked)
            {
                dotsRadioBtnNo.Enabled = true;
                dotsRadioBtnYes.Enabled = true;
            }
            else
            {
                dotsRadioBtnNo.Enabled = false;
                dotsRadioBtnYes.Enabled = false;
            }
        }

        private void chkbxCounseled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxCounseled.Checked)
                chkbxAdheranceCounselling.Enabled = true;
            else
            {
                chkbxAdheranceCounselling.Enabled = false;
                chkbxAdheranceCounselling.Checked = false;
            }
        }

        private void cboNameOfSuppliment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNameOfSuppliment.Text.Equals("Other"))
            {
                otherSupplementNamelbl.Visible = true;
                txtNameOfSupplement.Visible = true;
            }
            else
            {
                otherSupplementNamelbl.Visible = false;
                txtNameOfSupplement.Visible = false;
            }
        }

        #region TOOLTIP EVENTS

        void tbAdherenceGrpBox_MouseHover(object sender, System.EventArgs e)
        {
            ToolTip tip = GetToolTip();
            tip.SetToolTip(this.tbAdherenceGrpBox, "Use this section to speciy \n" +
                                                    "if a patient is Adhereing to TB Treatment and Counselling");
        }

        private ToolTip GetToolTip()
        {
            ToolTip tip = new ToolTip();
            tip.AutoPopDelay = 2000;
            tip.InitialDelay = 800;
            tip.ReshowDelay = 500;
            tip.ShowAlways = true;            
            tip.UseFading = true;
            tip.ToolTipIcon = ToolTipIcon.Info;
            return tip;
        }

        void label12_MouseHover(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        void onARTStatus_MouseHover(object sender, System.EventArgs e)
        {
            ToolTip tip = GetToolTip();
            tip.SetToolTip(this.onARTStatus, "Speciy if a patient\n has any Opportunistic Infections");
        }

        void btnCancel_MouseHover(object sender, System.EventArgs e)
        {

        }

        #endregion


    }
}
