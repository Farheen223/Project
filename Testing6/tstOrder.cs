using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ActivePropertyOK()
        //create an instance of the class we want to create
        {
            clsOrder AnOrder = new clsOrder();
            //create some test data to assaign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);

        }
        [TestMethod]
        public void DateAddedPropertyOK()
        {

            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnOrder.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }
    }

    namespace Testing6
    {
        [TestClass]
        public class tstOrder
        {
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //test to see that it exists
                Assert.IsNotNull(AnOrder);
            }
            [TestMethod]
            public void ActivePropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                Boolean TestData = true;
                //assign the data to the property
                AnOrder.Active = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.Active, TestData);
            }
            [TestMethod]
            public void DateAddedPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                DateTime TestData = DateTime.Now.Date;
                //assign the data to the property
                AnOrder.DateAdded = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.DateAdded, TestData);
            }
            [TestMethod]
            public void AddressIdPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                AnOrder.OrderId = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.OrderId, TestData);
            }

            [TestMethod]
            public void CountyCodePropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                Int32 TestData = 1;
                //assign the data to the property
                AnOrder.CountyCode = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.CountyCode, TestData);
            }
            [TestMethod]
            public void HouseNoPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                string TestData = "21b";
                //assign the data to the property
                AnOrder.HouseNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.HouseNo, TestData);
            }
            [TestMethod]
            public void PostCodePropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                string TestData = "LE1 4AB";
                //assign the data to the property
                AnOrder.PostCode = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.PostCode, TestData);
            }
            [TestMethod]
            public void StreetPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                string TestData = "Some Street";
                //assign the data to the property
                AnOrder.Street = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.Street, TestData);
            }

            [TestMethod]
            public void TownPropertyOK()
            {
                //create an instance of the class we want to create
                clsOrder AnOrder = new clsOrder();
                //create some test data to assign to the property
                string TestData = "Leicester";
                //assign the data to the property
                AnOrder.Town = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnOrder.Town, TestData);

            }
        }
    }
}