using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Remoting.Messaging;

namespace Testing2
{
    [TestClass]
    public class tstCustomerUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            Assert.IsNotNull(AnUser);
        }



        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            Int32 TestData = 1;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Farheen";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }
        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Password1";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerUser AnUser = new clsCustomerUser();
            //create some test data to assign to the property
            string TestData = "Customer";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }


       [TestMethod]
       public void FindUserMethodOK()
        {
          clsCustomerUser AnUser = new clsCustomerUser();
           Boolean Found = false;
           string UserName = "Farheen";
           string Password = "Password1";
           Found = AnUser.FindUser(UserName, Password);
           Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNameP1Found()
        {
            clsCustomerUser AnUser = new clsCustomerUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Farheen";
            string Password = "Password1";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



     }

    }
