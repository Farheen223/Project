using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing5
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class we want to create
            clsSupplierCollection allSuppliers = new clsSupplierCollection();
            // Test to see that it exists
            Assert.IsNotNull(allSuppliers);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            // Create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            // Create some test data to assign to the property
            // In this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();

            // Add an item to the List
            // Create the item of test data
            clsSupplier TestItem = new clsSupplier();
            // Set its properties
            TestItem.SupplierID = 7;
            TestItem.Name = "TestSupplier";
            TestItem.City = "Manchester";
            TestItem.Email = "supplier@gmail.com";
            TestItem.TelephoneNumber = "075495837291";
            TestItem.AddDate = DateTime.Now;
            TestItem.Availability = true;
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllSuppliers.SupplierList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.SupplierList, TestList);
        }

        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            // Create some test data to assign to the property
            clsSupplier TestSupplier = new clsSupplier();

            // Set the properties of the test object
            TestSupplier.SupplierID = 7;
            TestSupplier.Name = "TestSupplier";
            TestSupplier.City = "Manchester";
            TestSupplier.Email = "supplier@gmail.com";
            TestSupplier.TelephoneNumber = "075495837291";
            TestSupplier.AddDate = DateTime.Now;
            TestSupplier.Availability = true;
            // Assign the data to the property
            AllSuppliers.ThisSupplier = TestSupplier;
            // Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestSupplier);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            // Create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            // Create some test data to assign to the property
            // In this case the data needs to be a list of objects
            List<clsSupplier> TestList = new List<clsSupplier>();

            // Add an item to the List
            // Create the item of test data
            clsSupplier TestItem = new clsSupplier();
            // Set its properties
            TestItem.SupplierID = 7;
            TestItem.Name = "TestSupplier";
            TestItem.City = "Manchester";
            TestItem.Email = "supplier@gmail.com";
            TestItem.TelephoneNumber = "075495837291";
            TestItem.AddDate = DateTime.Now;
            TestItem.Availability = true;
            // Add the item to the test list
            TestList.Add(TestItem);
            // Assign the data to the property
            AllSuppliers.SupplierList = TestList;
            // Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            // Create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            // Create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.Name = "TestSupplier";
            TestItem.City = "York";
            TestItem.Email = "supplier@gmail.com";
            TestItem.TelephoneNumber = "0734687364721";
            TestItem.AddDate = DateTime.Now;
            TestItem.Availability = true;
            // Set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            // Add the record
            PrimaryKey = AllSuppliers.Add();
            // Set the primary key of the test data
            TestItem.SupplierID = PrimaryKey;
            // Find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            // Test to see that the two values are the same
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            // Create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            // Create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.Name = "TestSupplier";
            TestItem.City = "York";
            TestItem.Email = "supplier@gmail.com";
            TestItem.TelephoneNumber = "0734687364721";
            TestItem.AddDate = DateTime.Now;
            TestItem.Availability = true;
            // Set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            // Add the record
            PrimaryKey = AllSuppliers.Add();
            // Set the primary key of the test data
            TestItem.SupplierID = PrimaryKey;
            // Modify the test record
            TestItem.Name = "AnotherSupplier";
            TestItem.City = "AnotherCity";
            TestItem.Email = "anothersupplier@gmail.com";
            TestItem.TelephoneNumber = "07634867267836";
            TestItem.Availability = false;
            // Set the record based on the new test data
            AllSuppliers.ThisSupplier = TestItem;
            // Update the record
            AllSuppliers.Update();
            // Find the record
            AllSuppliers.ThisSupplier.Find(PrimaryKey);
            // Test to see if ThisSupplier mathces the test data
            Assert.AreEqual(AllSuppliers.ThisSupplier, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            // Create the item of the test data
            clsSupplier TestItem = new clsSupplier();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;
            // Set its properties
            TestItem.Name = "TestSupplier";
            TestItem.City = "York";
            TestItem.Email = "supplier@gmail.com";
            TestItem.TelephoneNumber = "0734687364721";
            TestItem.AddDate = DateTime.Now;
            TestItem.Availability = true;
            // Set ThisSupplier to the test data
            AllSuppliers.ThisSupplier = TestItem;
            // Add the record
            PrimaryKey = AllSuppliers.Add();
            // Set the primary key of the test data
            TestItem.SupplierID = PrimaryKey;
            // Delete the record
            AllSuppliers.Delete();
            // Now find the record
            Boolean Found = AllSuppliers.ThisSupplier.Find(PrimaryKey);
            // Test to see that the record was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByCityMethodOK()
        {
            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByCity("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportByCityNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportByCity("xxxxxxx");
            Assert.AreEqual(0, FilteredSuppliers.Count);
        }

        [TestMethod]
        public void ReportByCityTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportByCity("FakeCity");
            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierID != 6)
                {
                    OK = false;
                }

                if (FilteredSuppliers.SupplierList[1].SupplierID != 7)
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
