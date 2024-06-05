using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    [TestClass]
    public class tstOrderCollection
    {
        public List<tstOrder> OrderList { get; set; }
        public int Count { get; set; }
        public clsOrder ThisOrder { get; set; }
        [TestMethod]
        public void TestMethod1()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.PaymentSuccessful = true;
            TestItem.OrderId = 1;
            TestItem.StaffId = 1;
            TestItem.StockId = 1;
            TestItem.Date = DateTime.Now;
            TestItem.CustomerId = 1;
            TestItem.Quantity = "10";
            TestItem.TotalAmount = "100";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.PaymentSuccessful = true;
            TestOrder.OrderId = 1;
            TestOrder.StaffId = 1;
            TestOrder.StockId = 1;
            TestOrder.Date = DateTime.Now;
            TestOrder.CustomerId = 1;
            TestOrder.Quantity = "10";
            TestOrder.TotalAmount = "100";
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.PaymentSuccessful = true;
            TestItem.OrderId = 1;
            TestItem.StaffId = 1;
            TestItem.StockId = 1;
            TestItem.Date = DateTime.Now;
            TestItem.CustomerId = 1;
            TestItem.Quantity = "10";
            TestItem.TotalAmount = "100";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.PaymentSuccessful = true;
            TestItem.OrderId = 1;
            TestItem.StaffId = 1;
            TestItem.StockId = 1;
            TestItem.Date = DateTime.Now;
            TestItem.CustomerId = 1;
            TestItem.Quantity = "10";
            TestItem.TotalAmount = "100";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.PaymentSuccessful = true;
            TestItem.OrderId = 1;
            TestItem.StaffId = 1;
            TestItem.StockId = 1;
            TestItem.Date = DateTime.Now;
            TestItem.CustomerId = 1;
            TestItem.Quantity = "10";
            TestItem.TotalAmount = "100";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            TestItem.PaymentSuccessful = false;
            TestItem.StaffId = 5;
            TestItem.CustomerId = 5;
            TestItem.Quantity = "50";
            TestItem.TotalAmount = "500";
            TestItem.Date = DateTime.Now;
            TestItem.StockId = 3;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.PaymentSuccessful = true;
            TestItem.OrderId = 1;
            TestItem.StaffId = 1;
            TestItem.StockId = 1;
            TestItem.Date = DateTime.Now;
            TestItem.CustomerId = 1;
            TestItem.Quantity = "10";
            TestItem.TotalAmount = "100";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void ReportByQuantityOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilterOrders = new clsOrderCollection();
            FilterOrders.ReportByQuantity(" ");
            Assert.AreNotEqual(AllOrders.Count, FilterOrders.Count);
        }
        [TestMethod]
        public void ReportByQuantityNoneFound()
        {
            clsOrderCollection FilterOrders = new clsOrderCollection();
            FilterOrders.ReportByQuantity("x");
            Assert.AreEqual(0, FilterOrders.Count);
        }
        [TestMethod]
        public void ReportByQuantityTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByQuantity("87");
            if (FilteredOrders.Count == 1)
            {
                if (FilteredOrders.OrderList[0].OrderId != 11)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderUser AnUser = new clsOrderUser();
            Assert.IsNotNull(AnUser);
        }
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 28);

        }
    }
} 
    

