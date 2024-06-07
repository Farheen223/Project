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

        
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the cl;ass
            clsStockCollection allStock = new clsStockCollection();
            //create test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.inStock = true;
            TestItem.ItemID = 1;
            TestItem.ItemName= "tshirt";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Description = "hello";
            TestItem.ItemPrice = 1;
            TestItem.SupplierID= 1;
            //set thisstock to test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set the primary key of the test dATA
            TestItem.ItemID = PrimaryKey;
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(allStock.ThisStock, TestItem);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the cl;ass
            clsStockCollection allStock = new clsStockCollection();
            //create test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.inStock = true;
            TestItem.ItemID = 1;
            TestItem.ItemName = "tshirt";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Description = "hello";
            TestItem.ItemPrice = 1;
            TestItem.SupplierID = 1;
            //set thisstock to test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set the primary key of the test dATA
            TestItem.ItemID = PrimaryKey;
            //modify the test record
            TestItem.inStock = false;
            TestItem.ItemName = "rainbow tshirt";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Description = "this is a rainbow tshirt";
            TestItem.ItemPrice = 15;
            TestItem.SupplierID = 15;
            //set the record based on the new test data
            allStock.ThisStock = TestItem;
            //update the record
            allStock.Update();
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.AreEqual(allStock.ThisStock, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the cl;ass
            clsStockCollection allStock = new clsStockCollection();
            //create test data
            clsStock TestItem = new clsStock();
            //variable to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.inStock = true;
            TestItem.ItemID = 1;
            TestItem.ItemName = "tshirt";
            TestItem.DateAdded = DateTime.Now;
            TestItem.Description = "hello";
            TestItem.ItemPrice = 1;
            TestItem.SupplierID = 1;
            //set thisstock to test data
            allStock.ThisStock = TestItem;
            //add the record
            PrimaryKey = allStock.Add();
            //set the primary key of the test dATA
            TestItem.ItemID = PrimaryKey;
            //find the record
            allStock.ThisStock.Find(PrimaryKey);
            allStock.Delete();
            Boolean Found = allStock.ThisStock.Find(PrimaryKey);
            //test to see the two values are the same
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void ReportByItemNameMethodOK()
        {
            clsStockCollection allStocks = new clsStockCollection();
            clsStockCollection FilteredItems = new clsStockCollection();
            FilteredItems.ReportByItemName("");
            Assert.AreEqual(allStocks.Count, FilteredItems.Count);
        }

        [TestMethod]
        public void ReportByItemNameNoneFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            FilteredStock.ReportByItemName("pink tshirt");
            Assert.AreEqual(0, FilteredStock.Count);
        }

        [TestMethod]
        public void ReportByItemNameTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;
            FilteredStock.ReportByItemName("tshirt");
            if (FilteredStock.Count == 2) 
            { 
                if (FilteredStock.StockList[0].ItemID != 4) 
                { 
                    OK = false;
                }
                if (FilteredStock.StockList[1].ItemID != 5)
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

        
    }
}
