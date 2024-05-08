using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);        
        } 
        
        //itemid int,
        //
        //
        //supplierid int,
        //
        //
        //itemname char,
          //
          //
          //
          //itemprice int,
          //
          //
          //
          //itemdescription string,
          //
          //
          //
          //
          //dateofdelivery date

        [TestMethod] //sees if stock is active
        public void ActiveStockOK()
        {
            //create instance of class
            clsStock aStock = new clsStock();
            //create test data to assign to property
            Boolean testStock = true;
            //assin the data to the property
            aStock.Active = testStock;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.Active, testStock);
        }

        [TestMethod]  //date stock added
        public void DateAddedStockOK() 
        {  
            clsStock aStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            aStock.DateAdded = TestData;
            Assert.AreEqual(aStock.DateAdded, TestData);
        
        }


        [TestMethod]
        public void ItemDescriptionOK() 
        {
            clsStock aStock = new clsStock();
            string TestData = "Some description";
            aStock.Description = TestData;
            Assert.AreEqual(aStock.Description, TestData);


        }

        [TestMethod]
        public void ItemPriceOK() 
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.ItemPrice = TestData;
            Assert.AreEqual(aStock.ItemPrice, TestData);
        
        }

        [TestMethod]
        public void ItemNameOK() 
        {
            clsStock aStock = new clsStock();
            string TestData = "Some name";
            aStock.ItemName = TestData;
            Assert.AreEqual(aStock.ItemName, TestData);
        
        }

        [TestMethod]
        public void SupplierIDOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.SupplierID = TestData;
            Assert.AreEqual(aStock.SupplierID, TestData);
        }

        [TestMethod]
        public void ItemIdOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.ItemId = TestData;
            Assert.AreEqual(aStock.ItemId, TestData);
        }

    }
}
