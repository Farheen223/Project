using System;
using System.Collections;

namespace ClassLibrary
{
    public class clsOrder
    {
        //public int OrderId { get; set; }
        //public bool Active  { get; set; }
        //public DateTime Date    { get; set; }
        //public int TotalAmouunt   { get; set; }
        //public string StaffId { get; set; }
        //public int CustomerId { get; set; }
        //public int StockId { get; set; }
        //public bool PaymentSucessful { get; set; }


        //private data member for the order id property
        private int mOrderId;

        //orderId public property
        //public int OrderId { get; set; }
        // **public could be string or (pref) Int **
        public int OrderId
        {
            get
            {
                //this line of code sends data out of the property
                return mOrderId;
            }
            set
            {
                //this line of code allows data into the property
                mOrderId = value;
            }
        }


        private bool mActive;

        //Active public property

        public bool Active
        {
            get
            {
                //this line of code sends data out of the property
                return mActive;
            }
            set
            {
                //this line of code allows data into the property
                mActive = value;
            }
        }




        private DateTime mDate;

        //Date public property

        public DateTime Date
        {
            get
            {
                //this line of code sends data out of the property
                return mDate;
            }
            set
            {
                //this line of code allows data into the property
                mDate = value;
            }
        }

        private Int32 mTotalAmount;

        //total amount public property

        public Int32 TotalAmount
        {
            get
            {
                //this line of code sends data out of the property
                return mTotalAmount;
            }
            set
            {
                //this line of code allows data into the property
                mTotalAmount = value;
            }
        }



        private string mStaffId;

        //staffId public property

        public string StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }
            set
            {
                //this line of code allows data into the property
                mStaffId = value;
            }
        }

        private Int32 mCustomerId;

        //customerId public property

        public Int32 CustomerId
        {
            get
            {
                //this line of code sends data out of the property
                return mCustomerId;
            }
            set
            {
                //this line of code allows data into the property
                mCustomerId = value;
            }
        }

        private Int32 mQuantity;

        //quantity public property

        public Int32 Quantity
        {
            get
            {
                //this line of code sends data out of the property
                return mQuantity;
            }
            set
            {
                //this line of code allows data into the property
                mQuantity = value;
            }
        }

        private Int32 mStockId;

        //stockId public property

        public Int32 StockId
        {
            get
            {
                //this line of code sends data out of the property
                return mStockId;
            }
            set
            {
                //this line of code allows data into the property
                mStockId = value;
            }
        }

        private bool mPaymentSuccessful;

        //Payment Sucessful public property

        public bool PaymentSuccessful
        {
            get
            {
                //this line of code sends data out of the property
                return mPaymentSuccessful;
            }
            set
            {
                //this line of code allows data into the property
                mPaymentSuccessful = value;
            }
        }


        /****** FIND METHOD ******/
        /*public bool Find(int OrderId)
           {
               //set the private data members to the test data value
               mOrderId = 1;
               mActive = true;
               mDate = Convert.ToDateTime("16/03/2024");
               mTotalAmount = 100;
               mStaffId = "Ok";
               mCustomerId = "1";
               mQuantity = "1";
               mStockId = "1";
               mPaymentSuccessful = true;
               return true;
           }
        }
        }*/

        /****** FIND METHOD ******/

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mTotalAmount = Convert.ToInt32(DB.DataTable.Rows[0]["TotalAmount"]);
                mStaffId = Convert.ToString(DB.DataTable.Rows[0]["StaffId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mPaymentSuccessful = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentSuccessful"]);

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}