using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderlist = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);

            /**KEEP BELOW AS COMMENT**/

            /*clsOrderCollection DB = new clsOrderCollection();
            DB.Execute("sproc_tblOrder_SelectAll");
            PopulateArray(DB);
             Int32 Index = 0;
             Int32 RecordCount = 0;
             clsDataConnection DB = new clsDataConnection();
             DB.Execute("sproc_tblOrder_SelectAll");
             RecordCount = DB.Count;
             while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.TotalAmount = Convert.ToString(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.Quantity = Convert.ToString(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AnOrder.PaymentSuccessful = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentSuccessful"]);
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
            mOrderList.Add(TestItem);*/


            /* private void PopulateArray(clsDataConnection dB)
             {
                 throw new NotImplementedException();
             }*/
        }
        //List<clsOrder> mOrderList = new List<clsOrder>();
        //clsOrder mThisOrder = new clsOrder();
       
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.Date = Convert.ToDateTime(DB.DataTable.Rows[Index]["Date"]);
                AnOrder.TotalAmount = Convert.ToString(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.Quantity = Convert.ToString(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrder.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AnOrder.PaymentSuccessful = Convert.ToBoolean(DB.DataTable.Rows[Index]["PaymentSuccessful"]);
                mOrderList.Add(AnOrder);
                Index++;


            }
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
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("OrderId", mThisOrder.OrderId);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@PaymentSuccessful", mThisOrder.PaymentSuccessful);
            DB.AddParameter("@StaffId", mThisOrder.StaffId);
            DB.AddParameter("@StockId", mThisOrder.StockId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@Quantity", mThisOrder.Quantity);
            DB.AddParameter("@Date", mThisOrder.Date);
            DB.Execute("sproc_tblOrder_Update");
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.Execute("sproc_tblOrder_Delete");
        }
        List<clsOrder> mOrderList = new List<clsOrder>();
        public void ReportByQuantity(string Quantity)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Quantity", Quantity);
            DB.Execute("sproc_tblOrder_FilterByQuantity");
            PopulateArray(DB);
        }
        
    }
} 


