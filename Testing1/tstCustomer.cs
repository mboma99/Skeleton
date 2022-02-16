using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIDAdded()
        {
            //create an instance of class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //test data to assign to CustomerID
            int TestData = 3;
            Acustomer.CustomerID = TestData;
            //test to see if CustomerID and TestData the same
            Assert.AreEqual(Acustomer.CustomerID, TestData);
        }

        [TestMethod]
        public void NameAddedOK()
        {
            //create an instance of class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //test data to assign to Name
            String TestData = "John Bloggs";
            //assign the data to name
            Acustomer.Name = TestData;
            //test to see if two Strings are the same
            Assert.AreEqual(Acustomer.Name, TestData);
        }

        [TestMethod]
        public void DobAddedOk() 
        {
            //create an instance of class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //test data to assign to Date to 25 August 1999
            DateTime TestData = new DateTime(1999, 08, 25);
            Acustomer.DateOfBirth = TestData;
            //test to see if two date are the same
            Assert.AreEqual(Acustomer.DateOfBirth, TestData);
        }

        //QUESTION THIS ONE 
        [TestMethod]
        public void CustomerDetailsAddedOK()
        {
            //create an instance of class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //test data to assign to Customer Details
            String TestData = "484 Deer Half, BF6 8HG, fjorville9@yopmail.com";
            //assign the data to name
            Acustomer.CustomerDetails = TestData;
            //test to see if two Strings are the same
            Assert.AreEqual(Acustomer.CustomerDetails, TestData);
        }

        [TestMethod]
        public void CurrentAccountBalanceOk()
        {
            //create an instance of class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //test data to assign to Date to 25 August 1999
            Double TestData = 2013.94;
            Acustomer.AccountBalance = TestData;
            //test to see if two decimal are the same
            Assert.AreEqual(Acustomer.AccountBalance, TestData);
        }

        [TestMethod]
        public void HasPendingOrder()
        {
            //create an instance of class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //test data to assign to PendingOrder 
            Boolean TestData = true;
            Acustomer.PendingOrder = TestData;
            //test to see if two date are the same
            Assert.AreEqual(Acustomer.PendingOrder, TestData);
        }




    }
}
