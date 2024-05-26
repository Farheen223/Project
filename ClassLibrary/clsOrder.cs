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



        private string mStaffId;

        //staffId public property

        public string StaffId
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
                /****** FIND METHOD ******/
        public bool Find(int OrderId)
    {
        mOrderId = 1;
        mActive = true;
        mDate = Convert.ToDateTime("16/03/2024");
        mTotalAmount = 100;
        mStaffId = "Ok";
        mCustomerId = 1;
        mQuantity = 10;
        mStockId = 1;
        mPaymentSuccessful = true;
        return true;
    }
        public string Valid(string orderId, string quantity, string totalAmount, string date, string stockId, object paymentSuccussful, string customerId)
        {
            return "";
        }
    }
}

   