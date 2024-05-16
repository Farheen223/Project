using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        //private data member
        private Int32 mStaffId;

        //public property
        public Int32 StaffId
        {
            get
            {
                //sending data out of the property
                return mStaffId;
            }
            set
            {
                //Allows data into the property
                mStaffId = value;
            }
        }


        private Boolean mFullTime;
        public bool FullTime
        {
            get
            {
                return mFullTime;

            }

            set
            {
                mFullTime = value;
            }
        }

        private DateTime mDateAdded;

        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }

        private String mName;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        private String mEmail;

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        private String mPhoneNumber;
        public string PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        private String mHours;
        public string Hours 
        { get
            {
                return mHours;
            }
          set
            {
                mHours = value;
            }
          }

        public bool Find(int StaffId)
        {
            //create instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address id
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            //if one record is found 
            if (DB.Count == 1)
            {
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["AccountCreated"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                mHours = Convert.ToString(DB.DataTable.Rows[0]["HoursWorked"]);
                mPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mFullTime = Convert.ToBoolean(DB.DataTable.Rows[0]["FullTime"]);
                return true;
            }

            else
            {
                return false;
            }
            
        }


        public string Valid(string name, string hours, string phoneNumber, string email, string dateAdded)
        {
            //create variable to store error
            String Error = "";
            //create temporary variable to store date 
            DateTime DateTemp;
            //if name is blank
            if (name.Length == 0)
            {
                Error = Error + "The name may not be blank : ";

            }

            if (name.Length > 50)
            {
                Error = Error + "The Name must be less than 50 characters: ";
            }

            DateTime DateComp = DateTime.Now.Date;

            try
            {

                //copy date added value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }

                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";

                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }
    }
}