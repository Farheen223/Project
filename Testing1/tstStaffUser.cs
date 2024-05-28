using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;

namespace Testing1
{
    [TestClass]
    public class tstStaffUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStaffUser Staff = new clsStaffUser();
            //test to see if it exists
            Assert.IsNotNull(Staff);

        }

        [TestMethod]
        public void UserIDProperty()
        {
            //create an instance of the class
            clsStaffUser Staff = new clsStaffUser();
            //create the test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            Staff.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.UserID, TestData);


        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create instance of class we are creating
            clsStaffUser Staff = new clsStaffUser();
            //create test data to assign to the property
            string TestData = "Tommy";
            //assign the data to the property
            Staff.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(Staff.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create new instance of class
            clsStaffUser Staff = new clsStaffUser();
            //create some test data
            string TestData = "Password__";
            //assign the data to the property
            Staff.Password = TestData;
            //Test to see that they are the same
            Assert.AreEqual(Staff.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of classs
            clsStaffUser Staff = new clsStaffUser();
            //create test data
            string TestData = "Staff";
            //assign to the property
            Staff.Department = TestData;
            Assert.AreEqual(Staff.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            //create instance of class
            clsStaffUser Staff = new clsStaffUser();
            //create boolean variable to store result
            Boolean Found = false;
            //create test data
            string UserName = "Tommy";
            string Password = "password__";
            //invoke the method
            Found = Staff.FindUser(UserName, Password);
            //test to see if its true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePswdFound()
        {
            //create an instance of class
            clsStaffUser Staff = new clsStaffUser();
            //create a boolean
            Boolean Found = false;
            Boolean OK = true;
            //create test data
            string UserName = "Tommy";
            string Password = "Password__";
            //invoke the method
            Found = Staff.FindUser(UserName, Password);
            //check UserId property
            if (Staff.UserName != UserName && Staff.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
    }
}
