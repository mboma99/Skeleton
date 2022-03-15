using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see that it exist 
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerList()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create tesat data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //set properties 
            TestItem.CustomerID = 10;
            TestItem.Name = "Freedy Kruger";
            TestItem.DateOfBirth = Convert.ToDateTime("1986-12-11");
            TestItem.CustomerDetails = "10 Elm Street, EL2 67";
            TestItem.AccountBalance = 203.99;
            TestItem.PendingOrder = true;
            //add test item to list 
            TestList.Add(TestItem);
            //assign data to property 
            AllCustomers.CustomerList = TestList;
            //test to see that it exist 
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {

            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestCustomer = new clsCustomer();
            //set properties of test objec
            TestCustomer.CustomerID = 10;
            TestCustomer.Name = "Freedy Kruger";
            TestCustomer.DateOfBirth = Convert.ToDateTime("1986-12-11");
            TestCustomer.CustomerDetails = "10 Elm Street, EL2 67";
            TestCustomer.AccountBalance = 203.99;
            TestCustomer.PendingOrder = true;
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create tesat data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            //set properties 
            TestItem.CustomerID = 1;
            TestItem.Name = "Beril Mathilda";
            TestItem.DateOfBirth = Convert.ToDateTime("1967-02-15");
            TestItem.CustomerDetails = "25 North Cray Road, DA5 3LY";
            TestItem.AccountBalance = 259.99;
            TestItem.PendingOrder = true;
            //add test item to list 
            TestList.Add(TestItem);
            //assign data to property 
            AllCustomers.CustomerList = TestList;
            //test to see that it exist 
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }


    }
}
