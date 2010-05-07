using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Data.Odbc;

namespace OpenHBC
{
    class MysqlDbUtility
    {
        private System.Data.Odbc.OdbcConnection OdbcCon;

        private System.Data.Odbc.OdbcCommand OdbcCom;

        private System.Data.Odbc.OdbcDataReader OdbcDR;

        private string ConStr;

        //private string tables;

        public MysqlDbUtility()
        {
            ConStr = "DRIVER={MySQL ODBC 5.1 Driver};SERVER=localhost;DATABASE=openhbcdb;UID=hbc;PWD=12345;OPTION=3";
            OdbcCon = new System.Data.Odbc.OdbcConnection(ConStr);
            //OdbcCon.Open();

            //OdbcCom = new System.Data.Odbc.OdbcCommand("select concat(firstname,' ',surname) from registration", OdbcCon);
            //OdbcDR = OdbcCom.ExecuteReader();
            //int count = 1;
            //while (OdbcDR.Read())
            //{
            //    //if(count==1)continue;
            //    tables = (string)OdbcDR[0];
            //    break;


            //}
        }

        public string getValue()
        {
            OdbcCon.Close();
            return "....";
        }

        public string[][] searchPatient(string surname, string firstname, string id)
        {
            string query="";
            if (surname != "" && firstname != "" && id != "")
            {
                query =
                    string.Format(
                        "select patientid,surname,firstname,sex,dateofbirth from registration where (surname like '%{0}%' AND firstname like '%{1}%') or patientId = {2}",
                        Entity.parseString(surname), Entity.parseString(firstname), parseInt(id));
            }
            else if(surname == "" && firstname == "" && id!="")
            {
                query =
                    string.Format(
                        "select patientid,surname,firstname,sex,dateofbirth from registration where patientId = {0}",parseInt(id));
            }
            else if(surname == "" && id == "" && firstname != "")
            {
                query =
                    string.Format(
                        "select patientid,surname,firstname,sex,dateofbirth from registration where firstname like '%{0}%'",Entity.parseString(firstname));
            }
            else if(firstname == "" && id == "" && surname != "")
            {
                query =
                    string.Format(
                        "select patientid,surname,firstname,sex,dateofbirth from registration where surname like '%{0}%'",
                        Entity.parseString(surname));
            }
            else if(surname != "" && firstname != "" && id=="")
            {
                query =
                    string.Format(
                        "select patientid,surname,firstname,sex,dateofbirth from registration where surname like '%{0}%' AND firstname like '%{1}%'",
                        Entity.parseString(surname), Entity.parseString(firstname));

            }
            else if(surname != "" && id != "" && firstname == "")
            {
                query =
                    string.Format(
                        "select patientid,surname,firstname,sex,dateofbirth from registration where surname like '%{0}%' or patientId = {1}",
                        Entity.parseString(surname), parseInt(id));
            }
            else if(firstname != "" && id != "" && surname == "")
            {
                query =
                    string.Format(
                        "select patientid,surname,firstname,sex,dateofbirth from registration where firstname like '%{0}%' or patientId = {1}",
                        Entity.parseString(firstname), parseInt(id));
            }

            else
            {
                query = "select patientid,surname,firstname,sex,dateofbirth from registration";
            }
            string [][] result=  multiColRowResult(query);
            //these are to be used to convert date of birth to age.
            string result2 = "";  //stores the date from db
            string result3 = ""; 
           // string result3 = "";
            if(result != null)
            {
                int i = 0;
                foreach(string[] row in result)
                {
                    result2 = DateTime.Parse(row[4]).ToString("dd MMMM yyyy");
                   // result3 = result2 -
                    result[i++][4] = DateTime.Parse(result3).ToString("dd MMMM yyyy");
                }
            }
            return result;
        }

        private static Nullable<int> parseInt(string id)
        {
            try
            {
                return Int32.Parse(id);
            }catch(Exception e)
            {
                return null;
            }

        }

        public string scalarValue(string query)
        {
            object result = "";
            try
            {
                OdbcCon.Open();

                OdbcCom = new System.Data.Odbc.OdbcCommand(query, OdbcCon);

                result = OdbcCom.ExecuteScalar();
                OdbcCon.Close();

                
            }
            catch(SqlException e)
            {
                OdbcCon.Close();
            }
            catch(OdbcException e)
            {
                OdbcCon.Close();
                
            }catch(Exception e)
            {
                //result = "1";
                OdbcCon.Close();
            }
            return Convert.ToString(result);
        }

        public void runNonQuery(string query)
        {
            string nonquery = parseString(query);
            OdbcCon.Open();
            OdbcCom = new System.Data.Odbc.OdbcCommand(query, OdbcCon);

            int result = OdbcCom.ExecuteNonQuery();

            OdbcCon.Close();


        }

        private string parseString(string query)
        {
            return query;
        }

        public string[] singleRow(string query)
        {
            OdbcCon.Open();
            OdbcCom = new System.Data.Odbc.OdbcCommand(query, OdbcCon);

            OdbcDR = OdbcCom.ExecuteReader();
            OdbcDR.Read();
            int count = OdbcDR.FieldCount;

            string [] result = new string[count];

            for(int i = 0;i<count;i++)
            {
                result[i] = OdbcDR[i].ToString();
            }

            OdbcCon.Close();

            return result;
        }


        internal int getUserId(string txtUsername, string txtPassword)
        {
            IPasswordEncrypt encrypt = new OpenhbcMd5();
           txtPassword = encrypt.encryptPassword(txtPassword);
            string query =
                string.Format(@"SELECT ID FROM LOGIN WHERE username = '{0}' and password = '{1}'", txtUsername, txtPassword);

            return Int32.Parse(scalarValue(query));
        }

        internal int getSiteId()
        {
            string query = "select value from setting where name ='siteid' ";

            return Int32.Parse(scalarValue(query));
        }

        public string[] singleColMultiRow(string query)
        {
            OdbcCon.Open();
            OdbcCom = new OdbcCommand(query, OdbcCon);

            DataSet set = new DataSet();
            new OdbcDataAdapter(query, OdbcCon).Fill(set);
            int rows = set.Tables[0].Rows.Count;
            if (rows == 0)
            {
                OdbcCon.Close();
                return null;
            }
            string[] result = new string[rows];
            int r=0;
            foreach (DataRow row in set.Tables[0].Rows)
            {
               
               result[r] = row[0].ToString();
                
                r++;
            }
            OdbcCon.Close();

            return result;
            
        }

        public string [][] multiColRowResult(string query)
        {
            try
            {
                OdbcCon.Open();
                OdbcCom = new OdbcCommand(query, OdbcCon);

                DataSet set = new DataSet();
                new OdbcDataAdapter(query, OdbcCon).Fill(set);
                int rows = set.Tables[0].Rows.Count;
                int columns = set.Tables[0].Columns.Count;

                if (rows == 0)
                {
                    OdbcCon.Close();
                    return null;
                }

                string[][] result = new string[rows][];


                int r = 0;


                foreach (DataRow row in set.Tables[0].Rows)
                {
                    int c = 0;
                    result[r] = new string[columns];
                    foreach (DataColumn column in set.Tables[0].Columns)
                    {
                        result[r][c++] = row[column].ToString();
                    }
                    r++;
                }
                OdbcCon.Close();
                return result;
            }catch(Exception e)
            {
                return null;
            }
        }

        public DataSet getDataSet(string query)
        {
            try
            {
                OdbcCon.Open();
                OdbcCom = new OdbcCommand(query, OdbcCon);

                DataSet set = new DataSet();
                new OdbcDataAdapter(query, OdbcCon).Fill(set);
                //int rows = set.Tables[0].Rows.Count;
                //int columns = set.Tables[0].Columns.Count;


                OdbcCon.Close();
                return set;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
