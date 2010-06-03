using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using OpenHBC.AdminUI;
using OpenHBC.AdminUI.UserRole;
using OpenHBC.Security;
using OpenHBC.Utilities;

namespace OpenHBC
{
    public partial class SecurityMgmtUI : UserControl
    {
        Login parent;
        public SecurityMgmtUI(Login p)
        {
            this.parent = p;
            InitializeComponent();
        }
        public SecurityMgmtUI(int tabId, Login p)
        {
            this.parent = p;
            InitializeComponent();
            FocusTab(tabId);
            PopulateGrids(tabId);
        }

        private void PopulateGrids(int tabId)
        {
            switch (tabId)
            {
                case 0:
                    LoadUsersOnGrid();
                    break;
                default:
                    LoadRolesOnGrid();
                    break;
            }
        }

        private void LoadRolesOnGrid()
        {
            this.rolesGridView.Rows.Clear();
            if (Entity.RoleList != null)
            {
                foreach (SecurityRole s in Entity.RoleList)
                {
                    if (s == null) break;
                    rolesGridView.Rows.Add(
                        new string[] {s.RoleName,s.RoleId });
                }
            }
        }

        private void LoadUsersOnGrid()
        {
            
            this.usersGridView.Rows.Clear();
            if (Entity.RoleList != null)
            {
                foreach (User s in Entity.Users())
                {
                    if (s == null) break;
                    usersGridView.Rows.Add(
                        new string[] { s.UserName, s.UserRole.RoleName,s.UserId});
                }
            }
        }

        public void FocusTab(int i)
        {
            UserRoleTabControl.SelectTab(i);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new SecurityUserDetails(parent));
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new RoleSecurityDetailsUI(parent));
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new Admin(parent));
        }

        private void btnUserSave_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new Admin(parent));
        }

        private void btnRoleBack_Click(object sender, EventArgs e)
        {
            parent.SetUserControl(new Admin(parent));
        }

        private void SecurityMgmtUI_OnLoad(object sender, EventArgs e)
        {
            PopulateGrids(UserRoleTabControl.SelectedIndex);
        }

        private void UserRoleTabControl_Selected(object sender, TabControlEventArgs e)
        {
            PopulateGrids(e.TabPageIndex);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {  
            try
            {
                int id = Int32.Parse(DataGridUtility.GetValue(usersGridView.CurrentRow, 2).ToString());
                User user =  SecurityServiceProvider.LoadUser(id);
                parent.SetUserControl(new SecurityUserDetails(user,parent));
            }
            catch (Exception exc)
            {

            }

        }

        private void btnEditRole_Click(object sender, EventArgs e)
        {
            string rolename = DataGridUtility.GetValue(rolesGridView.CurrentRow, 0).ToString();
            SecurityRole role = SecurityServiceProvider.GetRoleFromName(rolename);

            parent.SetUserControl(new RoleSecurityDetailsUI(role,parent));
          
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to delete this User?", "Delete User WARNING", MessageBoxButtons.YesNo,MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(result == DialogResult.Yes)
            {
                int id = Int32.Parse(DataGridUtility.GetValue(usersGridView.CurrentRow, 2).ToString());
            
                User user = SecurityServiceProvider.LoadUser(id);
                SecurityServiceProvider.DeleteUser(user);
                parent.SetUserControl(new SecurityMgmtUI(parent));
            }
        }
    }
}
