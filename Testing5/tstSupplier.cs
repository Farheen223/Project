using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplier
    {

        // Good test data
        string Name = "Supplier";
        string City = "Brighton";
        string Email = "supplier@gmail.com";
        string TelephoneNumber = "072485692831";

        // Email domain string for testing email (10 chars)
        string domain = "@gmail.com";

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
            Int32 SupplierID = 3;
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
            Int32 SupplierID = 3;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the supplier id property
            if (supplier.SupplierID != 3)
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
            Int32 SupplierID = 3;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the name property
            if (supplier.Name != "Supplier3")
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
            Int32 SupplierID = 3;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the city property
            if (supplier.City != "Brighton")
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
            Int32 SupplierID = 3;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the email property
            if (supplier.Email != "supplier3@gmail.com")
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
            Int32 SupplierID = 3;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the telephone number property
            if (supplier.TelephoneNumber != "07235872562")
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
            Int32 SupplierID = 3;
            // Invoke the method
            Found = supplier.Find(SupplierID);
            // Check the supplier add date property
            if (supplier.AddDate != Convert.ToDateTime("03/05/2023"))
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
            Int32 SupplierID = 3;
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

        [TestMethod]
        public void ValidMethodOK()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            string Error = "";
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "ab";
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "abc"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "abcd"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(49, 'a'); // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(50, 'a'); // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(51, 'a'); // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(25, 'a'); // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(1000, 'a'); // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "ab";
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMin()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "abc"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "abcd"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "";
            City = City.PadRight(49, 'a'); // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "";
            City = City.PadRight(50, 'a'); // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "";
            City = City.PadRight(51, 'a'); // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CityMid()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "";
            City = City.PadRight(25, 'a'); // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CityExtremeMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string City = "";
            City = City.PadRight(1000, 'a'); // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = ""; // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = "a"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = "ab"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(39, 'a') + domain; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(40, 'a') + domain; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(41, 'a') + domain; // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(15, 'a') + domain; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string Email = "";
            Email = Email.PadRight(990, 'a'); // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "0742195"; // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelehponeNumberMin()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "07359281"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMinPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "073958273"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxLessOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "07493852742843"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "079942485928345"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMaxPlusOne()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "0799424859283454"; // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberMid()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "07827563563"; // This should be OK
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TelephoneNumberExtremeMax()
        {
            // Create an instance of the class we want to create
            clsSupplier supplier = new clsSupplier();
            // String variable to store any error messages
            String Error = "";
            // Create some test data to pass to the method
            string TelephoneNumber = "";
            TelephoneNumber = TelephoneNumber.PadRight(100, '1'); // This should fail
            // Invoke the method
            Error = supplier.Valid(Name, City, Email, TelephoneNumber);
            // Test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
