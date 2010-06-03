using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Managers;
using OpenHBC;

namespace OpenHBC.AdminUI.Sections
{
    public partial class AddSectionUI : UserControl
    {
        private Patient pat;
        Login parent;
        private Concepts regConcepts = new Concepts();

        public AddSectionUI(Login p)
        {
            this.parent = p;
            InitializeComponent();
            cbxParish.Items.AddRange(regConcepts.Sites);

        }

        public AddSectionUI(int sectionid, string sectionname, string comments, string SiteName)
        {
            InitializeComponent();
            cbxParish.Items.AddRange(regConcepts.Sites);

            lblsectionId.Text = sectionid.ToString();
            txtSectionName.Text = sectionname;
            txtComments.Text = comments;
            cbxParish.Text = SiteName;
        }

        private void initialiseCombos()
        {
            if (regConcepts != null)
            {
                this.cbxParish.Items.AddRange(regConcepts.Sites);
                cbxParish.Items.AddRange(regConcepts.Sites);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new SectionsUI(parent));
        }

        private void btnSaveSection_Click(object sender, EventArgs e)
        {
            if (lblsectionId.Text.Equals(""))
            {
                SectionsMgr.AddNewSection(txtSectionName.Text, txtComments.Text, cbxParish.Text);
            }
            else
            {
                SectionsMgr.EditSection(Int32.Parse(lblsectionId.Text), txtSectionName.Text, txtComments.Text, cbxParish.Text);
            }

            Login.refreshPanel(new SectionsUI(parent));
        }

     
       
    }
}
