using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Threading;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mItemID;
        private String mDescription;
        private DateTime mDateAdded;
        private Boolean minStock;
        private int mItemPrice;
        private string mItemName;
        private int mSupplierID;

        public Int32 ItemID
        {
            get
            {
                return mItemID;
            }

            set
            {
                mItemID = value;
            }
        }
        public String Description
        {
            get
            {
                return mDescription;
            }

            set
            {
                mDescription = value;
            }
        }
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
        public int ItemPrice
        {
            get
            {
                return mItemPrice;
            }

            set
            {
                mItemPrice = value;
            }
        }
        public Boolean inStock
        {
            get
            {
                return minStock;
            }

            set
            {
                minStock = value;
            }
        }
        public String ItemName
        {
            get
            {
                return mItemName;
            }

            set
            {
                mItemName = value;
            }
        }
        public int SupplierID
        {
            get
            {
                return mSupplierID;
            }

            set
            {
                mSupplierID = value;
            }
        }



        public bool Find(int ItemID)
        {

            //create instance of data  connection
            clsDataConnection DB = new clsDataConnection();
            //add parameter for the item id to search for
            DB.AddParameter("@ItemID", ItemID);
            //execute stored procedure
            DB.Execute("sproc_tblStock_FilterByItemID");
            //iuf one record is found 
            if (DB.Count == 1)
            {
                
                //set the private data members to the test data value
                mItemID = Convert.ToInt32(DB.DataTable.Rows[0]["ItemID"]);
                mDescription = Convert.ToString(DB.DataTable.Rows[0]["Description"]);
                minStock = Convert.ToBoolean(DB.DataTable.Rows[0]["inStock"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemPrice = Convert.ToInt32(DB.DataTable.Rows[0]["ItemPrice"]);
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                return true;




            }

            else
            {
                return false;
            }
            
        }
        
        


    }
}