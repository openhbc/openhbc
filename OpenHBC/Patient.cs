using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OpenHBC
{
    public class Patient
    {
        private int _patientId;
        private string _firstname;
        private string surname;
        private string _middle_name;
        private DateTime _dateofbirth;
        private string _sex;
        private string _compound;
        private string _nrc_number;
        private string _position_in_family;
        private string _parish;
        private string _section;
        private int _number_of_children;
        private string _bread_winner;
        private string _marital_status;
        private DateTime _assesment_date;
        private ArrayList _visits;
        private ArrayList children_details;
        private string _religion;
        
        

        public Patient()
        {
            
        }

        public Patient(int patId, string firstname,string surname,string middlename,DateTime dateofbirth,string sex, string location,string nrc_number,string positionInFamily,string parish,string section,string breadwinner,int numberofchildren,string maritalstatus,DateTime assessmentDate ,string religion)
        {
            this._patientId = patId;
            this._firstname = firstname;
            this.surname = surname;
            this._middle_name = middlename;
            this._dateofbirth = dateofbirth;
            this._compound = location;
            //this.visits = visits;
            this._sex = sex;
            this._position_in_family = positionInFamily;
            this.Parish = parish;
            this.Section = section;
            this.BreadWinner = breadwinner;
            this.NumberOfChildren = numberofchildren;
            this.MaritalStatus = maritalstatus;
            this.AssesmentDate = assessmentDate;
            this._nrc_number = nrc_number;
            this._religion = religion;

        }

        public Patient(int patId, string firstname, string surname, string middlename, DateTime dateofbirth, string sex, string location, string nrc_number, string positionInFamily, string parish, string section, string breadwinner, int numberofchildren, string maritalstatus, DateTime assessmentDate, ArrayList visits, string religion)
        {
            this._patientId = patId;
            this._firstname = firstname;
            this.surname = surname;
            this._middle_name = middlename;
            this._dateofbirth = dateofbirth;
            this._compound = location;
            //this.visits = visits;
            this._sex = sex;
            this._position_in_family = positionInFamily;
            this.Parish = parish;
            this.Section = section;
            this.BreadWinner = breadwinner;
            this.NumberOfChildren = numberofchildren;
            this.MaritalStatus = maritalstatus;
            this.AssesmentDate = assessmentDate;
            this._nrc_number = nrc_number;
            this.Visits = visits;
            this._religion = religion;

        }




        public int  PatientId
        {
            get
            {
                return _patientId;
            }
            set
            {
                _patientId = value;
                //if(patientId==null)
                //{
                //    patientId = "";
                //}
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
                if(_firstname ==null)
                {
                    _firstname = "";
                }
            }
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                if(surname == null)
                {
                    surname = "";
                }
            }
        }
        public string MiddleName
        {
            get
            {
                return _middle_name;
            }
            set
            {
                _middle_name = value;
                if(_middle_name==null)
                {
                    _middle_name = "";
                }
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return _dateofbirth;
            }
            set
            {
                _dateofbirth = value;
                if(_dateofbirth==null)
                {
                    _dateofbirth = DateTime.Parse("01-01-1900");
                }
                
            }
        }
        public string Sex
        {
            get
            {
                return _sex;
            }
            set
            {
                _sex = value;
            }
        }
        public string Compound
        {
            get
            {
                return _compound;
            }
            set
            {
                _compound = value;
            }
        }
        public string NrcNumber
        {
            get
            {
                return _nrc_number;
            }
            set
            {
                _nrc_number = value;
            }
        }
        public string PositionInFamily
        {
            get
            {
                return _position_in_family;
            }
            set
            {
                _position_in_family = value;
            }
        }
        public string Parish
        {
           get
           {
               return _parish;
           }
            set
            {
                _parish = value;
            }
        }
        public string Section
        {
            get
            {
                return _section;
            }
            set
            {
                _section = value;
            }
        }
        public int NumberOfChildren
        {
            get
            {
                return _number_of_children;
            }
            set
            {
                _number_of_children = value;
            }
        }
        public  string MaritalStatus
        {
            get
            {
                return _marital_status;
            }
            set
            {
                _marital_status = value;
            }
        }
        public string  BreadWinner
        {
            get
            {
                return _bread_winner;
            }
            set
            {
                _bread_winner = value;
            }
        }
        public DateTime AssesmentDate
        {
            get
            {
                return _assesment_date;
            }
            set
            {
                _assesment_date = value;
                if(_assesment_date==null)
                {
                    _assesment_date = DateTime.Parse("01-01-1900");
                }
            }
        }
        public ArrayList Visits
        {
            get
            {
                if(_visits==null)
                {
                    _visits = new ArrayList();
                }
                return _visits;
            }
            set
            {
                _visits = value;
            }
        }
        public ArrayList ChildrenDetails
        {
            get
            {
                return children_details;
            }
            set
            {
                children_details = value;
            }
        }
        public string Religion
        {
            get
            {
                return _religion;
            }
            set
            {
                _religion = value;
            }
        }

    }
}
