using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace Testing6
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void TestOrderIdFound()
    {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create an Boolean variable to store the results of the search
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //check the order id
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }

            //test to see that the results is correct
            Assert.IsTrue(OK);

    }
        /******************FIND METHOD TEST******************/

        [TestMethod]
        public void FindMethodOK()
        {     
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderId = 1;
            //invoke the method
            Found = AnOrder.Find(OrderId);
            //test to see if the results is true
            Assert.IsTrue(Found);
    }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]

        public void ActiveOK()
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

    public void DateOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        DateTime TestData = DateTime.Now.Date;
        //assign the data to the property
        AnOrder.Date = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.Date, TestData);
        

    }
    [TestMethod]
    public void OrderIdOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        string TestData = "";
        //assign the data to the property
        AnOrder.OrderId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.OrderId, TestData);
    }

    [TestMethod]
    public void TotalAmountOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        AnOrder.TotalAmount = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.TotalAmount, TestData);
    }
    [TestMethod]
    public void StaffIdOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        string TestData = "1";
        //assign the data to the property
        AnOrder.StaffId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.StaffId, TestData);
    }
    [TestMethod]
    public void CustomerIdOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        AnOrder.CustomerId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.CustomerId, TestData);
    }
    [TestMethod]
    public void QuantityOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        Int32 TestData = 10;
        //assign the data to the property
        AnOrder.Quantity = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.Quantity, TestData);
    }
    [TestMethod]
    public void StockIdOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        Int32 TestData = 1;
        //assign the data to the property
        AnOrder.StockId = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.StockId, TestData);
    }
    [TestMethod]
    public void PaymentSuccesfulOK()
    {
        //create an instance of the class we want to create
        clsOrder AnOrder = new clsOrder();
        //create some test data to assign to the property
        bool TestData = true;
        //assign the data to the property
        AnOrder.PaymentSuccessful = TestData;
        //test to see that the two values are the same
        Assert.AreEqual(AnOrder.PaymentSuccessful, TestData);
    }


}
        
    


    

