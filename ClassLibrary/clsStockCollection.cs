
using System;
using System.Collections.Generic;
namespace ClassLibrary

{
    public class clsStockCollection
    {
        //private data member for the list
        List<clsStock> mStockList = new List<clsStock>();
        //private data member for thisstock
        clsStock mThisStock = new clsStock();

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
        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }

            set
            {
                //set the rpivate data
                mThisStock = value;
            }
        }

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

        public int Add()
        {
            //adds a record to the database based on the values of mthisstock
            //connect to the dataBASE
            clsDataConnection DB = new clsDataConnection();
            //set the parAMEters for the stored procedures
            DB.AddParameter("@ItemPrice", mThisStock.ItemPrice);
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@inStock", mThisStock.inStock);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);

            //execute the query returmnimng the primary key value
            return DB.Execute("sproc_tblStock_Insert");
        }
    }


  


}