using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHBC
{
    public abstract class Visit
    {
        private  int _visitID;
        private string _visitType;
        private string _visitName;
        private DateTime _visitDate;
        private int _siteId;
        private int _patientId;
        private int _userId;
        private int _painManagementLevel;
        private int _hasDied;
        private int _adhereingToHIVCounselling;
    
        public Visit(string visitType, string visitName)
        {
            this._visitType = visitType;
            this._visitName = visitName;
        }
        public int VisitId
        {
            set
            {
                _visitID = value;
                
            }
            get
            {
                return _visitID;
            }
        }
        public string VisitType
        {
            set
            {
                _visitType = value;
                if (_visitType == null)
                {
                    _visitType = "";
                }
            }
            get
            {
                return _visitType;
            }
        }
        public string VisitName
        {
            set
            {
                _visitName = value;
                if (_visitName == null)
                {
                    _visitName = "";
                }
            }
            get
            {
                return _visitName;
            }
        }
        public DateTime VisitDate
        {
            set
            {
                _visitDate = value;
                if (_visitDate == null)
                {
                    _visitDate = DateTime.Parse("01-01-1900");
                }
            }
            get
            {
                return _visitDate;
            }
        }        
        public int PatientId
        {
            set
            {
                _patientId = value;
              
            }
            get
            {
                return _patientId;
            }
        }
        public int SiteId
        {
            get
            {
                return _siteId;
            }
            set
            {
                _siteId = value;
            }
        }
        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }
        public int PainManagementLevel
        {
            set
            {
                _painManagementLevel = value;

            }
            get
            {
                return _painManagementLevel;
            }
        }
        public int HasDied
        {
            set
            {
                _hasDied = value;

            }
            get
            {
                return _hasDied;
            }
        }
        public int ReceivedAdheranceCounselling
        {
            set
            {
                _adhereingToHIVCounselling = value;

            }
            get
            {
                return _adhereingToHIVCounselling;
            }
        }

    }

}
