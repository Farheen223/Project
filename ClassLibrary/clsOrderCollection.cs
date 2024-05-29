using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderlist = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[0]["Date"]);
                AnOrder.TotalAmount = Convert.ToString(DB.DataTable.Rows[0]["TotalAmount"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                AnOrder.Quantity = Convert.ToString(DB.DataTable.Rows[0]["Quantity"]);
                AnOrder.StockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                AnOrder.PaymentSuccessful = Convert.ToBoolean(DB.DataTable.Rows[0]["PaymentSuccessful"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
            clsOrder TestItem = new clsOrder();
            TestItem.PaymentSuccessful = true;
            TestItem.OrderId = 1;
            TestItem.StaffId = 1;
            TestItem.StockId = 1;
            TestItem.Date = DateTime.Now;
            TestItem.CustomerId = 1;
            TestItem.Quantity = "10";
            TestItem.TotalAmount = "100";
            mOrderList.Add(TestItem);
            TestItem = new clsOrder();
            TestItem.PaymentSuccessful = true;
            TestItem.OrderId = 1;
            TestItem.StaffId = 1;
            TestItem.StockId = 1;
            TestItem.Date = DateTime.Now;
            TestItem.CustomerId = 1;
            TestItem.Quantity = "10";
            TestItem.TotalAmount = "100";
            mOrderList.Add(TestItem);
        }
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }

        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {
                // do later
            }

        }
        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public int SomeCount { get; set; }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@PaymentSuccessful", mThisOrder.PaymentSuccessful);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@StockId", mThisOrder.StockId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@Date", mThisOrder.Date);
            
            return DB.Execute("sproc_tblOrder_Insert");
        }
        List<clsOrder> mOrderList = new List<clsOrder>();
    }

}
