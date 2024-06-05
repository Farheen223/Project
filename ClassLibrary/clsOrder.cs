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

        private String mTotalAmount;

        //total amount public property

        public string TotalAmount
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

        private String mQuantity;

        //quantity public property

        public string Quantity
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
                //mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                mTotalAmount = Convert.ToString(DB.DataTable.Rows[0]["TotalAmount"]);
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mQuantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mPaymentSuccessful = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentSuccessful"]);
                return true;
            }
            else
            {
                return false;


            }
        }
        public string Valid(string totalAmount, string date, string quantity)
        {
            String Error = "";
            DateTime DateTemp;
            if (totalAmount.Length == 0)
            {
                Error = Error + " The Total Amount may not be blank: ";
            }
            if (totalAmount.Length > 6)
            {
                Error = Error + "The Total Amount must be less than 6 Characters: ";
            }
            if (quantity.Length == 0)
            {
                Error = Error + " The Quantity may not be blank: ";
            }
            if (quantity.Length > 9)
            {
                Error = Error + "The Quantity must be less than 6 Characters: ";
            }
            DateTime DateComp = DateTime.Now.Date;

            try
            {

                DateTemp = Convert.ToDateTime(date);
                if (DateTemp < DateComp)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateComp)
                {
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            return Error;
        }

        public string Valid(string totalAmount, string staffId, string customerId, string date, string quantity, string stockId)
        {
            return "";
        }

        public string Valid(string totalAmount, string date, string quantity, string customerId, string stockId)
        {
            throw new NotImplementedException();
        }

        public void Find(object orderId)
        {
            throw new NotImplementedException();
        }
        /*    public bool Find(string orderId)
{
throw new NotImplementedException();
}*/
    }
}