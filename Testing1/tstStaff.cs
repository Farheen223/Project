using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        public clsStaff PhoneNumber { get; private set; }
        public clsStaff TelephoneNumber { get; private set; }

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
            Staff.Active = TestData;
            //testing to see if they are the same
            Assert.AreEqual(Staff.Active, TestData);
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
            int TestData = 1;
            Staff.StaffId = TestData;
            Assert.AreEqual(Staff.StaffId,TestData);
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
            Staff.TelephoneNumber = TestData;
            Assert.AreEqual(Staff,TelephoneNumber, TestData);
            
        }

        [TestMethod]
        public void StaffNumberproperty()
        {
            clsStaff Staff = new clsStaff();
            String TestData = "21";
            Staff.Hours = TestData;
            Assert.AreEqual(Staff.Hours, TestData);
        }

        
    }
}
