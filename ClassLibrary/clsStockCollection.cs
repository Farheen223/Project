using System.Collections.Generic;
using System;

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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);
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

        public void Update()
        {
            //update existinfg record based on the values of thisaddress
            //connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the new stored procedure
            DB.AddParameter("@ItemPrice", mThisStock.ItemPrice);
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Description", mThisStock.Description);
            DB.AddParameter("@inStock", mThisStock.inStock);
            DB.AddParameter("@DateAdded", mThisStock.DateAdded);
            DB.AddParameter("@SupplierID", mThisStock.SupplierID);
            DB.AddParameter("@ItemID", mThisStock.ItemID);

            //execute stored procedure
            DB.Execute("sproc_tblStock_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemID", mThisStock.ItemID);
            DB.Execute("sproc_tblStock_Delete");

        }

        public void ReportByItemName(string ItemName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemName", ItemName);
            DB.Execute("sproc_tblStock_FilterByItemName");
            PopulateArray(DB);
        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();
            while (Index < RecordCount)
            {
                clsStock aStock = new clsStock();
                aStock.ItemID = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemID"]);
                aStock.Description = Convert.ToString(DB.DataTable.Rows[Index]["Description"]);
                aStock.inStock = Convert.ToBoolean(DB.DataTable.Rows[Index]["inStock"]);
                aStock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                aStock.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                aStock.ItemPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemPrice"]);
                aStock.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);

                mStockList.Add(aStock);
                Index++;
            }
        }
    }
}