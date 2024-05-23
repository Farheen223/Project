using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
            // Variable for the index
            Int32 Index = 0;
            // Variable to store the record count
            Int32 RecordCount = 0;
            // Object for the data connection
            clsDataConnection DB = new clsDataConnection();
            // Execute the stored procedure
            DB.Execute("sproc_tblSupplier_SelectAll");
            // Get the count of records
            RecordCount = DB.Count;

            // While there are records to process
            while(Index < RecordCount)
            {
                // Create a blank supplier object
                clsSupplier supplier = new clsSupplier();
                // Read in the fields for the current record
                supplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["supplierId"]);
                supplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["supplierName"]);
                supplier.City = Convert.ToString(DB.DataTable.Rows[Index]["supplierCity"]);
                supplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["supplierEmail"]);
                supplier.TelephoneNumber = Convert.ToString(DB.DataTable.Rows[Index]["supplierTelephoneNumber"]);
                supplier.AddDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["supplierAddDate"]);
                supplier.Availability = Convert.ToBoolean(DB.DataTable.Rows[Index]["supplierAvailability"]);
                // Add the record to the private data member
                mSupplierList.Add(supplier);
                // Point at the next index
                Index++;
            }
        }

        // Private data member for supplier list
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        // Public property for supplier list
        public List<clsSupplier> SupplierList
        { 
            get
            { 
                // Return the private data
                return mSupplierList;
            } 
            set
            {
                // Set the private data
                mSupplierList = value;
            }
        }

        // Public property for count
        public int Count
        { 
            get
            {
                // Return the count of the list
                return SupplierList.Count;
            }
            set
            {
                // To be completed...
            }
        }

        // Private data member for ThisSupplier
        clsSupplier mThisSupplier = new clsSupplier();
        // Public property for ThisSupplier
        public clsSupplier ThisSupplier
        { 
            get
            {
                // Return the private data
                return mThisSupplier;
            }
            set
            {
                // Set the private data
                mThisSupplier = value;
            }

        }

        public int Add()
        {
            // Adds a record to the database based on the values of mThisAddress
            // Connect to the database
            clsDataConnection DB = new clsDataConnection();
            // Set the parameters for the stored procedure
            DB.AddParameter("@supplierName", mThisSupplier.Name);
            DB.AddParameter("@supplierCity", mThisSupplier.City);
            DB.AddParameter("@supplierEmail", mThisSupplier.Email);
            DB.AddParameter("@supplierTelephoneNumber", mThisSupplier.TelephoneNumber);
            DB.AddParameter("@supplierAddDate", mThisSupplier.AddDate);
            DB.AddParameter("@supplierAvailability", mThisSupplier.Availability);

            // Execute the query returning the primary key value
            return DB.Execute("sproc_tblSupplier_Insert");
        }
    }
}