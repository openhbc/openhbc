using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHBC.Utilities
{
    class Utility
    {
        private static MysqlDbUtility db = new MysqlDbUtility();


        //Convert string array to interger array
        public static int[] convertStrArrayToIntArray(string[] strings)
        {
            if (strings == null)
            {
                return null;
            }
            int[] i = new int[strings.Length];
            for (int x = 0; x < strings.Length; x++)
            {
                i[x] = Int32.Parse(strings[x]);
            }

            return i;
        } 
        
        //handle commas in field
        public static object parseString(string p)
        {
            int i = -1;
            StringBuilder sb = new StringBuilder();
            sb.Append(p);
            //sb.
            while(sb.ToString().Contains("'"))
            {
                p = sb.Replace("'", "''").ToString();
                break;
            }
            return p;
        }

        //convert interger array to a string array
        public static string[] ConvertIntArrayToString(int[] array)
        {
            List<string> list = new List<string>();

            foreach(int i in array)
            {
                list.Add(i.ToString());
            }

            return list.ToArray();

        }

        //encrypt string
        public static string encryptString(string toencrypt)
        {
            IPasswordEncrypt encrypt = new OpenhbcMd5();
            toencrypt = encrypt.encryptPassword(toencrypt);

            return toencrypt;
        }

        public static int GetNextNewId(string columnname, string tablename)
        {
            string countitems = string.Format("SELECT count({0}) from {1}", columnname, tablename);
            string sqlmaxid = string.Format("SELECT max({0}) FROM {1}", columnname, tablename);

            int countitemsval = Int32.Parse(db.scalarValue(countitems));
            

            if (countitemsval < 1)
            {
                return 1;
            }
            else
            {
                int maxIdVal = Int32.Parse(db.scalarValue(sqlmaxid));
                return maxIdVal + 1;
            }
        }

    }
   
}
