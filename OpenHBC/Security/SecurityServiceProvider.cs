using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using OpenHBC.Utilities;

namespace OpenHBC.Security
{
    class SecurityServiceProvider
    {
        static MysqlDbUtility db = new MysqlDbUtility();

        #region User methods


        public static User LoadUser(int userID)
        {
            string getUserNamesSQL =
                string.Format(@"SELECT id,username, firstname, surname,roleid from login where id = {0}", userID);

            string[] result = db.singleRow(getUserNamesSQL);
            SecurityRole role = getSecurityRole(Int32.Parse(result[4]));
            User tmpUser = new User(result[0], result[1], result[2],result[3] ,role);

            return tmpUser;

        }

        public static User[] Users()
        {
            List<User> userslst = new List<User>();
            string getUsersNamesSQL ="SELECT id,username, firstname, surname,roleid from login";

            string[][] userlist = db.multiColRowResult(getUsersNamesSQL);

            foreach(string[] user in userlist)
            {
                userslst.Add(new User(user[0], user[1], user[2], user[3], getSecurityRole(Int32.Parse(user[4]))));
            }
            return userslst.ToArray();
        }

        public static string GetUserPassword(User user)
        {
            string getuserpasswordsql = string.Format("SELECT password from login where id = {0}",Int32.Parse(user.UserId));
            return db.scalarValue(getuserpasswordsql);
        }


        public static void AddNewUser(string username, string firstname, string surname, int userRoleId, string password)
        {
            string addNewUserSql = "SELECT max(id)+1 FROM login";
            int i = Int32.Parse(db.scalarValue(addNewUserSql));

            string insertUserDetail =
                string.Format(@"INSERT INTO LOGIN VALUES ({0},'{1}','{2}','{3}','{4}',{5})", i, Utility.parseString(username), Utility.encryptString(password),
                              Utility.parseString(firstname), Utility.parseString(surname), userRoleId);

            db.runNonQuery(insertUserDetail);
        }

        public static void AddNewUser(User user,string password)
        {
            AddNewUser(user.UserName, user.FirstName, user.Surname, Int32.Parse(user.UserRole.RoleId), password);
        }

        public static void EditUser(string userid, string username, string firstname, string surname, int userRoleId, string password)
        {
            string updatesql =
                string.Format(
                    @"UPDATE login SET username = {0},firstname = {1}, surname = {2}, userRoleId = {3}, password = {4} WHERE id = {5}",
                    Utility.parseString(username), Utility.parseString(firstname),
                    Utility.parseString(surname), userRoleId, password, userid);
            db.runNonQuery(updatesql);
        }

        public static void EditUser(User user,string password)
        {
            EditUser(user.UserId, user.UserName, user.FirstName, user.Surname, Int32.Parse(user.UserId), password);
        }

        public static void DeleteUser(int userid)
        {
            string deleteUserSql = string.Format("DELETE FROM login WHERE Id = {0}", userid);

            db.runNonQuery(deleteUserSql);
        }

        public static void DeleteUser(User user)
        {
            DeleteUser(Int32.Parse(user.UserId));
                    }

        #endregion

        #region security role methods

        protected static SecurityRole getSecurityRole(int roleId)
        {

            string roleNameSql = string.Format(@"select roleName from roles where roleId = {0}", roleId);
            string roleRightsSql = string.Format(@"select rightId from roleRightLink where roleId = {0}", roleId);

            return new SecurityRole(roleId.ToString(), db.scalarValue(roleNameSql), Utility.convertStrArrayToIntArray(db.singleColMultiRow(roleRightsSql)));

        }

        public static SecurityRole[] getRoleList()
        {
            List<SecurityRole> lst = new List<SecurityRole>();
            string sqlRoleLst = "SELECT RoleId FROM Roles";
            string[] s = db.singleColMultiRow(sqlRoleLst);

            foreach(string str in s)
            {
                lst.Add(getSecurityRole(Int32.Parse(str)));
            }
            return lst.ToArray();
        }

        public static string[] getRoleNamesList()
        {
            SecurityRole[] lst = getRoleList();
            string[] str = new string[lst.Length];
            int cnt = 0;
            foreach(SecurityRole role in lst)
            {
                str[cnt++] = role.RoleName;
            }

            return str;
        }


        internal static string[] GetRightList()
        {
            string[] lst = Enum.GetNames(typeof(Rights));

            return lst;
        }



        public static SecurityRole[] roleList()
        {
            List<SecurityRole> roles = new List<SecurityRole>();
            SecurityRole role = new SecurityRole();
            List<int> rightLst = new List<int>();
            
            string getRolesSql = " select roleId, roleName from roles";
            string[][] _roles = db.multiColRowResult(getRolesSql);
            
            string getRoleRightLinkSql = "SELECT roleId, rightId FROM roleRightLink";
            string[][] roleRights = db.multiColRowResult(getRoleRightLinkSql);

            int roleID = -1;
            string roleName = "";

            foreach(string[] s in _roles)
            {
                roleID = Int32.Parse(s[0]);
                roleName = s[1].ToString();

                foreach(string[] str in roleRights)
                {
                    if(roleID == Int32.Parse(str[0].ToString()))
                    {
                        rightLst.Add(Int32.Parse(str[1].ToString()));
                    }
                }

                role = new SecurityRole(roleID.ToString(), roleName, rightLst.ToArray());
                roles.Add(role);
                rightLst.Clear();

            }

                return roles.ToArray();
        }


        public static void AddNewRole(string name, string[] rights)
        {
            string maxidsql = "select max(roleid)+1 from roles";
            int newRoleId = Int32.Parse(db.scalarValue(maxidsql).ToString());

            string insertToRoles = string.Format(@"INSERT INTO ROLES VALUES({0},'{1}')", newRoleId, Utility.parseString(name));

            db.runNonQuery(insertToRoles);

            //insert rights
            InsertRoleRights(newRoleId, rights);
            Entity.RoleList = getRoleList();
        }

        private static void InsertRoleRights(int newRoleId, string[] rights)
        {
            int temp = -1;
            string insertRigtssql = "";
            foreach(string right in rights)
            {
                temp = (Int32)Enum.Parse(typeof(Rights), right);
                insertRigtssql = string.Format(@"INSERT INTO roleRightLink VALUES({0},{1})", newRoleId, temp);
                db.runNonQuery(insertRigtssql);
            }
        }

        public static void EditRole(string id, string name, string[] rights)
        {
            string updateRoleName = string.Format("UPDATE roles SET rolename = '{0}' WHERE roleID = {1}",Utility.parseString(name),Int32.Parse(id));
            db.runNonQuery(updateRoleName);

            string deleteRightsRoleRole =
                string.Format(@"delete from rolerightlink where roleid = {0}", Int32.Parse(id));
            db.runNonQuery(deleteRightsRoleRole);

            InsertRoleRights(Int32.Parse(id), rights);

            
        }
        public static void EditRole(SecurityRole role)
        {
            EditRole(role.RoleId, role.RoleName, Utility.ConvertIntArrayToString(role.RoleRights.ToArray()));
        }

        public static bool DeleteRole(int roleId)
        {
            string checkifInUseSql = string.Format("select roleid from login where roleid = {0}",roleId);
            string s = db.scalarValue(checkifInUseSql);

            if (s == null || s == "")
            {
                return false;
            }
            else
            {
                string deleteRoleSql = string.Format(@"delete from roles where roleid = {0}", roleId);
                db.runNonQuery(deleteRoleSql);

                string deleteRoleRightsSql = string.Format(@"delete from rolerightlink where roleId = {0}", roleId);
                db.runNonQuery(deleteRoleRightsSql);
                
                return false;
            }

        }

        public static bool DeleteRole(SecurityRole role)
        {
            return DeleteRole(Int32.Parse(role.RoleId));
        }

        public static string getUserPassword(string userid)
        {
            string pwdquery = string.Format(@"SELECT password FROM login WHERE id = {0}", userid);
            string pwd = db.scalarValue(pwdquery);

            return pwd;
        }

        #endregion

        public static SecurityRole GetRoleFromName(string rolename)
        {
            SecurityRole[] lst = getRoleList();
            SecurityRole roletmp = null;
            foreach(SecurityRole role in lst)
            {
                if (role.RoleName.Equals(rolename))
                {
                    roletmp = role;
                    break;
                }
            }
            return roletmp;
            
        }

        public static bool CompareUserObjects(User user_1, User user_2)
        {
            if (user_1.UserRole != user_2.UserRole)
            {
                return false;
            }
            else if (user_1.UserName != user_2.UserName)
            {
                return false;
            }
            else if(user_1.FirstName != user_2.FirstName)
            {
                return false;
            }
            else if(user_1.Surname != user_2.Surname)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public static void UpdateUser(User newUser, string newPassword, User oldUser, string oPassword)
        {
            string updateUserDetail;

            bool update = false;

            if (!CompareUserObjects(newUser, oldUser))
            {
                update = true;
            }
            if(!newPassword.Equals(oPassword))
            {
                newPassword = Utility.encryptString(newPassword);
                update = true;
            }
            if(update)
            {
                updateUserDetail = string.Format(@"UPDATE LOGIN set username = '{0}', password = '{1}', firstname = '{2}', surname = '{3}', roleid = {4} WHERE id = {5}", Utility.parseString(newUser.UserName), newPassword,
                              Utility.parseString(newUser.FirstName), Utility.parseString(newUser.Surname), newUser.UserRole.RoleId,newUser.UserId);

                db.runNonQuery(updateUserDetail);
            }
        }
    }
}
