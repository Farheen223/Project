using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing6
{
    [TestClass]
    public class tstOrderCollection
    {
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
        /*[TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Int32 SomeCount = 2;
            AllOrders.Count = SomeCount;
            Assert.AreEqual(AllOrders.SomeCount, SomeCount);
        }*/
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
      /*  [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.AreEqual(AllOrders.Count, 2);
        }*/
    }
}
