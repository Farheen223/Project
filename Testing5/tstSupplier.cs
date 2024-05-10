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
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Test to see that it exists
            Assert.IsNotNull(supplier);
        }

        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create some test data to assign to the property
            // This property would be auto-generated but a
            // hard-coded value is provided for the sake of testing
            Int32 TestData = 5;
            // Assign the data to the property
            supplier.SupplierID = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(supplier.SupplierID, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create some test data to assign to the property
            string TestData = "Clothing supplier";
            // Assign the data to the property
            supplier.Name = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(supplier.Name, TestData);
        }

        [TestMethod]
        public void CityPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create some test data to assign to the property
            string TestData = "Portsmouth";
            // Assign the data to the property
            supplier.City = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(supplier.City, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create some test data to assign to the property
            string TestData = "test@gmail.com";
            // Assign the data to the property
            supplier.Email = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(supplier.Email, TestData);
        }

        [TestMethod]
        public void TelephoneNumberPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create some test data to assign to the property
            string TestData = "07252135963";
            // Assign the data to the property
            supplier.TelephoneNumber = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(supplier.TelephoneNumber, TestData);
        }

        [TestMethod]
        public void AddDatePropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            // Assign the data to the property
            supplier.AddDate = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(supplier.AddDate, TestData);
        }

        [TestMethod]
        public void AvailabilityPropertyOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create some test data to assign to property
            Boolean TestData = true;
            // Assign the data to the property
            supplier.Availability = TestData;
            // Test to see that the two values are the same
            Assert.AreEqual(supplier.Availability, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the results of the validation
            Boolean Found = false;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the find method
            Found = supplier.Find(SupplierID);
            // Test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the supplier id property
            if (supplier.SupplierID != 4)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the name property
            if (supplier.Name != "ClothesSupplier")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCityFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the city property
            if (supplier.City != "Liverpool")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the email property
            if (supplier.Email != "supplier@gmail.com")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTelephoneNumberFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the telephone number property
            if (supplier.TelephoneNumber != "079252358158")
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddDateFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the supplier add date property
            if (supplier.AddDate != Convert.ToDateTime("01/01/2024"))
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailabilityFound()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // Create a Boolean variable to store the result of the search
            Boolean Found = false;
            // Create a Boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            // Create some test data to use with the method
            Int32 SupplierID = 4;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the availability property
            if (supplier.Availability != true)
            {
                OK = false;
            }
            // Test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
