using System;
using System.Collections.Generic;
using System.Text;
using OpenHBC.Utilities;

namespace OpenHBC.Managers
{
    class CompoundsMgr
    {
        private static List<string[]> _compoundlist;
        private static MysqlDbUtility _db = new MysqlDbUtility();

        internal static void AddNewCompound(string CompoundName, string SectionName, string Comments)
        {
            int compoundid = Utility.GetNextNewId("compid", "compounds");
            string insertsql =
                string.Format("INSERT INTO compounds VALUES ({0},'{1}','{2}','{3}')", compoundid, Utility.parseString(CompoundName), Utility.parseString(Comments), Utility.parseString(SectionName));

            _db.runNonQuery(insertsql);
        }

        internal static void EditCompound(int compoundId, string compoundName, string SectionName, string comments)
        {
            string updatesql = string.Format("UPDATE compounds SET compname = '{0}', sectname = '{1}', comments = '{2}'  WHERE compid = '{3}'", Utility.parseString(compoundName), Utility.parseString(SectionName), Utility.parseString(comments), compoundId);
            _db.runNonQuery(updatesql);
        }

        public static void deleteCompound(string compoundid)
        {
            string deletesql = string.Format("DELETE FROM Compounds WHERE compid = {0}", compoundid);

            _db.runNonQuery(deletesql);
        }


        public static List<string[]> CompoundList
        {
            get
            {
                _compoundlist.Clear();
                _compoundlist = compoundList();

                return _compoundlist;
            }

        }

        public static List<string[]> compoundList()
        {
            string sqlselect = "select compname, sectname, comments, compid from compounds";

            string[][] result = _db.multiColRowResult(sqlselect);

            List<string[]> tmp = new List<string[]>();

            if (result == null) return null;
            foreach (string[] s in result)
            {
                tmp.Add(s);
            }

            return tmp;
        }

        public static List<string> compoundListNamesOnly()
        {
            string sqlselect = "select compname from compounds";

            string[] result = _db.singleColMultiRow(sqlselect);

            List<string> tmp = new List<string>();

            if (result == null) return null;
            foreach (string s in result)
            {
                tmp.Add(s);
            }

            return tmp;
        }
    }

}
