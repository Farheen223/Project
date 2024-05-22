using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            // tesat to see it exists
            Assert.IsNotNull(allStock); 
        }

        [TestMethod]
        public void StockListOK() 
        {
            //create instance
            clsStockCollection allStock = new clsStockCollection();
            //create some test data
            //in this case a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add iten to list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.inStock = true;
            TestItem.ItemID = 1;
            TestItem.SupplierID = 1;
            TestItem.ItemPrice = 1;
            TestItem.ItemName = "a";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Description = "hello";
            //add the item to the testlist
            TestList.Add(TestItem);
            //assign the data to the property
            allStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStock.StockList, TestList);
        }

        

        [TestMethod]
        public void ThisStockPropertyOK() 
        {
            //create instance
            clsStockCollection allStock = new clsStockCollection();
            //create some test data
            clsStock TestStock = new clsStock();
            
            //set its properties
            TestStock.inStock = true;
            TestStock.ItemID = 1;
            TestStock.SupplierID = 1;
            TestStock.ItemPrice = 1;
            TestStock.ItemName = "a";
            TestStock.DateAdded = DateTime.Now;
            TestStock.Description = "hello";
            
            //assign the data to the property
            allStock.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(allStock.ThisStock, TestStock);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance
            clsStockCollection allStock = new clsStockCollection();
            //create some test data
            //in this case a list of objects
            List<clsStock> TestList = new List<clsStock>();
            //add iten to list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.inStock = true;
            TestItem.ItemID = 1;
            TestItem.SupplierID = 1;
            TestItem.ItemPrice = 1;
            TestItem.ItemName = "a";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Description = "hello";
            //add the item to the testlist
            TestList.Add(TestItem);
            //assign the data to the property
            allStock.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(allStock.Count, TestList.Count);

        }

        
    }
}
