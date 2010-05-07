using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OpenHBC.LocationProvider
{
    class LocationProvider
    {
        private Concepts con = new Concepts();

        public string[][] GetSections() {
            return con.Sections;
        }
        public string[][] GetSections(string site) { 
            ArrayList tmpsectionsinsite  = new ArrayList();
            string[][] tmpsections = con.Sections;
            

            for (int i = 0; i < tmpsections.Length; i++) 
            {
                //structure of tempsectinos is sectionid, sectionname, commments,sitename
                if (tmpsections[i][3].ToString().Equals(site))
                {
                    tmpsectionsinsite.Add(new string[]{tmpsections[i][0], tmpsections[i][1]});

                }
            }
            string[][] toreturn = new string[tmpsectionsinsite.Count][];
            tmpsectionsinsite.CopyTo(toreturn);
            if (tmpsectionsinsite.Count == 0)
            {
                return null;
            }
            return toreturn;

        }

        public string GetSiteFromSectName(string section_name)
        {
            string sitename = null;

            string[][] sections = con.Sections;
 

            foreach(string[] section in sections)
            {
                if(section[1].ToString() == section_name)
                {
                    sitename =  section[3].ToString();

                    break;
                }
            }

            return sitename;

        }




        public string[][] GetCompounds(string section)
        {
            ArrayList tmpcompoundsinsection = new ArrayList();
            string[][] tmpcompounds = con.Compounds;

            for (int i = 0; i < tmpcompounds.Length; i++)
            {
                //structure of tmpcompounds is compid, compname,comments, sectname
                if (tmpcompounds[i][3].ToString().Equals(section))
                {
                    tmpcompoundsinsection.Add(new string[] { tmpcompounds[i][0], tmpcompounds[i][1] });

                }
            }
            string[][] toreturn = new string[tmpcompoundsinsection.Count][];
            if (tmpcompoundsinsection.Count == 0)
            {
                return null;
            }
            tmpcompoundsinsection.CopyTo(toreturn);
            return toreturn;
 
        
        }

        public string GetSiteIdFromSiteName(string sitename)
        {
            string sql = string.Format(@"select siteid from sites where sitename = '{0}' ", sitename);

            MysqlDbUtility db = new MysqlDbUtility();

            string s = db.scalarValue(sql);

            return s;

        }

        public string[][] GetCompounds()
        {
            return con.Compounds;
        }

        public static string CurrentSiteDetails()
        {
            string sql  = @"select (case when value is not null then value else '-1' end) from setting where name = 'siteid'";

            MysqlDbUtility db = new MysqlDbUtility();
            string s =  db.scalarValue(sql);
            if(!db.Equals(""))
            {
                return null;
            }
            return s;
        }

        public static void SetCurrentSiteDetails(string sitename)
        {
            LocationProvider p = new LocationProvider();
            string siteid = p.GetSiteIdFromSiteName(sitename);

            string sql = string.Format(@"insert into setting(name,value) values(siteid,{0})",siteid);
            

            string countsql = @"select count(*) from setting where name = 'siteid'";

            MysqlDbUtility db = new MysqlDbUtility();

            int count = Int32.Parse(db.scalarValue(countsql));

            if (count == 1)
            {
                string updatesql = string.Format(@"update setting set value = '{0}' where name = 'siteid'", siteid);

                db.runNonQuery(updatesql);
            }
            else
            {
                db.runNonQuery(sql);
            }
        }


    }
}
