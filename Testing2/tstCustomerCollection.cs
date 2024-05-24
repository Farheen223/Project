using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        public clsCustomerCollection ThisCustomer { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomer);
        }

        [TestMethod]
        public void CustomerListOK()

        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Timmy";
            TestItem.CustomerSurname = "smith";
            TestItem.ContactNumber = "02071233456";
            TestItem.Email = "Timmy23@outlook.com";
            TestItem.DateAdded = DateTime.Now;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.CustomerList, TestList);
        }

       

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Active = true;
            TestCustomer.CustomerId = 1;
            TestCustomer.CustomerName = "Timmy";
            TestCustomer.CustomerSurname = "smith";
            TestCustomer.ContactNumber = "02071233456";
            TestCustomer.Email = "Timmy23@outlook.com";
            TestCustomer.DateAdded = DateTime.Now;
            AllCustomer.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomer.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            List <clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Timmy";
            TestItem.CustomerSurname = "smith";
            TestItem.ContactNumber = "02071233456";
            TestItem.Email = "Timmy23@outlook.com";
            TestItem.DateAdded = DateTime.Now;
            TestList.Add(TestItem);
            AllCustomer.CustomerList = TestList;
            Assert.AreEqual(AllCustomer.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomer = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.CustomerId = 1;
            TestItem.CustomerName = "Timmy";
            TestItem.CustomerSurname = "smith";
            TestItem.ContactNumber = "02071233456";
            TestItem.Email = "Timmy23@outlook.com";
            TestItem.DateAdded = DateTime.Now;
            AllCustomer.ThisCustomer = TestItem;
            PrimaryKey = AllCustomer.Add();
            TestItem.CustomerId = PrimaryKey;
            AllCustomer.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomer.ThisCustomer, TestItem);
        }

       
    }

   
}
