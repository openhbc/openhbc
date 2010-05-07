using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHBC.Security
{
    public class User
    {
        private string _userName = "";
        private string _firstname = "";
        private string _surname = "";
        private string _userID = "";
        private SecurityRole _userRole;

        public User(string userName, string userid, SecurityRole userRole)
        {
            _userName = userName;
            _userID = userid;
            _userRole = userRole;
        }

        public User (string username, string firstname, string surname)
        {
            _userName = username;
            _firstname = firstname;
            _surname = surname;
        }
        public User(string id,string username, string firstname, string surname, SecurityRole userRole)
        {
            _userID = id;
            _userName = username;
            _firstname = firstname;
            _surname = surname;
            _userRole = userRole;
        }


        public User()
        {
            
        }

      
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }

        }

        public string UserId
        {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

        public SecurityRole UserRole
        {
            get
            {
                return _userRole;
            }

            set
            {
                _userRole = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstname;
            }

            set
            {
                _firstname = value;
            }
        }

        public string Surname
        {
            get
            {
                return _surname;
            }

            set
            {
                _surname = value;
            }
        }


    }
}
