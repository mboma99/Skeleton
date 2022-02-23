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
            
            clsOrders AnOrder = new clsOrders();
            
            int TestData = 3;
            AnOrder.OrderID = TestData;
            
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void CustomerIDAdded()
        {
            
            clsOrders AnOrder = new clsOrders();
            
            int TestData = 3;
            AnOrder.CustomerID = TestData;
            
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }
        
        [TestMethod]
        public void HasApproval()
        {
            
            clsOrders AnOrder = new clsOrders();
            
            Boolean TestData = true;
            AnOrder.Approval = TestData;
            
            Assert.AreEqual(AnOrder.Approval, TestData);
        }
        
        [TestMethod]
        public void HasSaleApplied()
        {
            
            clsOrders AnOrder = new clsOrders();
             
            Boolean TestData = true;
            AnOrder.SaleApplied = TestData;
            
            Assert.AreEqual(AnOrder.SaleApplied, TestData);
        }

        [TestMethod]
        public void OrderStatusAddedOK()
        {
            
            clsOrders Acustomer = new clsOrders();
            
            String TestData = "En Route";
            
            Acustomer.OrderStatus = TestData;
            
            Assert.AreEqual(Acustomer.OrderStatus, TestData);
        }
    }
}
