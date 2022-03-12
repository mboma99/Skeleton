using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        private Int32 mStaffID;
        public Int32 StaffID 
        {
            get 
            {
                return mStaffID;
            }
            set 
            {
                mStaffID = value;
            } 
        }

        private string mName;
        public string Name 
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }

        private DateTime mDOB;
        public DateTime DOB 
        { get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }

        private string mAddress;
        public string Address 
        { get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        private double mSalary;
        public double Salary
        {
            get
            {
                return mSalary;
            }
            set
            {
                mSalary = value;
            }
        }

        private bool mIsActive;
        public bool IsActive
        {
            get
            {
                return mIsActive;
            }
            set
            {
                mIsActive = value;
            }
        }

        public bool Find(int staffID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff ID to search for
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure
            DB.Execute("dbo.sproc_tblStaff_FilterByStaffID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                mSalary = Convert.ToDouble(DB.DataTable.Rows[0]["Salary"]);
                mIsActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsActive"]);
                return true;
            }
            else 
            {
                return false;
            }

            //set the private data members to the test value
            /*mStaffID = 2;
            mName = "Name1";
            mDOB = new DateTime(01/01/2022);
            mAddress = "Address1";
            mSalary = 111.11;
            mIsActive = true;

            //always return true
            return true;*/
        }
    }
}