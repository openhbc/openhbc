using System;
using System.Collections.Generic;
using System.Text;
using OpenHBC.Utilities;

namespace OpenHBC.Managers
{
    class SectionsMgr
    {
        private static List<string[]> _sectionlist;
        private static MysqlDbUtility _db = new MysqlDbUtility();

        internal static void AddNewSection(string SectionName, string Comments, string SiteName)
        {
            int sectionid = Utility.GetNextNewId("sectionid", "sections");
            string insertsql =
                string.Format("INSERT INTO sections VALUES ({0},'{1}','{2}', '{3}')", sectionid, Utility.parseString(SectionName), Utility.parseString(Comments), Utility.parseString(SiteName));

            _db.runNonQuery(insertsql);
        }

        internal static void EditSection(int sectionId, string sectionName, string comments, string SiteName)
        {
            string updatesql = string.Format("UPDATE sections SET sectionname = '{0}', comments = '{1}', SiteName = '{3}' WHERE sectionid = '{2}'", Utility.parseString(sectionName), Utility.parseString(comments), sectionId, Utility.parseString(SiteName));
            _db.runNonQuery(updatesql);
        }

        public static void deleteSection(string sectionid)
        {
            string deletesql = string.Format("DELETE FROM Sections WHERE sectionid = {0}", sectionid);

            _db.runNonQuery(deletesql);
        }


        public static List<string[]> SectionList
        {
            get
            {
                _sectionlist.Clear();
                _sectionlist = sectionList();

                return _sectionlist;
            }

        }

        public static List<string[]> sectionList()
        {
            string sqlselect = "select sectionname, comments, sectionid, SiteName from sections";

            string[][] result = _db.multiColRowResult(sqlselect);

            List<string[]> tmp = new List<string[]>();

            if (result == null) return null;
            foreach (string[] s in result)
            {
                tmp.Add(s);
            }

            return tmp;
        }

        public static List<string> sectionListNamesOnly()
        {
            string sqlselect = "select sectionname from sections";

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
