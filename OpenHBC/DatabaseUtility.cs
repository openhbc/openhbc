using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;


namespace OpenHBC
{
    class DatabaseUtility
    {
        private SqlConnection s;
        public DatabaseUtility()
        {
            s = new SqlConnection("Data Source=(local)\\Openhbc; Initial Catalog=openhbcdb; User ID=hbc; Password=12345");  
        }

        public string[][] scalar(string surname)
        {
            this.openConn();
            string query = string.Format("select patientid,surname,firstname,sex,dateofbirth  from registration where surname like '%{0}%'", surname);
            SqlCommand sqlcmd= new SqlCommand(query, s);
            DataSet ds = new DataSet();
            new SqlDataAdapter(query, s).Fill(ds);
            string[][] srow = new string[ds.Tables[0].Rows.Count][];

            int count = 0;
            int count2 = 0;

           foreach(DataRow row in ds.Tables[0].Rows)
           {
               srow[count] = new string[5];
               srow[count][count2] = row[count2++].ToString();
               srow[count][count2] = row[count2++].ToString();
               srow[count][count2] = row[count2++].ToString();
               srow[count][count2] = row[count2++].ToString();
               srow[count++][count2] = row[count2].ToString();
               count2 = 0;
           }
            this.closeConn();

            return srow;
        }

        public void openConn()
        {
            s.Open();
        }

        public void closeConn()
        {
            s.Close();
        }
    }
}
