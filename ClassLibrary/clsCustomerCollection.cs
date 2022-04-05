 using ClassLibrary;
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
        void PopulateArray(clsDataConnection DB)
        {
            //variable for index
            Int32 Index = 0;
            //variable to store the record count 
            Int32 RecordCount = 0;
            //get the count of record
            RecordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
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
        public clsCustomerCollection()
        {
            //Object for data Connection 
            clsDataConnection DB = new clsDataConnection();
            //execute the stored Procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            PopulateArray(DB);
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

        public void Update()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Dob", mThisCustomer.DateOfBirth);
            DB.AddParameter("@CustomerDetails", mThisCustomer.CustomerDetails);
            DB.AddParameter("@AccountBalance", mThisCustomer.AccountBalance);
            DB.AddParameter("@PendingOrder", mThisCustomer.PendingOrder);
            //execute the query 
            DB.Execute("sproc_tblCustomer_Update");
        }

        public void Delete()
        {
            //update an existing record based on the values of thisCustomer
            //connect to the db
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            //execute the query 
            DB.Execute("sproc_tblCustomer_Delete");

        }

        public void ReportyByName(string Name)
        {
            //filters the record bases on full or partial name
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblCustomer_FilterByName");
            PopulateArray(DB);
        }
    }
}