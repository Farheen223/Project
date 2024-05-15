using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Classlibrary;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TotalAmountOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]

        public void ActivePropertyOK()
        {

            //create an instance of class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assing the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }
    }

    public void DatePropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        DataTime TestData = DateTime.Now.Date;
        //assign the data to the property
        AnOrder.DateAdded = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.Date, TestData);

    }
    [TestMethod]
    public void OrderIdPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsAddress();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        AnOrder.OrderId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.OrderId, TestData);
    }

    [TestMethod]
    public void StaffIdPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        AnOrder.StaffId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.StaffId, TestData);
    }
    [TestMethod]
    public void CUstomerIdPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        string TestData = "2";
        //assign the data to the property
        AnOrder.HouseNo = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.CustomerId, TestData);
    }
    [TestMethod]
    public void QuantityPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        string TestData = "1";
        //assign the data to the property
        AnOrder.Quantity = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.Quantity, TestData);
    }
    [TestMethod]
    public void StockIdPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        string TestData = "Stock ID";
        //assign the data to the property
        AnOrder.StockId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.StockId, TestData);
    }
    [TestMethod]
    public void OrderIdPropertyOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        string TestData = "Order ID";
        //assign the data to the property
        AnOrder.OrderId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.OrderId, TestData);
    }
    [TestMethod]

    public void FindMethodOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create a boolean variable to store the results of the validation
        Boolean Found = false;
        //create some test data to use with the method
        Int32 OrderId = 1;
        //invoke the method
        Found = AnOrder.Find(OrderId);
        //test to see if the results is true
        Assert.IsTrue(Found);
    }
}