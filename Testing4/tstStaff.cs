﻿using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
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
            //create some tes data to use with the method
            Int32 StaffID = 2;
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
            //create some tes data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.StaffID != 2)
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
            //create some tes data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.Name != "Name1")
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
            //create some tes data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.DOB != new DateTime(01/01/2022))
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
            //create some tes data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.Address != "Address1")
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
            //create some tes data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.Salary != 111.11)
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
            //create some tes data to use with the method
            Int32 StaffID = 2;
            //invoke the method
            Found = AStaff.Find(StaffID);
            //check the staff ID
            if (AStaff.IsActive != true)
            {
                OK = false;
            }
            //test to see if the result is true
            Assert.IsTrue(OK);
        }
    }
}
