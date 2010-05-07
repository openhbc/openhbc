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
        public MainLogin()
        {
            InitializeComponent();
            Name = "Open HBC";
        }
        public MainLogin(UserControl currentPage)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(Entity.verifyUsernamePassword(txtUsername.Text, txtPassword.Text))
            {
                HomeHbC screen = new HomeHbC();
                Login.refreshPanel(screen);
            }
            else Login.refreshPanel(this);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
