using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using OpenHBC.Security;
using OpenHBC.Utilities;

namespace OpenHBC
{
    class Entity:SecurityServiceProvider
    {
        #region instance variables

        private static Patient _currentPatient;
        private static int _currentSiteId;
        private static int _currentUserId;
        static MysqlDbUtility db = new MysqlDbUtility();
        private static User _currentUser;
        private static SecurityRole[] _rolesList;
        private static string[] _roleListNames;

        
        #endregion
        
        #region Properties


       public static Patient CurrentPatient
       {
         get
         {
             return _currentPatient;
         }
         set
         {
             _currentPatient = value;
             //if(currentPatient==null)
             //{
             //    currentPatient=new Patient();
             //}
         }
       }

        public static int CurrentUserId
        {
            get { return _currentUserId; }
            set
            {
                _currentUserId = value;
            }
        }

        public static int CurrentSiteId
        {
            get
            {
                _currentSiteId = db.getSiteId();
                return _currentSiteId;
            }
            set
            {
                _currentSiteId = value;
            }
        }

        public static User CurrentUser
        {
            get
            {
                return _currentUser;
            }
            set
            {
                _currentUser = value;
            }
        }

        public static string[] RoleListNames()
        {
            List<string> lst = new List<string>();
            if (_roleListNames==null)
            {
                foreach(SecurityRole role in getRoleList())
                {
                lst.Add(role.RoleName);

                }
                _roleListNames=lst.ToArray();
            }
            return _roleListNames;

        }

        public static SecurityRole[] RoleList
        {
            get 
            { 
                if(_rolesList == null )
                {
                 _rolesList = getRoleList();
                }

                return _rolesList;
            }
            set
            {
                _rolesList = null;
                _rolesList = value;
            }
        }

        #endregion

        #region static methods


        public static void savePatientToDb(Patient patient)
        {
            saveReg(patient);
            //saveVisitsInfo(patient);

        }

        public static void saveReg(Patient patient)
       {

            string query;
            if (!patIdExist(patient.PatientId))
            {
                query = string.Format(@"INSERT INTO 
                                            registration VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')", patient.PatientId, Utility.parseString(patient.FirstName), Utility.parseString(patient.Surname), patient.MiddleName, formartDateForMySQL(patient.DateOfBirth), patient.Sex, patient.Compound, patient.NrcNumber, patient.PositionInFamily, patient.Parish, patient.Section, patient.BreadWinner, patient.NumberOfChildren, patient.MaritalStatus, formartDateForMySQL(patient.AssesmentDate), patient.Religion);
            }
            else
            {
                query = string.Format(@"UPDATE 
                                        registration SET patientID={0},firstname='{1}',surname='{2}',middle_name='{3}',dateofbirth='{4}',sex='{5}',compound='{6}',nrc_number='{7}',position_in_family='{8}',parish='{9}',section='{10}',bread_winner='{11}',number_of_children={12},marital_status='{13}',assesment_date='{14}', religion='{15}' where patientId={0}", patient.PatientId, Utility.parseString(patient.FirstName), patient.Surname, patient.MiddleName, formartDateForMySQL(patient.DateOfBirth), patient.Sex, patient.Compound, patient.NrcNumber, patient.PositionInFamily, patient.Parish, patient.Section, patient.BreadWinner, patient.NumberOfChildren, patient.MaritalStatus, formartDateForMySQL(patient.AssesmentDate), patient.Religion);
            }

            db.runNonQuery(query);
        }

        public static string formartDateForMySQL(DateTime dateTime)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(dateTime.Year + "-" + dateTime.Month + "-" + dateTime.Day);

            return sb.ToString();

        }

        public static Patient loadPatient(int patientId)
        {
            string query = string.Format(@"select patientID,firstname,surname,middle_name,dateofbirth,sex,compound,nrc_number,position_in_family,parish,section,bread_winner,number_of_children,marital_status,assesment_date, religion from registration where patientid={0}", patientId);

            string[] loadPat = db.singleRow(query);
            int count = 0;

            CurrentPatient = new Patient(Int32.Parse(loadPat[0]), loadPat[1], loadPat[2], loadPat[3], DateTime.Parse(loadPat[4]), loadPat[5], loadPat[6], loadPat[7], loadPat[8], loadPat[9], loadPat[10], loadPat[11], Int32.Parse(loadPat[12]), loadPat[13], DateTime.Parse(loadPat[14]), loadPat[15]);
            Entity.CurrentPatient.Visits = loadPatientVisits(Entity.CurrentPatient.PatientId);
            return CurrentPatient;

        }

        private static ArrayList loadPatientVisits(int patientId)
        {
            ArrayList visits = new ArrayList();
            string[][] result;
            string query =
                string.Format(
                    @"select patientid, visitID, visit_date,clinical_findings,treatment,remarks,userId,siteId,receivedPainManagement,confirmedHIVStatus,isOnART,isAdhering,receivedSupplement,nameOfSupplement,dischargeOrTransfer,transferedTo,receivedCounselling,painManagementLevel, referPainManagement, hasDied, dateDied, receivedAdheranceCounselling from monthly_care_visit where patientId ={0}",
                    patientId);

            result = db.multiColRowResult(query);
            if (result == null)
            {
                return visits = null;
            }
            foreach (string[] visit in result)
            {
                DateTime tempDateDied = System.DateTime.Parse("01/01/2001 00:00:00");
                int tempDied = Int32.Parse(parseAsInt(visit[19]));
                if ( tempDied < 1) 
                {
                    tempDateDied = System.DateTime.Parse("01/01/2001 00:00:00");
                }
                else {
                    tempDateDied = System.DateTime.Parse(visit[20]);
                     }
                //                                          int patientid,                  int visitId,             DateTime visitdate,     string ,      string , string,                  int ,                            int siteId,                    int receivedPainManagement, int confirmedHivStatus,          int receivedCounselling,               int isOnART,                                   int isAdhering,                 int receivedSupplement, string ,               int ,                       string )
                visits.Add(new CareVisit(Int32.Parse(parseAsInt(visit[0])), Int32.Parse(parseAsInt(visit[1])), System.DateTime.Parse(visit[2]), visit[3], visit[4], visit[5], Int32.Parse(parseAsInt(visit[6])), Int32.Parse(visit[7]), visit[8], visit[9], visit[10], visit[11], visit[12], visit[13], visit[14], visit[15], visit[16], Int32.Parse(parseAsInt(visit[17])), visit[18], Int32.Parse(parseAsInt(visit[19])), tempDateDied, Int32.Parse(parseAsInt(visit[21]))));
            }

            return visits;

        }
        private static string parseAsInt(string ss)
        {
            if (ss == null)
            {
                return null;
            }
            else if (ss.Equals(""))
            {
                return null;
            }
            else return ss;
        }

        private static string getEmptyStringFromNull(string ss)
        {
            if (ss == null)
            {
                return "";
            }
            else return ss;
        }

        private static bool patIdExist(long p)
        {
            //MysqlDbUtility db = new MysqlDbUtility();
            string query = string.Format(@"select patientId from registration where patientid={0}", p);
            if (db.scalarValue(query) == null || db.scalarValue(query) == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private static bool visitIdExist(long p)
        {
            //MysqlDbUtility db = new MysqlDbUtility();
            string query = string.Format(@"select visitId from monthly_care_visit where visitid={0}", p);
            if (db.scalarValue(query) == null || db.scalarValue(query) == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static void saveVisit(Visit visit)
        {
            if (visit.VisitType == "1")
            {
                saveMonthlyCareVisit(visit);
            }

        }

        private static void saveMonthlyCareVisit(Visit visit)
        {
            CareVisit mcv = (CareVisit)visit;
            string query;
            if (!visitIdExist(mcv.VisitId))
            {
                query =
                    string.Format("insert into monthly_care_visit values( {0},{1},'{2}','{3}','{4}','{5}',{6},{7},{8},{9},{10},{11},{12},'{13}',{14},'{15}',{16},{17},'{18}',{19},{20},{21})",
                                  mcv.PatientId, mcv.VisitId, formartDateForMySQL(mcv.VisitDate), parseString(mcv.ClinicalFindings), parseString(mcv.Treatment), parseString(mcv.Remarks), mcv.UserId, 
                                  mcv.SiteId, parseable(mcv.ReceivedPainManagement), parseable(mcv.ConfirmedHivStatus), parseable(mcv.IsOnART), parseable(mcv.IsAdhering), parseable(mcv.ReceivedSupplement), 
                                  parseString(mcv.NameOfReceivedSupplement), parseable(mcv.DischargeOrTranfer), parseString(mcv.TransferedTo),  parseable(mcv.ReceivedCounselling), mcv.PainManagementLevel, 
                                  parseable(mcv.ReferPainManagement), mcv.HasDied, formartDateForMySQL(mcv.DateDied), mcv.ReceivedAdheranceCounselling);
            }                                                           
            else
            {
                query =
                    string.Format(@"UPDATE monthly_care_visit SET patientid= {0}, 
                                                        visitid = {1},
                                                        visit_date = '{2}',
                                                        clinical_findings = '{3}',
                                                        treatment = '{4}', 
                                                        remarks = '{5}', 
                                                        userid = {6},
                                                        siteid = {7}, 
                                                        receivedPainManagement = {8},
                                                        confirmedHIVStatus = {9},
                                                        isOnART = {10},
                                                        isAdhering = {11},
                                                        receivedSupplement = {12},
                                                        nameOfSupplement = '{13}',
                                                        dischargeOrTransfer = {14},
                                                        transferedTo = '{15}',
                                                        receivedCounselling = {16},
                                                        painManagementLevel = {17}, 
                                                        referPainManagement = {18}, 
                                                        hasDied = {19}, 
                                                        dateDied = {20}, 
                                                        receivedAdheranceCounselling = {21} where visitId = {1}",
                                  mcv.PatientId, mcv.VisitId, formartDateForMySQL(mcv.VisitDate), parseString(mcv.ClinicalFindings),
                                  parseString(mcv.Treatment), parseString(mcv.Remarks), mcv.UserId, mcv.SiteId, parseable(mcv.ReceivedPainManagement), parseable(mcv.ConfirmedHivStatus), parseable(mcv.IsOnART), parseable(mcv.IsAdhering),
                                  parseable(mcv.ReceivedSupplement), parseString(mcv.NameOfReceivedSupplement), parseable(mcv.DischargeOrTranfer), parseString(mcv.TransferedTo), parseable(mcv.ReceivedCounselling),
                                  mcv.PainManagementLevel, parseable(mcv.ReferPainManagement), mcv.HasDied, formartDateForMySQL(mcv.DateDied), mcv.ReceivedAdheranceCounselling);

            }
            db.runNonQuery(query);
        }

        private static string parseable(string ss)
        {
            if (ss == null)
            {
                return "null";
            }
            else if (ss.Equals(""))
            {
                return "null";
            }
            else return ss;
        }

        public static object parseString(string p)
        {
            int i = -1;
            StringBuilder sb = new StringBuilder();
            sb.Append(p);
            //sb.
            while (sb.ToString().Contains("'"))
            {
                p = sb.Replace("'", "''").ToString();
                break;
            }
            return p;
        }
        public static Visit[] LoadVisits(String patientId)
        {
            Visit[] visit = new Visit[1];
            return visit;
        }
        public static Patient LoadReg(string patientid)
        {
            Patient pa = new Patient();
            return pa;
        }




        public static long generateNewPatientId()
       {
           string query = "select ";
           throw new Exception("The method or operation is not implemented.");
       }

       internal static string validatePatientID(string id)
       {
           string query =
               string.Format(
                   @"select max(case when ('{0}' = '' or '{0}' IS NULL or '{0}' = 'doesntexist') then (select max(patientID)+1 as id from registration) else '{0}' end) as patientid",
                   id);
           string query2 = string.Format(@"select max(patientid)+1 from registration where '{0}'='doesntexist'",id);
           string v= db.scalarValue(query2).ToString();
           return v;
       }

       public static int generateVisitId(string visittype)
       {
           try
           {
               string query = string.Format(@"select max(visitId)+1 from monthly_care_visit");
               return Int32.Parse(db.scalarValue(query).ToString());
           }catch(Exception ex)
           {
               return 1;
           }
       }

       public  static bool verifyUsernamePassword(string txtUsername, string txtPassword)
       {
           try
           {
               //IPassword encrypt = new OpenhbcMd5();
               int i = db.getUserId(txtUsername, txtPassword);
               Entity.CurrentUserId = i;
               _currentUser = LoadUser(i);
               return true;
           }catch(Exception ex)
           {
               return false;
           }
           
       }

 

        public static void deleteVisit(int visitId, int patientId)
       {
           string query =
               string.Format(@"DELETE FROM monthly_care_visit WHERE patientId={0} AND visitId = {1}", patientId, visitId);
          db.runNonQuery(query);
       }

       internal static void AddNewSecurityRole(string roleName, string[] rightsListNames)
       {
           SecurityServiceProvider.AddNewRole(roleName, rightsListNames);
       }
        #endregion


       public static void ClearCurrentState()
       {
           _currentPatient = null;
           CurrentSiteId = -1;
           CurrentUser = null;
       }
   }
}
