using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing2
{
    [TestClass]
    public class tstOrderLine
    {

        String OrderID = "3";
        String PetID = "3";
        String Quantity = "3";
        String PricePaid = "3.55";
        String PetPrice = "3.55";
        String OrderStatus = "En Route";

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            String Error = "";

            Error = AnOrderLine.Valid(PetID, Quantity, PricePaid, PetPrice, OrderStatus);

            Assert.AreEqual(Error, "");
        }


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

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Int32 QuantityNO = 3;

            Found = AnOrderLine.Find(QuantityNO);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDNOFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();

            Boolean Found = false;

            Boolean OK = true;

            Int32 QuantityNO = 3;

            Found = AnOrderLine.Find(QuantityNO);

            if (AnOrderLine.Quantity != 3)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrderLine.Find(OrderID);
            //check the property
            if (AnOrderLine.OrderID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PetIDFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrderLine.Find(OrderID);
            //check the property
            if (AnOrderLine.PetID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void QuantityFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrderLine.Find(OrderID);
            //check the property
            if (AnOrderLine.Quantity != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PricePaidFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrderLine.Find(OrderID);
            //check the property
            if (AnOrderLine.PricePaid != 3.55)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PetPriceFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrderLine.Find(OrderID);
            //check the property
            if (AnOrderLine.PetPrice != 3.55)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderStatusFound()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrderLine.Find(OrderID);
            //check the property
            if (AnOrderLine.OrderStatus != "En Route")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    }
}
