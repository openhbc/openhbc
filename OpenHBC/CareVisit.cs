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
        private string _receivedPainManagement;
        private string _confirmedHivStatus;
        private string _isTBPositive;
        private string _receivedHIVCounselling;
        private string _isOnART;
        private string _isAdheringToArt;
        private string _receivedSupplement;
        private string _nameReceivedSupplement;
        private string _dischargeOrTransfer;
        private string _transferedTo;
        private string _referPainManagement;
        private DateTime _dateDied;

        private int _isOnDOTS;
        public int IsOnDOTS
        {
            get { return _isOnDOTS; }
            set { _isOnDOTS = value; }
        }
        private int _isAdhereToDOTS;
        public int IsAdhereToDOTS
        {
            get { return _isAdhereToDOTS; }
            set { _isAdhereToDOTS = value; }
        }
        private int _isOtherDisease;
        public int IsOtherDisease
        {
            get { return _isOtherDisease; }
            set { _isOtherDisease = value; }
        }
        private int _hasTBCounselling;
        public int HasTBCounselling
        {
            get { return _hasTBCounselling; }
            set { _hasTBCounselling = value; }
        }
        private int _adhereingToTBCounselling;
        public int AdhereingToTBCounselling
        {
            get { return _adhereingToTBCounselling; }
            set { _adhereingToTBCounselling = value; }
        }
        private string _otherDiseaseDetails;
        public string OtherDiseaseDetails
        {
            get { return _otherDiseaseDetails; }
            set { _otherDiseaseDetails = value; }
        }
        private string _onARTStatus;
        public string OnARTStatus
        {
            get { return _onARTStatus; }
            set { _onARTStatus = value; }
        }
        private int _adherancetoHIVCounselling;
        public int AdherancetoHIVCounselling
        {
            get { return _adherancetoHIVCounselling; }
            set { _adherancetoHIVCounselling = value; }
        }
        
        public CareVisit():base(_visittype,_visitname)
        {
           
            
        }
        //public CareVisit(int patientid, int visitId, DateTime visitdate, string clinicalfindings, string treatment, string remarks, int userId, int siteId, string receivedPainManagement, string confirmedHivStatus, string tbStatus, string receivedCounselling, string isOnART, string isAdhering, string receivedSupplement, string nameReceivedSupplement, string dischargeOrTransfer, string transferedTo, int painManagementLevel, string referPainManagement, int hasDied, DateTime dateDied, int receivedAdheranceCounselling)
        public CareVisit(int patientid, int visitId, DateTime visitdate, string clinicalfindings, string treatment,
                         string remarks, int userId, int siteId, string receivedPainManagement, string confirmedHivStatus,
                         string isOnART, string isAdheringToART, string receivedSupplement, string nameReceivedSupplement,
                         string dischargeOrTransfer, string transferedTo, string receivedHIVCounselling,
                         string isTBPositive, int isOnDots, int adhereToDots, int painManagementLevel, string referPainManagement,
                         int hasDied, DateTime dateDied, int isOtherDisease, int hasTBCounselling, int adhereingToTBCounselling,
                         string otherDiseaseDetails, string onARTStatus, int adheranceToHIVCounselling)
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
            this.IsOtherDisease = isOtherDisease;
            this.PainManagementLevel = painManagementLevel;
            this.HasDied = hasDied;
            this.ReceivedAdheranceCounselling = adheranceToHIVCounselling;
            this.DateDied = dateDied;
            _receivedPainManagement = receivedPainManagement;
            _confirmedHivStatus = confirmedHivStatus;
            _isTBPositive = isTBPositive;
            _receivedHIVCounselling = receivedHIVCounselling;
            _isOnART = isOnART;
            _isAdheringToArt = isAdheringToART;
            _receivedSupplement = receivedSupplement;
            _nameReceivedSupplement = nameReceivedSupplement;
            _dischargeOrTransfer = dischargeOrTransfer;
            _transferedTo = transferedTo;
            _isOnDOTS = isOnDots;
            _isAdhereToDOTS = adhereToDots;
            _hasTBCounselling = hasTBCounselling;
            _adhereingToTBCounselling = adhereingToTBCounselling;
            _otherDiseaseDetails = otherDiseaseDetails;
            _onARTStatus = onARTStatus;
            _referPainManagement = referPainManagement;
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
        public string ReceivedPainManagement
        {
            get { return _receivedPainManagement; }
            set { _receivedPainManagement = value; }
        }
        public string ConfirmedHivStatus
        {
            get { return _confirmedHivStatus; }
            set { _confirmedHivStatus = value; }
        }
        public string TBStatus
        {
            get { return _isTBPositive; }
            set { _isTBPositive = value; }
        }
        public string ReceivedCounselling
        {
            get { return _receivedHIVCounselling; }
            set { _receivedHIVCounselling = value; }
        }
        public string IsOnART
        {
            get { return _isOnART; }
            set { _isOnART = value; }
        }
        public string ReceivedSupplement
        {
            get { return _receivedSupplement; }
            set { _receivedSupplement = value; }
        }
        public string IsAdhering
        {
            get { return _isAdheringToArt; }
            set { _isAdheringToArt = value; }
        }
        public string NameOfReceivedSupplement
        {
            get { return _nameReceivedSupplement; }
            set { _nameReceivedSupplement = value; }
        }
        public string DischargeOrTranfer
        {
            get { return _dischargeOrTransfer; }
            set { _dischargeOrTransfer = value; }
        }
        //private string _hasDied;

        //public string HasDied
        //{
        //    get { return _hasDied; }
        //    set { _hasDied = value; }
        //}
        public string TransferedTo
        {
            get { return _transferedTo; }
            set { _transferedTo = value; }
        }        
        public string ReferPainManagement
        {
            get { return _referPainManagement; }
            set { _referPainManagement = value; }
        }
        public DateTime DateDied
        {
            get { return _dateDied; }
            set { _dateDied = value; }
        }
        //private string _painManagementLevel;

        //public string PainManagementLevel
        //{
        //    get { return _painManagementLevel; }
        //    set { _painManagementLevel = value; }
        //}

        //private string _receivedAdheranceCounselling;

        //public string ReceivedAdheranceCounselling
        //{
        //    get { return _receivedAdheranceCounselling; }
        //    set { _receivedAdheranceCounselling = value; }
        //}
	
    }
}
