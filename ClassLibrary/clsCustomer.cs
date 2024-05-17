using System;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //public bool Active { get; set; }
        //public DateTime DateOfBirth { get; set; }
       // public string CustomerName { get; set; }
        //public string Email { get; set; }

        public bool Find(int customerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            //if one record is found (there should be either 1 or zero)
            if(DB.Count ==1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);

                return true;

            }
            //set the private data members to the test data value
            //mCustomerId = 1;
            //mDateOfBirth = Convert.ToDateTime("03/05/2002");
            //mCustomerName = "Timmy";
            //mEmail = "Timmy23@outlook.com";
            //mActive = true;
            //always return true
            else
            {
                return false;
            }
        }

        //private data member for the address id property
        private Int32 mCustomerId;
        //customer id public property
        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data into property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property 
                mCustomerId = value;
            }
        }


        private DateTime mDateOfBirth;
        public DateTime DateOfBirth
        {
            get
            {
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
            }
        }
        private string mCustomerName;
        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }

        private string mEmail;
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
        private Boolean mActive;
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
    }
}