using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrders AnOrder = new clsOrders();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIDAdded()
        {
            //create an instance of class we want to create
            clsOrders AnOrder = new clsOrders();
            //test data to assign to CustomerID
            int TestData = 3;
            AnOrder.OrderID = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDAdded()
        {
            //create an instance of class we want to create
            clsOrders AnOrder = new clsOrders();
            //test data to assign to CustomerID
            int TestData = 3;
            AnOrder.CustomerID = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        
        [TestMethod]
        public void HasApproval()
        {
            //create an instance of class we want to create
            clsOrders AnOrder = new clsOrders();
            //test data to assign to PendingOrder 
            Boolean TestData = true;
            AnOrder.Approval = TestData;
            //test to see if two date are the same
            Assert.AreEqual(AnOrder.Approval, TestData);
        }
        
        [TestMethod]
        public void HasSaleApplied()
        {
            //create an instance of class we want to create
            clsOrders AnOrder = new clsOrders();
            //test data to assign to PendingOrder 
            Boolean TestData = true;
            AnOrder.SaleApplied = TestData;
            //test to see if two date are the same
            Assert.AreEqual(AnOrder.SaleApplied, TestData);
        }

        [TestMethod]
        public void OrderStatusAddedOK()
        {
            //create an instance of class we want to create
            clsOrders Acustomer = new clsOrders();
            //test data to assign to Customer Details
            String TestData = "En Route";
            //assign the data to name
            Acustomer.OrderStatus = TestData;
            //test to see if two Strings are the same
            Assert.AreEqual(Acustomer.OrderStatus, TestData);
        }
    }
}
