using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHBC.Security
{
    public class SecurityRole
    {
        private string _roleName;
        private string _roleID;

        private List<int> _roleRights = new List<int>();

        public SecurityRole()
        {
            
        }
        public SecurityRole(string id, string rolename, params int[] rightIdLst)
        {
            _roleID = id;
            _roleName = rolename;
            addRights(rightIdLst);
            
        }

        public void removeRight(int i)
        {
            _roleRights.Remove(i);
        }

        public void addRight(int i)
        {
            _roleRights.Add(i);
        }

        public void addRights(params int[] rightIdLst)
        {
            if (rightIdLst == null) return;
            for(int i = 0; i< rightIdLst.Length;i++)
            {
                addRight(rightIdLst[i]);
            }
        }

        public List<int> RoleRights
        {
            get
            {
                return _roleRights;
            }
            set
            {
                _roleRights = null;
                _roleRights = value;
            }
        }

        public string RoleId
        {
            set
            {
                _roleID = value;
            }

            get
            {
                return _roleID;
            }
        }

        public string RoleName
        {
            set
            {
                _roleName = value;
            }
            get
            {
                return _roleName;
            }
        }

        public bool HasRight(string rightName)
        {
            return HasRight((Int32)Enum.Parse(typeof(Rights),rightName));
        }

        public bool HasRight(int rightID)
        {
            if(_roleRights.Contains(rightID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GetRightNames()
        {
            List<string> rightnames = new List<string>();
            foreach (int right in _roleRights)
            {
                rightnames.Add(Enum.GetName(typeof(Rights), right));
            }

            return rightnames;
        }
    }
}
