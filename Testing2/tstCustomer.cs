using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerName = "Timmy";
        string Email = "Timmy23@outlook.com";
        string DateOfBirth = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }
        [TestMethod]
        public void ActiveCustomerOK()
        {
            //create an instance of the new class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data  to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }
        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property

            Int32 TestData = 1;

            //assign the data to the property
            AnCustomer.CustomerId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }
        [TestMethod]
        public void CustomerNameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            String TestData = "Timmy";
            //assign the data to the property
            AnCustomer.CustomerName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerName, TestData);
        }
        [TestMethod]
        public void DateOfBirthOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            AnCustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateOfBirth, TestData);
        }
        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Timmy23@outlook.com";
            //assign the data to the property
            AnCustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Email, TestData);
        }
        /**************** FIND METHOD TEST************************/

        [TestMethod]
        public void FindMethodOK ()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create Boolean variable to store the results of the validation
            Boolean Found = false;
            //Create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            Found = AnCustomer.Find(CustomerId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create a boolean variable to store the result of the search
            Boolean found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 1;
            //invoke the method
            found = AnCustomer.Find(CustomerId);
            //check the customer id
            if(AnCustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound ()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerName != "Timmy")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOfBirthFound() {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            found= AnCustomer.Find(CustomerId);
            if (AnCustomer.DateOfBirth != Convert.ToDateTime ("03/05/2002"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound() { 
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            int CustomerId = 1;
           found = AnCustomer.Find(CustomerId);
          if (AnCustomer.Email != "Timmy23@outlook.com")
            {
                OK = false;
            }
          Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
         clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            Error = AnCustomer.Valid(CustomerName, Email, DateOfBirth);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            String CustomerName = "";
            Error = AnCustomer.Valid(CustomerName, Email, DateOfBirth);
            Assert.AreNotEqual(Error, "");
        }

    }
}
