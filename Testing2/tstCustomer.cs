using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerName = "Timmy";
        string Email = "Timmy23@outlook.com";
        string DateAdded = DateTime.Now.ToShortDateString();
        string ContactNumber = "02071233456";
        string CustomerSurname = "smith";

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
        public void DateAddedOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now;
            //assign the data to the property
            AnCustomer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateAdded, TestData);
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

        [TestMethod]
        public void CustomerSurnameOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "smith";
            //assign the data to the property
            AnCustomer.CustomerSurname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerSurname, TestData);
        }

        [TestMethod]
        public void ContactNumberOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "02071233456";
            //assign the data to the property
            AnCustomer.ContactNumber = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.ContactNumber, TestData);
        }

        /**************** FIND METHOD TEST************************/

        [TestMethod]
        public void FindMethodOK ()
        {
            
            clsCustomer AnCustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 1;
            Found = AnCustomer.Find(CustomerId);
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
        public void TestDateAddedFound() {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            Int32 CustomerId = 1;
            found= AnCustomer.Find(CustomerId);
            if (AnCustomer.DateAdded != Convert.ToDateTime ("03/05/2020"))
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
        public void TestCustomerSurnameFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            int CustomerId = 1;
            found = AnCustomer.Find(CustomerId);
            if (AnCustomer.CustomerSurname != "smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestContactNumberFound()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean found = false;
            Boolean OK = true;
            int CustomerId = 1;
            found = AnCustomer.Find(CustomerId);
            if (AnCustomer.ContactNumber != "020 7123 3456")
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
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerName = "";
            Error = AnCustomer.Valid (CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "aaa";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "aaaa";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameExtremeMax()
        { clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadRight(300, 'a');
            Error = AnCustomer.Valid(CustomerName,CustomerSurname, Email, DateAdded,ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedeMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string DateAdded = "this is not a date!";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "a";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "aa";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ContactNumberMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(51, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string ContactNumber = "";
            ContactNumber = ContactNumber.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ContactNumberExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string ContactNumber = "";
            CustomerName = CustomerName.PadRight(100, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurameMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerSurname = "";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerSurname = "aaa";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerSurname = "aaaa";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(50, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(25, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerSurnameMaxPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(51, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerSurnameExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string CustomerSurname = "";
            CustomerSurname = CustomerSurname.PadRight(300, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "aaa";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "aaaa";
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(50, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailPlusOne()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(51, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer AnCustomer = new clsCustomer();
            string Error = "";
            string Email = "";
            Email = Email.PadRight(300, 'a');
            Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
            Assert.AreNotEqual(Error, "");
        }

        


    }
}
