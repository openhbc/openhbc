using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Security;
using OpenHBC.Utilities;

namespace OpenHBC.AdminUI.UserRole
{
    public partial class SecurityUserDetails : UserControl
    {
        private User _user;
        public SecurityUserDetails()
        {
            InitializeComponent();
        }
        
        public SecurityUserDetails(User user)
        {
            InitializeComponent();
            _user = user;
            populateFormFromUser(user);
        }

        private void populateFormFromUser(User user)
        {
            txtFirstName.Text = user.FirstName;
            txtSurname.Text = user.Surname;
            txtUsername.Text = user.UserName;
            //txtNotes.Text = 
            cbxAssignedRole.SelectedItem = user.UserRole.RoleName;
            lblUserId.Text = user.UserId;
            txtPassword.Text = SecurityServiceProvider.getUserPassword(user.UserId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User tmpUser =
                new User(lblUserId.Text, txtUsername.Text, txtFirstName.Text, txtSurname.Text,
                         SecurityServiceProvider.GetRoleFromName(cbxAssignedRole.Text));
            if (_user != null)
            {
                string opwd = SecurityServiceProvider.getUserPassword(_user.UserId);

                SecurityServiceProvider.UpdateUser(tmpUser, txtPassword.Text, _user, opwd);

                tmpUser = null;
            }
            else
            {
                SecurityServiceProvider.AddNewUser(tmpUser, txtPassword.Text);
            }

            Login.refreshPanel(new SecurityMgmtUI());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login.refreshPanel(new SecurityMgmtUI());
        }
    }
}
