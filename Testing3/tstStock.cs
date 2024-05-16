using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        
            //good test daTA
            //create some test data to pass the method
            string ItemID = "4";
            string SupplierID = "123";
            string ItemName = "tshirt";
            string ItemPrice = "10";
            string Description = "this is a shirt";
            string DateAdded = DateTime.Now.ToShortDateString();
        
            
        

        [TestMethod]
        public void TestMethod1()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);        
        } 
        

        [TestMethod] //sees if stock is active
        public void ActiveStockOK()
        {
            //create instance of class
            clsStock aStock = new clsStock();
            //create test data to assign to property
            Boolean testStock = true;
            //assin the data to the property
            aStock.inStock = testStock;
            //test to see that the two values are the same
            Assert.AreEqual(aStock.inStock, testStock);
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
        public void ItemIDOK()
        {
            clsStock aStock = new clsStock();
            Int32 TestData = 1;
            aStock.ItemID = TestData;
            Assert.AreEqual(aStock.ItemID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create instance
            clsStock aStock = new clsStock();
            //create bool variabkle to sotre validation results
            Boolean Found = false;
            //create test data
            Int32 ItemID = 4;
            //invoke method
            Found = aStock.Find(ItemID);
            //test to see if result is true
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestItemIDFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 4;
            Found = aStock.Find(ItemID);
            if (aStock.ItemID != 4) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        

        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 4;
            Found = aStock.Find(ItemID);


            if (aStock.SupplierID != 123)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemNameFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 4;
            Found = aStock.Find(ItemID);


            if (aStock.ItemName != "tshirt                                            ")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemPriceFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 4;
            Found = aStock.Find(ItemID);


            if (aStock.ItemPrice != 10)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestItemDescriptionFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 4;
            Found = aStock.Find(ItemID);


            if (aStock.Description != "this is a tshirt                                  ")
            {
                OK = false;
            }
            
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateOfDeliveryFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 4;
            Found = aStock.Find(ItemID);

            if (aStock.DateAdded != Convert.ToDateTime("23/12/2022"))
                {
                OK = false;

            }

            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void TestInStockFound()
        {
            clsStock aStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemID = 4;
            Found = aStock.Find(ItemID);


            if (aStock.inStock != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string variable to store any error message
            string Error = "";
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemNameMinLessOne()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string c variable to store any error message
            String Error = "";
            //create test data
            string ItemName = ""; // triggers error
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ItemNameMin()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string c variable to store any error message
            String Error = "";
            //create test data
            string ItemName = "a"; 
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string c variable to store any error message
            String Error = "";
            //create test data
            string ItemName = "aa"; // triggers error
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string c variable to store any error message
            String Error = "";
            //create test data
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // triggers error
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemNameMax()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string c variable to store any error message
            String Error = "";
            //create test data
            string ItemName = "12345678912345678912345678912345678912345678912345"; // triggers error
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemNameMid()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string c variable to store any error message
            String Error = "";
            //create test data
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaa"; // triggers error
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create instance
            clsStock aStock = new clsStock();
            //string c variable to store any error message
            String Error = "";
            //create test data
            string ItemName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; // triggers error
            //invoke method
            Error = aStock.Valid(ItemID, SupplierID, ItemName, ItemPrice, Description, DateAdded);
            //test to see the result is correct
            Assert.AreNotEqual(Error, "");

        }


    }
}
