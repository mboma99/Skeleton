using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if clsStaffCollection exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add a item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set it's properties
            TestItem.StaffID = 7;
            TestItem.Name = "Name7";
            TestItem.DOB = new DateTime(1997, 07, 07);
            TestItem.Address = "Address7";
            TestItem.Salary = 6543.21;
            TestItem.IsActive = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        /*[TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            Int32 SomeCount = 0;
            //Assign the data to the property
            AllStaff.Count = SomeCount;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, SomeCount);
        }*/

        [TestMethod]
        public void SingleStaffPropertyOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            clsStaff TestStaff = new clsStaff();
            //set it's properties
            TestStaff.StaffID = 7;
            TestStaff.Name = "Name7";
            TestStaff.DOB = new DateTime(1997, 07, 07);
            TestStaff.Address = "Address7";
            TestStaff.Salary = 6543.21;
            TestStaff.IsActive = false;
            //add the item to the test list
            AllStaff.SingleStaff = TestStaff;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.SingleStaff, TestStaff);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsStaff> TestList = new List<clsStaff>();
            //add a item to the list
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set it's properties
            TestItem.StaffID = 7;
            TestItem.Name = "Name7";
            TestItem.DOB = new DateTime(1997, 07, 07);
            TestItem.Address = "Address7";
            TestItem.Salary = 6543.21;
            TestItem.IsActive = false;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.StaffID = 7;
            TestItem.Name = "Name7";
            TestItem.DOB = new DateTime(1997, 07, 07);
            TestItem.Address = "Address7";
            TestItem.Salary = 6543.21;
            TestItem.IsActive = false;
            //set SingleStaff to the test data
            AllStaff.SingleStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //Set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.SingleStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.SingleStaff, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.Name = "Name7";
            TestItem.DOB = new DateTime(1997, 07, 07);
            TestItem.Address = "Address7";
            TestItem.Salary = 6543.21;
            TestItem.IsActive = false;
            //set SingleStaff to the test data
            AllStaff.SingleStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //Set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //modify the test data
            TestItem.Name = "Name7";
            TestItem.DOB = new DateTime(1999, 07, 07);
            TestItem.Address = "Address9";
            TestItem.Salary = 1234.56;
            TestItem.IsActive = true;
            //set the record bassed on the new test data
            AllStaff.SingleStaff = TestItem;
            //update the record 
            AllStaff.Update();
            //find the record
            AllStaff.SingleStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStaff.SingleStaff, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set it's properties
            TestItem.StaffID = 8;
            TestItem.Name = "Name7";
            TestItem.DOB = new DateTime(1997, 07, 07);
            TestItem.Address = "Address7";
            TestItem.Salary = 6543.21;
            TestItem.IsActive = false;
            //set SingleStaff to the test data
            AllStaff.SingleStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //Set the primary key of the test data
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaff.SingleStaff.Find(PrimaryKey);
            //delete the record 
            AllStaff.Delete();
            //now find the record
            Boolean Found = AllStaff.SingleStaff.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void FilterByIsActiveMethodOK()
        {
            //create an instance of the staffCollection
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create an instance of the filtered data
            clsStaffCollection FilteredStaff = new clsStaffCollection();
            //call the filter method
            FilteredStaff.FilterByIsActive(true);
            //test to see that the two values are the same
            Assert.AreNotEqual(AllStaff.Count, FilteredStaff.Count);
        }
    }
}
