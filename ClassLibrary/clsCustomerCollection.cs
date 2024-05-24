using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList 
        { 
            get
            {  return mCustomerList; }
            set
            {  mCustomerList = value; }
        
        }
        public clsCustomer ThisCustomer 
        { get
            {  return mThisCustomer; }
          set 
            { mThisCustomer = value; }

        }


        public int Count 
        {
            get

            { return mCustomerList.Count; }
    
            set
            {
                //We shall worry about this later
            }
        
      
        }
       

        public clsCustomerCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCustomer AnCustomer = new clsCustomer();
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                AnCustomer.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnCustomer.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnCustomer.CustomerSurname = Convert.ToString(DB.DataTable.Rows[Index]["CustomerSurname"]);
                AnCustomer.Email = Convert.ToString (DB.DataTable.Rows[Index]["Email"]);
                AnCustomer.ContactNumber = Convert.ToString (DB.DataTable.Rows[Index]["ContactNumber"]);
                AnCustomer.DateAdded = Convert.ToDateTime (DB.DataTable.Rows[Index]["DateAdded"]);
                mCustomerList.Add(AnCustomer);
                Index++;
            }


        }

        public int Add()
        {
            mThisCustomer.CustomerId = 123;
            return mThisCustomer.CustomerId;
        }
    }
   
}