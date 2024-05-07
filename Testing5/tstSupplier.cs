using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // test to see that it exists
            Assert.IsNotNull(supplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // create some test data to assign to the property
            // this property would be auto-generated but a
            // hard-coded value is provided for the sake of testing
            Int32 TestData = 5;
            // assign the data to the property
            supplier.SupplierID = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(supplier.SupplierID, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // create some test data to assign to the property
            string TestData = "Clothing supplier";
            // assign the data to the property
            supplier.Name = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(supplier.Name, TestData);
        }

        [TestMethod]
        public void CityPropertyOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // create some test data to assign to the property
            string TestData = "Portsmouth";
            // assign the data to the property
            supplier.City = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(supplier.City, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // create some test data to assign to the property
            string TestData = "test@gmail.com";
            // assign the data to the property
            supplier.Email = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(supplier.Email, TestData);
        }

        [TestMethod]
        public void TelephoneNumberPropertyOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // create some test data to assign to the property
            string TestData = "07252135963";
            // assign the data to the property
            supplier.TelephoneNumber = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(supplier.TelephoneNumber, TestData);
        }

        [TestMethod]
        public void AddDatePropertyOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // assign the data to the property
            supplier.AddDate = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(supplier.AddDate, TestData);
        }

        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            // create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // create some test data to assign to property
            Boolean TestData = true;
            //assign the data to the property
            supplier.Availability = TestData;
            // test to see that the two values are the same
            Assert.AreEqual(supplier.Availability, TestData);
        }
    }
}
