using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OpenHBC
{
    public partial class MainLogin : UserControl
    {
        Login parent;
        public MainLogin()
        {
            InitializeComponent();
            Name = "Open HBC";
        }
        public MainLogin(UserControl currentPage)
        {

        }

        # region KUNDA
        public MainLogin(Login parent)
        {
            this.parent = parent;
            InitializeComponent();
            Name = "Open HBC";
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Entity.verifyUsernamePassword(txtUsername.Text, txtPassword.Text))
            {
                HomeHbC screen = new HomeHbC(parent);
                parent.SetUserControl(screen);
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login.refreshPanel(this);
            }
            
        }

        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*Disabled this for debuggin purposes*/
         
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
          
         

        

        
    }
}
