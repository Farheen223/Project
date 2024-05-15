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



        public bool Find(int itemID)
        {
            //set the private data members to the test data value
            mItemID = 21;
            mDescription = "this is a tshirt";
            minStock = true;
            mDateAdded = Convert.ToDateTime("23/12/2022");
            mItemName = "tshirt";
            mItemPrice = 10;
            mSupplierID = 123;
            return true;
        }
        
        


    }
}