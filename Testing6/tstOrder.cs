using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing6
{

    [TestClass]
    public class tstOrder
    {
        string OrderId = "1";
        string CustomerId = "1";
        string Date = DateTime.Now.ToShortDateString();
        string Quantity = "10";
        string TotalAmount = "100";
        string StaffId = "";
        string PaymentSuccessful = "True";
        string StockId = "1";

        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCustomerIdNoFound()
        {

            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Date != Convert.ToDateTime("16/03/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.StaffId != ("Ok"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPaymentSuccessfulFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.PaymentSuccessful != (true))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestTotalAmountFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.TotalAmount != (100))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Quantity != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            bool Found = false;
            Int32 OrderId = 1;
            Boolean OK = true;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.StockId != (1))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(OrderId, Quantity, TotalAmount, Date, StockId, PaymentSuccessful, CustomerId);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]

        public void ActiveOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Active = TestData;
            Assert.AreEqual(AnOrder.Active, TestData);
        }


        public void DateOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.Date = TestData;
            Assert.AreEqual(AnOrder.Date, TestData);


        }

        [TestMethod]
        public void OrderIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void TotalAmountOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.TotalAmount = TestData;
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }
        [TestMethod]
        public void StaffIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "1";
            AnOrder.StaffId = TestData;
            Assert.AreEqual(AnOrder.StaffId, TestData);
        }
        [TestMethod]
        public void CustomerIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }
        [TestMethod]
        public void QuantityOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 10;
            AnOrder.Quantity = TestData;
            Assert.AreEqual(AnOrder.Quantity, TestData);
        }
        [TestMethod]
        public void StockIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.StockId = TestData;
            Assert.AreEqual(AnOrder.StockId, TestData);
        }
        [TestMethod]
        public void PaymentSuccesfulOK()
        {
            clsOrder AnOrder = new clsOrder();
            bool TestData = true;
            AnOrder.PaymentSuccessful = TestData;
            Assert.AreEqual(AnOrder.PaymentSuccessful, TestData);
        }


        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);
        }

        // ***VALIDATION***//
        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalAmount = "";
            Error = AnOrder.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreEqual(Error, "");
        
        }
        [TestMethod]
        public void TotalAmountMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalAmount = "a";
            Error = AnOrder.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalAmount = "aa";
            Error = AnOrder.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalAmount = "aaaaa";
            Error = AnOrder.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreEqual(Error, "");
        }
        public void TotalAmountMax()
        {
            clsOrder AnAddress = new clsOrder();
            String Error = "";
            string TotalAmount = "aaaaaa";
            Error = AnAddress.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMid()
        {
            clsOrder AnAddress = new clsOrder();
            String Error = "";
            string TotalAmount = "aaa";
            Error = AnAddress.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalAmount = "aaaaaaa";
            Error = AnOrder.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TotalAmountExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TotalAmount = "";
            TotalAmount = TotalAmount.PadRight(500, 'a'); // this should fail
            Error = AnOrder.Valid(TotalAmount, StaffId, CustomerId, Date, Quantity, StockId);
            Assert.AreNotEqual(Error, "");
        }
    
        [TestMethod]
        public void DateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string Date = TestDate.ToString();
            Error = AnOrder.Valid(Date, StaffId, CustomerId, Quantity, StockId, TotalAmount);
            Assert.AreNotEqual(Error, "");
        }
    }
}

        



    

