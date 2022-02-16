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
            //create an instance of class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test data to assign to CustomerID
            int TestData = 3;
            AnOrderLine.OrderID = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(AnOrderLine.OrderID, TestData);
        }

        [TestMethod]
        public void PetIDAdded()
        {
            //create an instance of class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test data to assign to CustomerID
            int TestData = 3;
            AnOrderLine.PetID = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(AnOrderLine.PetID, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test data to assign to CustomerID
            int TestData = 3;
            AnOrderLine.Quantity = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void PricePaidOK()
        {
            //create an instance of class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test data to assign to CustomerID
            Double TestData = 3.55;
            AnOrderLine.PricePaid = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(AnOrderLine.PricePaid, TestData);
        }

        [TestMethod]
        public void PetPriceOK()
        {
            //create an instance of class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test data to assign to CustomerID
            Double TestData = 3.55;
            AnOrderLine.PetPrice = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(AnOrderLine.PetPrice, TestData);
        }

    }
}
