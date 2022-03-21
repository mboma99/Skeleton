using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        //private data member for the list
        List<clsStaff> mAllStaff = new List<clsStaff>();
        //public property for the staff list
        public List<clsStaff> StaffList 
        { 
            get
            {
                //return the private data
                return mAllStaff;
            }
            set
            {
                //set the private data
                mAllStaff = value;
            }
        }
        //prublic property for count
        public int Count 
        { 
            get
            {
                //return the count of  the list
                return mAllStaff.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }
        public clsStaff SingleStaff { get; set; }

        //constructor for the class
        public clsStaffCollection()
        {
            //var for the index
            int Index = 0;
            //var to store the record count
            int RecordCount = 0;
            //object for data conneection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //get the count of records
            RecordCount = DB.Count;
            //while there are records to process
            while(Index < RecordCount)
            {
                //create a blank staff
                clsStaff AnStaff = new clsStaff();
                //read in the fields from the current record
                AnStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                AnStaff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                AnStaff.Salary = Convert.ToDouble(DB.DataTable.Rows[Index]["Salary"]);
                AnStaff.IsActive = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                //add the record to the private data member
                mAllStaff.Add(AnStaff);
                //point at the next record
                Index++;
            }
        }
    }
}