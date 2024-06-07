using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;

namespace Testing3
{
    [TestClass]
    public class tstStockUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockUser anUser = new clsStockUser();
            Assert.IsNotNull(anUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsStockUser anUser = new clsStockUser();
            Int32 TestData = 1;
            anUser.UserID = TestData;
            Assert.AreEqual(anUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsStockUser anUser = new clsStockUser();
            string TestData = "Rosie";
            anUser.UserName = TestData;
            Assert.AreEqual(anUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsStockUser anUser = new clsStockUser();
            string TestData = "Password";
            anUser.Password = TestData;
            Assert.AreEqual(anUser.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsStockUser anUser = new clsStockUser();
            string TestData = "Stock";
            anUser.Department = TestData;
            Assert.AreEqual(anUser.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethod()
        {
            clsStockUser anStock = new clsStockUser();
            Boolean Found= false;
            string UserName = "Rosie";
            string Password = "Password";
            Found = anStock.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsStockUser anUser = new clsStockUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "Rosie";
            string Password = "Password";
            Found = anUser.FindUser(UserName, Password);
            if (anUser.UserName != UserName && anUser.Password != Password) 
            {
                OK = false;

            }

            Assert.IsTrue(OK);
        }
    }
}
