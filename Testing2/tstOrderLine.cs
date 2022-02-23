using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);

        }

        [TestMethod]
        public void OrderIDAdded()
        {
            
            clsOrderLine AnOrderLine = new clsOrderLine();
            
            int TestData = 3;
            AnOrderLine.OrderID = TestData;
            
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }

        [TestMethod]
        public void PetIDAdded()
        {
            
            clsOrderLine AnOrderLine = new clsOrderLine();
            
            int TestData = 3;
            AnOrderLine.PetID = TestData;
            
            Assert.AreEqual(AnOrderLine.PetID, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            
            clsOrderLine AnOrderLine = new clsOrderLine();
            
            int TestData = 3;
            AnOrderLine.Quantity = TestData;
            
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void PricePaidOK()
        {
            
            clsOrderLine AnOrderLine = new clsOrderLine();
            
            Double TestData = 3.55;
            AnOrderLine.PricePaid = TestData;
            
            Assert.AreEqual(AnOrderLine.PricePaid, TestData);
        }

        [TestMethod]
        public void PetPriceOK()
        {
            
            clsOrderLine AnOrderLine = new clsOrderLine();
            
            Double TestData = 3.55;
            AnOrderLine.PetPrice = TestData;
            
            Assert.AreEqual(AnOrderLine.PetPrice, TestData);
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
