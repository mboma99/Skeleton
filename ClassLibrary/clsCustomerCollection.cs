 using ClassLibrary;
 using System;
 using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

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
        public clsCustomer ThisCustomer { get; 
            set; }
        public int Count
        {
            get { return mCustomerList.Count; }
            set
            { //DO THIS LATER  
            }

        }
    }
}