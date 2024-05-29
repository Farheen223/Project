using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing5
{
    [TestClass]
    public class tstSupplierUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierUser User = new clsSupplierUser();
            Assert.IsNotNull(User);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsSupplierUser User = new clsSupplierUser();
            Int32 TestData = 1;
            User.UserID = TestData;
            Assert.AreEqual(User.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSupplierUser User = new clsSupplierUser();
            string TestData = "Name";
            User.UserName = TestData;
            Assert.AreEqual(User.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSupplierUser User = new clsSupplierUser();
            string TestData = "password123";
            User.Password = TestData;
            Assert.AreEqual(User.Password, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSupplierUser User = new clsSupplierUser();
            string TestData = "Supplier";
            User.Department = TestData;
            Assert.AreEqual(User.Department, TestData);
        }

        [TestMethod]
        public void FindUserMethodOK()
        {
            clsSupplierUser User = new clsSupplierUser();
            Boolean Found = false;
            string UserName = "User";
            string Password = "Password123";
            Found = User.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            clsSupplierUser User = new clsSupplierUser();
            Boolean Found = false;
            Boolean OK = true;
            string UserName = "User";
            string Password = "Password123";
            Found = User.FindUser(UserName, Password);
            if (User.UserName != UserName && User.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
