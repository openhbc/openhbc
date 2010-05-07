using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHBC
{
    public class CareVisit:Visit
    {
        private static string _visittype = "1";
        private static string _visitname = "Care Visit";

        private string _clinicalfindings;
        private string _treatment;
        private string _remarks;
        
        public CareVisit():base(_visittype,_visitname)
        {
           
            
        }

        public CareVisit(int patientid, int visitId, DateTime visitdate, string clinicalfindings, string treatment, string remarks, int userId, int siteId, string receivedPainManagement, string confirmedHivStatus, string receivedCounselling, string isOnART, string isAdhering, string receivedSupplement, string nameReceivedSupplement, string dischargeOrTransfer, string transferedTo, int painManagementLevel, string referPainManagement, int hasDied, DateTime dateDied, int receivedAdheranceCounselling)
            : base(_visittype, _visitname)
        {
            this.PatientId = patientid;
            this.VisitId = visitId;
            this.VisitDate = visitdate;
            this.SiteId = siteId;
            this.UserId = userId;

            this.ClinicalFindings = clinicalfindings;
            this.Treatment = treatment;
            this.Remarks = remarks;

            this.PainManagementLevel = painManagementLevel;
            this.HasDied = hasDied;
            this.ReceivedAdheranceCounselling = receivedAdheranceCounselling;
            this.DateDied = dateDied;

            _receivedPainManagement = receivedPainManagement;
            _confirmedHivStatus = confirmedHivStatus;
            _receivedCounselling = receivedCounselling;
            _isOnART = isOnART;
            _isAdhering = isAdhering;
            _receivedSupplement = receivedSupplement;
            _nameReceivedSupplement = nameReceivedSupplement;
            _dischargeOrTransfer = dischargeOrTransfer;
            _transferedTo = transferedTo;
            

        }

        public string ClinicalFindings
        {
            set
            {
                _clinicalfindings = value;
            }
            get
            {
                return _clinicalfindings;
            }
        }
        public string Treatment
        {
            set
            {
                _treatment = value;
            }
            get
            {
                return _treatment;
            }
        }
        public string Remarks
        {
            set
            {
                _remarks = value;
            }
            get
            {
                return _remarks;
            }
        }
        private string _receivedPainManagement;

        public string ReceivedPainManagement
        {
            get { return _receivedPainManagement; }
            set { _receivedPainManagement = value; }
        }

        private string _confirmedHivStatus;

        public string ConfirmedHivStatus
        {
            get { return _confirmedHivStatus; }
            set { _confirmedHivStatus = value; }
        }

        private string _receivedCounselling;

        public string ReceivedCounselling
        {
            get { return _receivedCounselling; }
            set { _receivedCounselling = value; }
        }

        private string _isOnART;

        public string IsOnART
        {
            get { return _isOnART; }
            set { _isOnART = value; }
        }

        private string _isAdhering;

        public string IsAdhering
        {
            get { return _isAdhering; }
            set { _isAdhering = value; }
        }

        private string _receivedSupplement;

        public string ReceivedSupplement
        {
            get { return _receivedSupplement; }
            set { _receivedSupplement = value; }
        }

        private string _nameReceivedSupplement;
        public string NameOfReceivedSupplement
        {
            get { return _nameReceivedSupplement; }
            set { _nameReceivedSupplement = value; }
        }

        private string _dischargeOrTransfer;

        public string DischargeOrTranfer
        {
            get { return _dischargeOrTransfer; }
            set { _dischargeOrTransfer = value; }
        }

        private string _transferedTo;

        public string TransferedTo
        {
            get { return _transferedTo; }
            set { _transferedTo = value; }
        }
        
        //private string _painManagementLevel;

        //public string PainManagementLevel
        //{
        //    get { return _painManagementLevel; }
        //    set { _painManagementLevel = value; }
        //}

        private string _referPainManagement;

        public string ReferPainManagement
        {
            get { return _referPainManagement; }
            set { _referPainManagement = value; }
        }

        //private string _hasDied;

        //public string HasDied
        //{
        //    get { return _hasDied; }
        //    set { _hasDied = value; }
        //}

        private DateTime _dateDied;

        public DateTime DateDied
        {
            get { return _dateDied; }
            set { _dateDied = value; }
        }

        //private string _receivedAdheranceCounselling;

        //public string ReceivedAdheranceCounselling
        //{
        //    get { return _receivedAdheranceCounselling; }
        //    set { _receivedAdheranceCounselling = value; }
        //}
	
    }
}
