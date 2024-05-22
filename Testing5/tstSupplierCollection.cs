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
    }
}
