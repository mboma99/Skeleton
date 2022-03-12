using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        //Test data for the staff table
        public Int32 testStaffID = 7;
        public string testName = "Name7";
        public DateTime testDOB = new DateTime(1997, 07, 07);
        public string testAddress = "Address7";
        public double testSalary = 6543.21;
        public Boolean testIsActive = false;

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
            Found = AStaff.Find(testStaffID);
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
            Found = AStaff.Find(testStaffID);
            //check the staff ID
            if (AStaff.StaffID != testStaffID)
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
            Found = AStaff.Find(testStaffID);
            //check the staff ID
            if (AStaff.Name != testName)
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
            Found = AStaff.Find(testStaffID);
            //check the staff ID
            if (AStaff.DOB != testDOB)
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
            Found = AStaff.Find(testStaffID);
            //check the staff ID
            if (AStaff.Address != testAddress)
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
            Found = AStaff.Find(testStaffID);
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
            Found = AStaff.Find(testStaffID);
            //check the staff ID
            if (AStaff.IsActive != false)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
