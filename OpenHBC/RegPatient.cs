using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC;
using OpenHBC.Managers;

namespace OpenHBC
{
    public partial class RegPatient : UserControl
    {
        private Patient pat;
        private Concepts regConcepts= new Concepts();
        public RegPatient()
        {
            
            InitializeComponent();
            initialiseCombos();
            btnClear.Visible = true;
        }

        public RegPatient(Patient patient)
        {
            
            InitializeComponent();
            initialiseCombos();
            btnClear.Visible = false;
            
            try
            {
                txtPatientId.Text = patient.PatientId.ToString();
                txtFirstName.Text = patient.FirstName;
                txtMiddlename.Text = patient.MiddleName;
                txtSurname.Text = patient.Surname;
                cbxNumberOfChildren.SelectedIndex = patient.NumberOfChildren;
                dtcDateOfBirth.Text = patient.DateOfBirth.Date.ToString();
                dateOfAssesment.Text = patient.AssesmentDate.Date.ToString();
                cbxBreadWinner.SelectedItem = patient.BreadWinner;
                cbxPositionInFamily.SelectedItem = patient.PositionInFamily;
                
                
                cbxMaritalStatus.SelectedItem = patient.MaritalStatus;
                cbxSex.SelectedItem = patient.Sex;
                
                txtNrcNumber.Text = patient.NrcNumber;
                txtReligion.Text = patient.Religion;

                cbxParish.SelectedItem = patient.Parish;
                cbxSection.SelectedItem = patient.Section;
                cbxCompound.SelectedItem = patient.Compound;
            }
            catch(Exception ex)
            {
                
            }
        }

        private void initialiseCombos()
        {
            if (regConcepts != null)
            {
                this.cbxSex.Items.AddRange(regConcepts.Sex);
                this.cbxMaritalStatus.Items.AddRange(regConcepts.MaritalStatus);
                this.cbxNumberOfChildren.Items.AddRange(regConcepts.NumberOfChildren);
                this.cbxParish.Items.AddRange(regConcepts.Sites);
                this.cbxPositionInFamily.Items.AddRange(regConcepts.PositionInFamily);
               // this.cbxSection.Items.AddRange((SectionsMgr.sectionListNamesOnly()).ToArray());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(Entity.CurrentPatient==null)
            {
                Login.refreshPanel(new PatientSummary());
            }
            else
            {
                Login.refreshPanel(new PatientSummary(Entity.CurrentPatient));
            }
            
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPatientId.Text=="")
            {
                string temp = "doesntexist";
                pat=new Patient();
                pat.PatientId = Int32.Parse(Entity.validatePatientID(temp));
            }
            else
            {
                pat = Entity.CurrentPatient;
                pat.PatientId = Int32.Parse(txtPatientId.Text);
            }
            pat.FirstName = txtFirstName.Text;
            pat.Surname = txtSurname.Text;
            pat.MiddleName = txtMiddlename.Text;
            pat.DateOfBirth = dtcDateOfBirth.Value;
            pat.Sex = cbxSex.Text;
            pat.Compound = cbxCompound.Text;
            pat.NrcNumber = txtNrcNumber.Text;
            pat.PositionInFamily = cbxPositionInFamily.Text;
            pat.Parish = cbxParish.Text;
            pat.Section = cbxSection.Text;
            pat.BreadWinner = cbxBreadWinner.Text;
            pat.Religion = txtReligion.Text;
            try
            {
                pat.NumberOfChildren = Int32.Parse(cbxNumberOfChildren.Text);
            }catch(Exception ex)
            {
                pat.NumberOfChildren = 0;
            }
            pat.MaritalStatus = cbxMaritalStatus.Text;
            pat.AssesmentDate = dateOfAssesment.Value; 
            
            Entity.saveReg(pat);
            Entity.CurrentPatient = pat;
            Login.refreshPanel(new PatientSummary(Entity.CurrentPatient));

            
            
        }

        private void RegPatient_Enter(object sender, EventArgs e)
        {
            if (Entity.CurrentPatient==null)
            {
                
                pat = new Patient();
                //pat.PatientId = Entity.generateNewPatientId();
            }
            else
            {
                //Entity.CurrentPatient = new Patient();
                //pat = new 
               
            }
        }

        private void cbxParish_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationProvider.LocationProvider locprov = new OpenHBC.LocationProvider.LocationProvider();
            string selected = "";
            if (cbxParish.SelectedIndex != -1)
            {
                selected = cbxParish.SelectedItem.ToString();
            }

            string[][] strDistricts = locprov.GetSections(selected);

            cbxSection.Items.Clear();
            if (strDistricts != null)
            {
                foreach (string[] s in strDistricts)
                {
                    cbxSection.Items.Add(s[1]);
                }
            }
            //cbxSection.Items.AddRange(strDistricts);

            cbxSection.Enabled = true;
        }

        private void cbxSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationProvider.LocationProvider locprov = new OpenHBC.LocationProvider.LocationProvider();
            string selected = cbxSection.SelectedItem.ToString();

            string[][] compounds = locprov.GetCompounds(selected);

            cbxCompound.Items.Clear();
            if (compounds != null)
            {
                foreach (string[] s in compounds)
                {
                    cbxCompound.Items.Add(s[1]);
                }
            }
            //cbxSection.Items.AddRange(strDistricts);

            cbxCompound.Enabled = true;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to clear all fields?", "Clear Fields WARNING", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                    foreach (Control ctrl in this.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ctrl.Text = "";
                        }
                        else if (ctrl is ComboBox)
                        {
                            ((ComboBox)ctrl).SelectedIndex = -1;
                        }
                    }
            }
        }

       

    }
}
