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

        public bool Find(int staffId)
        {
            mStaffId = 3;
            mDateAdded = Convert.ToDateTime("14/05/2024");
            mName = "DanGalby";
            mHours = "32";
            mPhoneNumber = "07453729171";
            mEmail = "D.Galb@hotmail.com";
            mFullTime = true;

            return true;
        }
    }
}