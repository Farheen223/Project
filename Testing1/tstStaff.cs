using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;
using System.IO;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {


        //good test data
        // create test data to pass the method
        string Email = "D.Galb@hotmail.com";
        string Name = "DanGalby";
        string PhoneNumber = "07453729171";
        string Hours = "32";
        string DateAdded = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void TestMethod1()
        {
            clsStaff Staff = new clsStaff();
            Assert.IsNotNull(Staff);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //creating the instance of the class
            clsStaff Staff = new clsStaff();
            //creating test data to assign
            Boolean TestData = true;
            //assigning data to property
            Staff.FullTime = TestData;
            //testing to see if they are the same
            Assert.AreEqual(Staff.FullTime, TestData);
        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {
            clsStaff Staff = new clsStaff();
            DateTime TestData = DateTime.Now;
            Staff.DateAdded = TestData;
            Assert.AreEqual(Staff.DateAdded, TestData);
        }

        [TestMethod]
        public void StaffIdproperty()
        {
            clsStaff Staff = new clsStaff();
            Int32 TestData = 1;
            Staff.StaffId = TestData;
            Assert.AreEqual(Staff.StaffId, TestData);
        }
        [TestMethod]
        public void StaffNameproperty()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "JohnHayes";
            Staff.Name = TestData;
            Assert.AreEqual(Staff.Name, TestData);
        }

        [TestMethod]
        public void StaffEmailProperty()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "p2774538@my365.dmu.ac.uk";
            Staff.Email = TestData;
            Assert.AreEqual(Staff.Email, TestData);
        }

        [TestMethod]
        public void StaffPhonenumberProperty()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "07894447379";
            Staff.PhoneNumber = TestData;
            Assert.AreEqual(Staff.PhoneNumber, TestData);

        }

        [TestMethod]
        public void StaffNumberproperty()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "21";
            Staff.Hours = TestData;
            Assert.AreEqual(Staff.Hours, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsStaff Staff = new clsStaff();
            Boolean Found = false;
            Int32 StaffId = 9;
            Found = Staff.Find(StaffId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            clsStaff Staff = new clsStaff();
            //create boolean variable to store result
            Boolean found = false;
            //create a boolean variable to record if the data is ok
            Boolean OK = true;
            //create test data
            Int32 StaffId = 9;
            //Invoke the method
            found = Staff.Find(StaffId);
            if (Staff.StaffId != 9)
            {
                OK = false;
            }
            //test if the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 9;
            found = Staff.Find(StaffId);
            if (Staff.DateAdded != Convert.ToDateTime("14/05/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestNameFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 9;
            found = Staff.Find(StaffId);
            if (Staff.Name != "Sudhir")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPhoneNumberFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 9;
            found = Staff.Find(StaffId);
            if (Staff.PhoneNumber != "07835462189")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 9;
            found = Staff.Find(StaffId);
            if (Staff.Email != "Sudhir@outlook.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestHoursWorkedFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 9;
            found = Staff.Find(StaffId);
            if (Staff.Hours != "12")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestFulltimeFound()
        {
            clsStaff Staff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 9;
            found = Staff.Find(StaffId);
            if (Staff.FullTime != false)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
        }


        [TestMethod]
        public void StaffNameMinLessOne()
        {
            clsStaff Staff = new clsStaff();
            // String to store error message
            String Error = "";
            //Create test data
            string Name = ""; //this should trigger error
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            //test to see if it is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void NameMin()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "a"; //this should be ok
            //invoke the method
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void NameMinplusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "aa"; //this should be ok
            //invoke the method
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(49, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void NameMax()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
            Name = Name.PadRight(50, 'a');//this should be ok
            //invoke the method
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMid()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = ""; //this should be ok
            Name = Name.PadRight(25, 'a');
            //invoke the method
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStaff Staff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string Name = "";
             Name = Name.PadRight(51, 'a'); //this should be ok
            //invoke the method
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NameExtremeMax()
        {
            clsStaff Staff = new clsStaff();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(500, 'a');
            Error = Staff.Valid(Name, Email, PhoneNumber, Hours, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create new instance of class staff
            clsStaff Staff = new clsStaff();
            //variable to store the error
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the data to 100 years prior
            TestDate = TestDate.AddYears(-100);
            //invoke the method
            string DateAdded = TestDate.ToString();
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMinlessOne()
        {
            //create new instance of class staff
            clsStaff Staff = new clsStaff();
            //variable to store the error
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the data to 100 years prior
            TestDate = TestDate.AddDays(-1);
            //invoke the method
            string DateAdded = TestDate.ToString();
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create new instance of class staff
            clsStaff Staff = new clsStaff();
            //variable to store the error
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //invoke the method
            string DateAdded = TestDate.ToString();
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create new instance of class staff
            clsStaff Staff = new clsStaff();
            //variable to store the error
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the data to 100 years prior
            TestDate = TestDate.AddDays(1);
            //invoke the method
            string DateAdded = TestDate.ToString();
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create new instance of class staff
            clsStaff Staff = new clsStaff();
            //variable to store the error
            String Error = "";
            //create test data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //Change the data to 100 years prior
            TestDate = TestDate.AddYears(100);
            //invoke the method
            string DateAdded = TestDate.ToString();
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsStaff Staff = new clsStaff();
            //String variable stores error message
            String Error = "";
            //Set the date added to a non date value
            string DateAdded = "this is not a date";
            Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
            Assert.AreNotEqual(Error, "");

        }


    }
}
