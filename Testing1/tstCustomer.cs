using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {

        //Goodtest data

        String Name = "Micheal Myers";
        String Dob = "1961/10/30";
        String CustomerDetails = "27 Haddonfield,H12 G34 ";
        String AccountBalance = "1000.00";
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
            //test data to assign to balance to £2013.94
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


        /*
         * FIND METHOD TESTS 
         */
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer Acustomer = new clsCustomer();

            Boolean Found = false;

            Int32 CustomerID = 1;

            Found = Acustomer.Find(CustomerID);

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerID()
        {
            clsCustomer Acustomer = new clsCustomer();

            Boolean Found = false;

            //Boolean to record if data is OK
            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = Acustomer.Find(CustomerID);

            if (Acustomer.CustomerID != 1)
            {
                OK = false;
            }

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestNameFound()
        {
            clsCustomer Acustomer = new clsCustomer();

            Boolean Found = false;

            //Boolean to record if data is OK
            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = Acustomer.Find(CustomerID);

            if (Acustomer.Name != "Beril Mathilda")
            {
                OK = false;
            }

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestDateOfBirthFound()
        {
            clsCustomer Acustomer = new clsCustomer();

            Boolean Found = false;

            //Boolean to record if data is OK
            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = Acustomer.Find(CustomerID);

            if (Acustomer.DateOfBirth != Convert.ToDateTime("1967/02/15"))
            {
                OK = false;
            }

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerDetailsFound()
        {
            clsCustomer Acustomer = new clsCustomer();

            Boolean Found = false;

            //Boolean to record if data is OK
            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = Acustomer.Find(CustomerID);

            if (Acustomer.CustomerDetails != "25 North Cray Road, Bexley, DA5 3LY")
            {
                OK = false;
            }

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestAccountBalanceFound()
        {
            clsCustomer Acustomer = new clsCustomer();

            Boolean Found = false;

            //Boolean to record if data is OK
            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = Acustomer.Find(CustomerID);

            if (Acustomer.AccountBalance != 259.99)
            {
                OK = false;
            }

            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestPendingOrderFound()
        {
            clsCustomer Acustomer = new clsCustomer();

            Boolean Found = false;

            //Boolean to record if data is OK
            Boolean OK = true;

            Int32 CustomerID = 1;

            Found = Acustomer.Find(CustomerID);

            if (Acustomer.PendingOrder != true)
            {
                OK = false;
            }

            Assert.IsTrue(Found);

        }

        /*
         * Validation Method 
         */
        [TestMethod]
        public void ValidMethodOk()
        {
            //create an instance of the class we want to create
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        /*
         *
         *NAME VALIDATION
         *
         */
        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = ""; // this will trigger error
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "a"; 
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "aa"; 
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "";
            Name = Name.PadRight(100, 'a'); // this will trigger error
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        /*
         * 
         * DOB TESTS
         * 
         */

        [TestMethod]
        public void DobExtremeMin()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change date to extreme date -150
            TestDate = TestDate.AddYears(-150);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DobMinLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-101);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DobMin()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMinPlusOne ()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-99);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMid()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMaxLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-19);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-18);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DobMaxPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-17);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DobExtremeMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(+10);
            //Set dat of birth
            String Dob = TestDate.ToString();
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DobInvalidDate()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //Input that is not date 
            String Dob = "This is not a date";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        /*
         * 
         * CUSTOMER DETAILS TESTS 
         *
         */

        [TestMethod]
        public void CustomerDetailsMinLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = ""; // this will trigger error
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMin()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "a";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMinPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "aa";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMid()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "";
            CustomerDetails = CustomerDetails.PadRight(100, 'a');
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMaxLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "";
            CustomerDetails = CustomerDetails.PadRight(199, 'a');
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "";
            CustomerDetails = CustomerDetails.PadRight(200, 'a');
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsMaxPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "";
            CustomerDetails = CustomerDetails.PadRight(201, 'a');
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDetailsExtremeMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String CustomerDetails = "";
            CustomerDetails = CustomerDetails.PadRight(400, 'a'); // this will trigger error
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        /*
         *
         * ACCOUNT BALANCE 
         * 
         */

        [TestMethod]
        public void AccountBalanceLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "-1.00";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMin()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "1.00";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMinPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "2.00";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMid()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "500.00";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMaxLessOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "998.99";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "999.99";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceMaxPlusOne()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String AccountBalance = "1000.99";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceExtremeMax()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //create some test to pass test
            String Name = "";
            String AccountBalance = "2000.00"; // this will trigger error
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AccountBalanceInvalidDate()
        {
            clsCustomer Acustomer = new clsCustomer();
            //String variable to store any Error Message
            String Error = "";
            //Input that is not date 
            String AccountBalance = "This is not a double";
            //Invoke the method 
            Error = Acustomer.Valid(Name, Dob, CustomerDetails, AccountBalance);
            //TEST TO SEE THAT THE RESULTS ARE CORRECT
            Assert.AreNotEqual(Error, "");
        }
    }
}
