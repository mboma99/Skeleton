using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Testing1
{
    class clsCustomerCollection
    {
        //private data member for the list 
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        public clsCustomerCollection ()
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
            }
        }
        public List<clsCustomer> CustomerList 
        {   
            get { return mCustomerList; }  
            set { mCustomerList = value; }
        }
        public clsCustomer ThisCustomer { get; internal set; }
        public int Count 
        {
            get { return mCustomerList.Count; }
            set
            { //DO THIS LATER  
            }
        
        }
    }
}