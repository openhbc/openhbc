using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Security;

namespace OpenHBC.AdminUI.UserRole
{
    public partial class RoleSecurityDetailsUI : UserControl
    {
        private SecurityRole _role;
        private CheckBox[] checkBoxList = new CheckBox[SecurityServiceProvider.GetRightList().Length];
        public RoleSecurityDetailsUI()
        {
            InitializeComponent();
            grpRights_Layout();
        }
        public RoleSecurityDetailsUI(SecurityRole role)
        {
            InitializeComponent();
            grpRights_Layout();
            populateFromRole(role);
            _role = role;
        }

        private void populateFromRole(SecurityRole role)
        {
            this.SuspendLayout();
            List<string> tmpnames = role.GetRightNames();

            txtBxRoleName.Text = role.RoleName;

            foreach(CheckBox chbx in grpRights.Controls)
            {
                if(tmpnames.Contains(chbx.Name))
                {
                    chbx.Checked = true;
                }
                
            }

            this.ResumeLayout();
        }

        private void grpRights_Layout()
        {
            string[] rightList = SecurityServiceProvider.GetRightList();
            this.SuspendLayout();
            int x = grpRights.Size.Width;
            int y = grpRights.Size.Height;
            //the size of out control will be  a max 115 width, and height 17

            int  numberOfCols = (int)x/125;
            int numberOfRows = (int) y/25;

            int initLocationX = 30;
            int initLocationY = 21;

            int controlCnt = 0;

            CheckBox tmpChkBx;

            for (int i = 0; i < numberOfCols; i++ )
            {

                for(int j = 0; j < numberOfRows; j++)
                {
                    tmpChkBx = new CheckBox();

                    if (controlCnt >= rightList.Length) break;

                    tmpChkBx.AutoSize = true;
                    tmpChkBx.Location = new System.Drawing.Point(initLocationX, initLocationY);
                    tmpChkBx.Name = rightList[controlCnt];
                    tmpChkBx.Size = new System.Drawing.Size(115, 17);
                    tmpChkBx.TabIndex = 0;
                    tmpChkBx.Text = rightList[controlCnt];
                    tmpChkBx.UseVisualStyleBackColor = true;

                    checkBoxList[controlCnt++] = tmpChkBx;

                    initLocationY = initLocationY + 25;
                    
                }
                initLocationY =  21;
                initLocationX = initLocationX + 150;
                if (controlCnt >= rightList.Length) break;
            }
            grpRights.Controls.AddRange(checkBoxList);
            grpRights.Show();

            this.ResumeLayout();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<string> rightsSelected = new List<string>();

            //check if a role name was assigned
            if(this.txtBxRoleName.Text == "")
            {
                MessageBox.Show(this, "You need to enter the role name?", "Role name WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //check if any checkbox was ticked, if not warn pop up message so a rights are selected
            foreach(CheckBox checkBox in grpRights.Controls)
            {
                if(checkBox.Checked)
                {
                    //if there is something that is checked let me know
                    rightsSelected.Add(checkBox.Name);
                    
                    //break;
                }
            }
            if (rightsSelected.Count<=0)
            {
                MessageBox.Show(this, "Please assign rights to this role?", "Right Assignment WARNING", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string[] rightsListNames = rightsSelected.ToArray();
            if(_role != null)
            {
                
                Entity.EditRole(_role.RoleId,txtBxRoleName.Text,rightsListNames);
                _role = null;
            }
            else
            {
                Entity.AddNewSecurityRole(txtBxRoleName.Text, rightsListNames);
            }
            Login.refreshPanel(new SecurityMgmtUI(1));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new SecurityMgmtUI(1));
        }
    }
}
