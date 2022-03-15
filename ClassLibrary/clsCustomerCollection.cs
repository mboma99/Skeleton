﻿ using ClassLibrary;
 using System;
 using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        //private memeber for thisAddress
        clsCustomer mThisCustomer = new clsCustomer();
        //CONSTRUCTOR 
        public clsCustomerCollection()
        {
            //variable for index
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount = 0;
            //Object for data Connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored Procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //get the count of record
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                //create blank customer
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["Dob"]);
                ACustomer.CustomerDetails = Convert.ToString(DB.DataTable.Rows[Index]["CustomerDetails"]);
                ACustomer.AccountBalance = Convert.ToDouble(DB.DataTable.Rows[Index]["AccountBalance"]);
                ACustomer.PendingOrder = Convert.ToBoolean(DB.DataTable.Rows[Index]["PendingOrder"]);
                //add record to private data memeber 
                mCustomerList.Add(ACustomer);
                Index++;
            }
        }
        public List<clsCustomer> CustomerList
        {
            get { return mCustomerList; }
            set { mCustomerList = value; }
        }
        public clsCustomer ThisCustomer 
        { 
            get { return mThisCustomer; }
            set { mThisCustomer = value; }
        }
        public int Count
        {
            get { return mCustomerList.Count; }
            set
            { //DO THIS LATER  
            }

        }

        public int Add()
        {
            //add new record to the database based on values of thisCustomer
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure 
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Dob", mThisCustomer.DateOfBirth);
            DB.AddParameter("@CustomerDetails", mThisCustomer.CustomerDetails);
            DB.AddParameter("@AccountBalance", mThisCustomer.AccountBalance);
            DB.AddParameter("@PendingOrder", mThisCustomer.PendingOrder);
            //execute the query 
            return DB.Execute("sproc_tblCustomer_Insert");
        }
    }
}