
using System;
using System.Collections.Generic;
namespace ClassLibrary

{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();

        public List<clsStock> StockList 
        { 
            get
            {
                return mStockList;
            }

            set
            {
                mStockList = value;
            }
        }
        public int Count 
        {
            get
            {
                return mStockList.Count;
            }
            set 
            {

                
            }
        }
        public clsStock ThisStock { get; set; }

//constructor for the class
        public clsStockCollection()
        {
            //variable for the index
            Int32 Index = 0;
            //variable to store the record count
            Int32 RecordCount = 0;
            //object for the data connect
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while (Index < RecordCount) 
            {
                //create a blank address
                clsStock aStock = new clsStock();
                //read in the fields for the current record
                aStock.ItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemID"]);
                aStock.Description = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                aStock.inStock = Convert.ToBoolean(DB.DataTable.Rows[0]["inStock"]);
                aStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                aStock.ItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                aStock.ItemPrice = Convert.ToInt32(DB.DataTable.Rows[0]["ItemPrice"]);
                aStock.SupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                //add the record to the private data member
                mStockList.Add(aStock);
                //point at next record
                Index++;
            }
        }
    }


  


}