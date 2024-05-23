using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {
        public clsSupplierCollection()
        {
            //// Create the items of the test data
            //clsSupplier TestItem = new clsSupplier();
            //// Set it properties
            //TestItem.SupplierID = 1;
            //TestItem.Name = "TestSupplier";
            //TestItem.City = "Manchester";
            //TestItem.Email = "supplier@gmail.com";
            //TestItem.TelephoneNumber = "075495837291";
            //TestItem.AddDate = DateTime.Now;
            //TestItem.Availability = true;
            //// Add the test item to the test list
            //mSupplierList.Add(TestItem);
            //// Reinitialise the object for some new data
            //TestItem = new clsSupplier();
            //// Set its properties
            //TestItem.SupplierID = 2;
            //TestItem.Name = "TestSupplier2";
            //TestItem.City = "Nottingham";
            //TestItem.Email = "supplier2@gmail.com";
            //TestItem.TelephoneNumber = "079385271492";
            //TestItem.AddDate = DateTime.Now;
            //TestItem.Availability = false;
            //// Add the item to the test list
            //mSupplierList.Add(TestItem);

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
        public clsSupplier ThisSupplier { get; set; }
    }
}