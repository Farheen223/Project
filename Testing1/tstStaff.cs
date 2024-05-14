using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Dynamic;

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
            Error = Staff.Valid(Name, Email, PhoneNumber, DateAdded, Hours);
        }


    }
}
