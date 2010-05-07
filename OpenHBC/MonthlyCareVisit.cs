using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHBC
{
    class MonthlyCareVisit:Visit
    {
        private string _comments;
        private string _clinicalFindings;
        private string _diagnosis;
        
        public MonthlyCareVisit()
            : base("1", "Monthly Care Visit")
        {
            
        }
        
        public MonthlyCareVisit(int patientId,string comments,string clinicalFindings,string diagnosis):base("1","Monthly Care Visit")
        {
            this.PatientId = patientId;
            _comments = comments;
            _clinicalFindings = clinicalFindings;
            _diagnosis = diagnosis;
        }

        public string comments
        {
            get
            {
                if (_comments == null)
                {
                    _comments = "";
                }
                return _comments;
            }
            set
            {
                _comments = value;
                if(_comments==null)
                {
                    _comments = "";
                }
            }
        }

        public string clinicalFindings
        {
            get
            {
                if (_clinicalFindings == null)
                {
                    _clinicalFindings = "";
                }
                return _clinicalFindings;
            }
            set
            {
                _clinicalFindings = value;
                if (_clinicalFindings == null)
                {
                    _clinicalFindings = "";
                }
            }
        }
        public string diagnosis
        {
            get
            {
                if (_diagnosis == null)
                {
                    _diagnosis = "";
                }
                return _diagnosis;
            }
            set
            {
                _diagnosis = value;
                if (_diagnosis == null)
                {
                    _diagnosis = "";
                }
            }
        }
    }
}
