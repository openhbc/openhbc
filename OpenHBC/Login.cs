using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenHBC
{
    public partial class Login : Form
    {
        private static UserControl currentPage;
        public Login()
        {
            currentPage = new MainLogin();
            InitializeComponent();
            this.Text = currentPage.Name;
            currentPage.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(currentPage);
            
            mainPanel.Refresh();
            
            //mainPanel.
        }
        public static UserControl CurrentPage
        {
            set
            {

                mainPanel.Controls.Remove(currentPage);
                mainPanel.Controls.Clear();
                currentPage = value;
                currentPage.Dock = DockStyle.Fill;
                //this.Text = currentPage.Name;
                mainPanel.Controls.Add(currentPage);
                mainPanel.Refresh();
            }

            get
            {
                return currentPage;
            }
        }
        
        public void clearPanel()
        {
            mainPanel.Controls.Clear();
        }
        public static void refreshPanel(UserControl control)
        {
            CurrentPage = control;
            CurrentPage.AutoSize = true;
            CurrentPage.Dock = DockStyle.Fill;
            mainPanel.Refresh();
        }

    }
}