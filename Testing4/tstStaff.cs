using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        //Good test data to pass to the methods
        public Int32 StaffID = 7;
        public string Name = "Name7";
        public DateTime DOB = new DateTime(1997, 07, 07);
        public string Address = "Address7";
        public double Salary = 6543.21;
        public Boolean IsActive = false;

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //test to see staff instance exists
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //test data to assign to StaffID
            int TestData = 2;
            AStaff.StaffID = TestData;
            //test to see if StaffID and TestData are the same
            Assert.AreEqual(AStaff.StaffID, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //test data to assign to Name
            String TestData = "Name1";
            AStaff.Name = TestData;
            //test to see if Name and TestData are the same
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void DOBOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //test data to assign to DOB
            DateTime TestData = new DateTime(2022, 01, 01);
            AStaff.DOB = TestData;
            //test to see if DOB and TestData are the same
            Assert.AreEqual(AStaff.DOB, TestData);
        }

        [TestMethod]
        public void AddressOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //test data to assign to Address
            String TestData = "01 House Street House Country";
            AStaff.Address = TestData;
            //test to see if Address and TestData are the same
            Assert.AreEqual(AStaff.Address, TestData);
        }

        [TestMethod]
        public void SalaryOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //test data to assign to Salary
            Double TestData = 1111.11;
            AStaff.Salary = TestData;
            //test to see if Salary and TestData are the same
            Assert.AreEqual(AStaff.Salary, TestData);
        }

        [TestMethod]
        public void IsActiveOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //test data to assign to IsActive
            Boolean TestData = true;
            AStaff.IsActive = TestData;
            //test to see if IsActive and TestData are the same
            Assert.AreEqual(AStaff.IsActive, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            //Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffIDFound()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            //Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.StaffID != StaffID)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            //Int32 StaffID = 2;
            //string test1 = "\"Name1\"             ";
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.Name != Name)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            //Int32 StaffID = 2;
            //DateTime test1 = new DateTime(2022, 01, 01);
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.DOB != DOB)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            //Int32 StaffID = 2;
            //string test1 = "\"Address1\"";
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.Address != Address)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSalaryFound()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            //Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.Salary != 6543.21)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveFound()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean varible to record if the data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            //Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.IsActive != false)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //invoke the method
            Error = AStaff.Valid(Name, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = ""; //this should trigger an error
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = "a"; //this should be OK
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = "aa"; //this should be OK
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = "";
            testName = testName.PadRight(19, 'a'); //this should be OK
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = "";
            testName = testName.PadRight(20, 'a'); //this should be OK
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = "";
            testName = testName.PadRight(21, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = "";
            testName = testName.PadRight(10, 'a'); //this should be OK
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            string testName = "";
            testName = testName.PadRight(1000, 'a'); //this should fail
            //invoke the method
            Error = AStaff.Valid(testName, DOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMin()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date; //this should fail
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMinLessOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date.AddYears(-17); //this should fail
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBMin()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date.AddYears(-18); //this should be OK
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DOBMinPlusOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date.AddYears(-19); //this should be ok
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxLessOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date.AddYears(-99); //this should be OK
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMax()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date.AddYears(-100); //this should be OK
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DOBMaxPlusOne()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date.AddYears(-101); //this should be OK
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBExtremeMax()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Create some test data to pass to the method
            DateTime testDOB = DateTime.Now.Date.AddYears(-999); //this should fail
            //invoke the method
            Error = AStaff.Valid(Name, testDOB.ToString(), Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DOBInvalidData()
        {
            //create an instance of staff class
            clsStaff AStaff = new clsStaff();
            //string variable to store any error essage
            String Error = "";
            //Set the DOB to a non data value
            string testDOB = "this is not a date!";
            //invoke the method
            Error = AStaff.Valid(Name, testDOB, Address, Salary.ToString());
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
