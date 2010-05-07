using System;
using System.Collections.Generic;
using System.Text;


namespace OpenHBC
{
    class Concepts
    {
        MysqlDbUtility dbcon = new MysqlDbUtility();
        private string[] _sex;
        private string[] _maritalstatus;
        private string[] _breadwinner;
        private string[] _positioninfamily;
        private string[] _numberofchildren;
        private string[] _sites;
        private string[][] _sections;
        private string[][] _compounds;

        public Concepts()
        {
            _sex = dbcon.singleRow("select concept_values from concepts where concept_name = 'sex'")[0].Split(',');
            _maritalstatus = dbcon.singleRow("select concept_values from concepts where concept_name = 'maritalstatus'")[0].Split(',');
            _breadwinner = dbcon.singleRow("select concept_values from concepts where concept_name = 'breadwinner'")[0].Split(',');
            _positioninfamily = dbcon.singleRow("select concept_values from concepts where concept_name = 'positioninfamily'")[0].Split(',');
            _numberofchildren = dbcon.singleRow("select concept_values from concepts where concept_name = 'numberofchildren'")[0].Split(',');
            _sites = dbcon.singleColMultiRow("select sitename from sites");
            _sections = dbcon.multiColRowResult("select sectionid, sectionname, comments,sitename from sections");
            _compounds = dbcon.multiColRowResult("select  compid, compname,comments, sectname from compounds");
            

        }

        public string[] Sex
        {
            get
            {
                return _sex;
            }
        }

        public string[] BreadWinner
        {
            get
            {
                return _breadwinner;
            }
        }

        public string[] MaritalStatus
        {
            get
            {
                return _maritalstatus;
            }
        }

        public string[] PositionInFamily
        {
            get
            {
                return _positioninfamily;
            }
        }

        public string[] NumberOfChildren
        {
            get
            {
                return _numberofchildren;
            }
        }

        public string[] Sites
        {
            get
            {
                return _sites;
            }
        }
        public string[][] Sections 
        {
            get
            {
                return _sections;
            }
        }
        public string[][] Compounds
        {
            get 
            {
                return _compounds;
            }
        }
    }
}
