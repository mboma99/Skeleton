using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing2
{
    class tstOrders
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

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders AnOrder = new clsOrders();

            Boolean Found = false;

            Int32 OrderIDNO = 3;

            Found = AnOrder.Find(OrderIDNO);

            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDNOFound()
        {
            clsOrders AnOrder = new clsOrders();

            Boolean Found = false;

            Boolean OK = true;

            Int32 OrderIDNO = 3;

            Found = AnOrder.Find(OrderIDNO);

            if (AnOrder.OrderIDNO != 3)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.OrderID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIDFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.CustomerID != 3)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HasApprovalFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.HasApproval != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void HasSaleAppliedFound()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 3;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the property
            if (AnOrder.HasSaleApplied != true)
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
            clsOrders AnOrder = new clsOrders();
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
