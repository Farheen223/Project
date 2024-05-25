using System;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class clsCustomer
    {

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

        private string mCustomerSurname;
        public string CustomerSurname
        {
            get
            {
                return mCustomerSurname;
            }
            set
            {
                mCustomerSurname = value;
            }
        }


        private string mContactNumber;
        public string ContactNumber
        {
            get
            {
                return mContactNumber;
            }
            set
            {
                mContactNumber = value;
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
       

        public bool Find(int CustomerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the Customer id to search for
            DB.AddParameter("@CustomerId", CustomerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found (there should be either 1 or zero)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mCustomerSurname = Convert.ToString(DB.DataTable.Rows[0]["CustomerSurname"]);
                mContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);

                return true;

            }
           
            else
            {
                return false;
            }
        }

        public string Valid(string customerName, string customerSurname,string email, string dateAdded, string contactNumber)
        {
            String Error = "";
            DateTime DateTemp;


            if (customerName.Length == 0)
            {
                Error = Error + "The name may not be blank :";
            }
            if (customerName.Length>50)
            {
                Error = Error + "The CustomerName must be less then 50 :";
            }

            if (contactNumber.Length == 0)
            {
                Error = Error + "The name may not be blank :";
            }
            if (contactNumber.Length > 50)
            {
                Error = Error + "The CustomerName must be less then 50 :";
            }

            if (customerSurname.Length == 0)
            {
                Error = Error + "The name may not be blank :";
            }
            if (customerSurname.Length > 50)
            {
                Error = Error + "The CustomerName must be less then 50 :";
            }

            if (email.Length == 0)
            {
                Error = Error + "The name may not be blank :";
            }
            if (email.Length > 50)
            {
                Error = Error + "The CustomerName must be less then 50 :";
            }


            DateTime DateComp = DateTime.Now.Date;
            try
            {
                DateTemp = Convert.ToDateTime(dateAdded);


                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past :";
                }
                if (DateTemp > DateComp)
                {

                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                Error = Error + "The date was not valid date :";
            }
            return Error;
        }

    }
}