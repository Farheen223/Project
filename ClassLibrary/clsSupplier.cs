using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        // Private data member for the supplier ID property
        private Int32 mSupplierID;
        public Int32 SupplierID {
            get
            {
                // This line of code sends data out of the property
                return mSupplierID;
            }
            set
            {
                // This line of code allows data into the property
                mSupplierID = value;
            }
        }

        // Private data member for the name property
        private string mName;
        public string Name
        {
            get
            {
                // This line of code sends data out of the property
                return mName;
            }
            set
            {
                // This line of code allows data into the property
                mName = value;
            }
        }

        // Private data member for the city property
        private string mCity;
        public string City
        {
            get
            {
                // This line of code sends data out of the property
                return mCity;
            }
            set
            {
                // This line of code allows data into the property
                mCity = value;
            }
        }

        // Private data member for the email property
        private string mEmail;
        public string Email
        {
            get
            {
                // This line of code sends data out of the property
                return mEmail;
            }
            set
            {
                // This line of code allows data into the property
                mEmail = value;
            }
        }

        // Private data member for the telephone number property
        private string mTelephoneNumber;
        public string TelephoneNumber
        {
            get
            {
                // This line of code sends data out of the property
                return mTelephoneNumber;
            }
            set
            {
                // This line of code allows data into the property
                mTelephoneNumber = value;
            }
        }

        // Private data member for the supplier added date property
        private DateTime mAddDate;
        public DateTime AddDate
        {
            get
            {
                // This line of code sends data out of the property
                return mAddDate;
            }
            set
            {
                // This line of code allows data into the property
                mAddDate = value;
            }
        }

        // Private data member for the availability property
        private Boolean mAvailability;
        public bool Availability
        {
            get
            {
                // This line of code sends data out of the property
                return mAvailability;
            }
            set
            {
                // This line of code allows data into the property
                mAvailability = value;
            }
        }

        public bool Find(int supplierId)
        {
            // Create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            // Add the parameter for the supplier id to search for
            DB.AddParameter("@SupplierID", supplierId);
            // Execute the stored procedure
            DB.Execute("sproc_tblSupplier_FilterBySupplierId");

            // If one record is found (there should be either one or zero)
            if (DB.Count == 1)
            {
                // Copy the data from the database to the private data members
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["supplierId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["supplierName"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["supplierCity"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["supplierEmail"]);
                mTelephoneNumber = Convert.ToString(DB.DataTable.Rows[0]["supplierTelephoneNumber"]);
                mAddDate = Convert.ToDateTime(DB.DataTable.Rows[0]["supplierAddDate"]);
                mAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["supplierAvailability"]);

                // Return that everything worked OK
                return true;
            }
            // If no record found
            else
            {
                // Return false indicating there is a problem
                return false;
            }
        }

        public string Valid(string name, string city, string email, string telephoneNumber)
        {
            // Create a string variable to store the error
            String Error = "";

            //====================== Name ========================================
            // If the Name is blank or less than 3 characters
            if (name.Length == 0)
            {
                // Record the error
                Error = Error + "The supplier name may not be blank : ";
            }
            else if (name.Length < 3)
            {
                // Record the error
                Error = Error + "The supplier name may not be less than 3 characters : ";
            }

            // If the Name is greater than 50 characters
            if (name.Length > 50)
            {
                // Record the error
                Error = Error + "The supplier name must be less than 50 characters : ";
            }
            //=====================================================================

            //================== City =============================================
            // If City is blank or less than 3 characters
            if (city.Length == 0)
            {
                // Record the error
                Error = Error + "The city name may not be blank : ";
            }
            else if (city.Length < 3)
            {
                // Record the error
                Error = Error + "The city name may not be less than 3 characters : ";
            }

            // If the City is greater than 50 characters
            if (city.Length > 50)
            {
                // Record the error
                Error = Error + "The city name may not be greater than 50 characters : ";
            }
            //======================================================================

            //================ Email ===============================================
            // If Email is blank or less than 15 characters
            if (email.Length == 0)
            {
                // Record the error
                Error = Error + "The email may not be left blank : ";
            }
            //else if (email.Length < 15)
            //{
            //    // Record the error
            //    Error = Error + "The email may not be less than 15 characters : ";
            //}

            // If the email is greater than 50 characters
            if (email.Length > 50)
            {
                // Record the error
                Error = Error + "The email must be less than 50 characters : ";
            }

            //}
            //=====================================================================

            //=============== Telephone number ====================================
            // If telephone number is blank or less than 8 characters
            if (telephoneNumber.Length == 0)
            {
                // Record the error
                Error = Error + "The telephone number may not be left blank : ";
            }
            else if (telephoneNumber.Length < 8)
            {
                // Record the error
                Error = Error + "The telephone number may not be less than 8 characters : ";
            }

            // If the telephone number is greater than 15 characters
            if (telephoneNumber.Length > 15)
            {
                // Record the error
                Error = Error + "The telephone number must be less than 15 characters : ";
            }


            // Return any error messages
            return Error;
        }
    }
}