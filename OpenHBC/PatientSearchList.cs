using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OpenHBC
{
    public partial class PatientSearchList : UserControl
    {
        Login parent;
        public string surname2;
        public PatientSearchList(string surname, string firstname, string id, Login parent)
        {
            this.parent = parent;
            InitializeComponent();
            surname2 = surname;
            PopulateDataGridView(surname, firstname,id);
        }

        private void PopulateDataGridView(string surname, string firstname, string id)
        {


            MysqlDbUtility db = new MysqlDbUtility();
            string[][] result = db.searchPatient(surname, firstname, id);
            if (result == null) return;
            foreach(string[]s in result)
            {
                if(s==null) break;    
                DateTime temp = DateTime.Parse(s[4]);
                int yrs = DateTime.Now.Year - temp.Year;
                if (DateTime.Now.Month < temp.Month || (DateTime.Now.Month == temp.Month && DateTime.Now.Day < temp.Day))
                    yrs--;
                int t = dataGridView1.Rows.Add(s);
                dataGridView1.Rows[t].Cells["Age"].Value = yrs;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView array = (DataGridView)sender;
            if(e.RowIndex==-1) return;
            DataGridViewRow s = dataGridView1.Rows[e.RowIndex];
            DataGridViewCell t=s.Cells[0];
            int id =Int32.Parse(t.Value.ToString());
           
            //MysqlDbUtility test = new MysqlDbUtility();
            
            //this.btnBack.Text = test.getValue();

            parent.SetUserControl(new PatientSummary(Entity.loadPatient(id),parent));

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeHbC home = new HomeHbC(parent);
            home.txtSurname.Text = this.surname2;
            parent.SetUserControl(home);
        }

        private void PatientSearchList_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)Keys.Enter)
            {
                dataGridView1_CellDoubleClick(sender, new DataGridViewCellEventArgs(0, dataGridView1.CurrentRow.Index-1));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

       

    }
}
