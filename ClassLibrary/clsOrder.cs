using System;
using System.Collections;

namespace ClassLibrary
{
    public class clsOrder
    {
        private int mOrderId;

        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }


        private bool mActive;

        //Active public property

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }




        private DateTime mDate;

        //Date public property

        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }

        private Int32 mTotalAmount;

        //total amount public property

        public Int32 TotalAmount
        {
            get
            {
                return mTotalAmount;
            }
            set
            {
                mTotalAmount = value;
            }
        }

        private Int32 mStaffId;

        //staffId public property

        public Int32 StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        private Int32 mCustomerId;

        //customerId public property

        public Int32 CustomerId
        {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        private Int32 mQuantity;

        //quantity public property

        public Int32 Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }

        private Int32 mStockId;

        //stockId public property

        public Int32 StockId
        {
            get
            {
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }

        private bool mPaymentSuccessful;

        //Payment Sucessful public property

        public bool PaymentSuccessful
        {
            get
            {
                return mPaymentSuccessful;
            }
            set
            {
                mPaymentSuccessful = value;
            }
        }
        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            {
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mTotalAmount = Convert.ToInt32(DB.DataTable.Rows[0]["TotalAmount"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
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
            public string Valid(string orderId, string quantity, string totalAmount, string date, string stockId, object paymentSuccussful, string customerId)
            
           {
               return "";
            }
        }
    } 

    

   