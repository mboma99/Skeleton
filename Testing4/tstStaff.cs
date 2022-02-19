using ClassLibrary;
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
    }
}
