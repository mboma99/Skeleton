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

        [TestMethod]
        public void AddMethodOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            //set properties 
            TestItem.CustomerID = 1;
            TestItem.Name = "Beril Mathilda";
            TestItem.DateOfBirth = Convert.ToDateTime("1967-02-15");
            TestItem.CustomerDetails = "25 North Cray Road, DA5 3LY";
            TestItem.AccountBalance = 259.99;
            TestItem.PendingOrder = true;
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //Set primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that it exist 
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            //set properties 
            TestItem.CustomerID = 3;
            TestItem.Name = "Tiara Caesonius";
            TestItem.DateOfBirth = Convert.ToDateTime("1989-08-01");
            TestItem.CustomerDetails = "3 Tay Close, Dronfield Woodhouse, S18 8ZS";
            TestItem.AccountBalance = 0.00;
            TestItem.PendingOrder = false;
            AllCustomers.ThisCustomer = TestItem;
            //add the record 
            PrimaryKey = AllCustomers.Add();
            //Set primary key of the test data
            TestItem.CustomerID = PrimaryKey;
            //modify the tests data
            TestItem.Name = "Tony Caesonius";
            TestItem.DateOfBirth = Convert.ToDateTime("1989-08-25");
            TestItem.CustomerDetails = "3A Tay Close, Dronfield Woodhouse, S18 8ZS";
            TestItem.AccountBalance = 70.00;
            TestItem.PendingOrder = true;
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create item to test Data 
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            //set properties 
            TestItem.CustomerID = 5;
            TestItem.Name = "Virva Rishi";
            TestItem.DateOfBirth = Convert.ToDateTime("1999-09-02");
            TestItem.CustomerDetails = "1 Lawrence Avenue, Letchworth Garden City, SG6 2EX";
            TestItem.AccountBalance = 41.78;
            TestItem.PendingOrder = true;
            AllCustomers.ThisCustomer = TestItem;

            PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            //create instance of class collection
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create instance of filtered class collection
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a blank string(should return all records)
            FilteredCustomers.ReportyByName("");
            //test to see the two values are the same
            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //create instance of class collection
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            FilteredCustomers.ReportyByName("XXXXXX");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            //create instance of filtered class collection
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            Boolean OK = true;
            //apply a blank string(should return all records)
            FilteredCustomers.ReportyByName("Virva");

            if (FilteredCustomers.Count == 1)
            {
                if(FilteredCustomers.CustomerList[0].CustomerID != 5)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
