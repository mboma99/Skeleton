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
            DB.AddParameter("@StaffID", staffID);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffID");
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

        public string Valid(string name, string dob, string address, string salary)
        {
            //create a string variable to store the error
            String Error = "";
            //create a temporary variable to store the values
            DateTime tempDOB;
            DateTime minAge = DateTime.Now.Date.AddYears(-18);
            DateTime maxAge = DateTime.Now.Date.AddYears(-100);

            //if the Name is blank
            if (name.Length == 0)
            {
                Error += "The Name my not be blank : ";
            }
            //if the Name is greater than 20 charactors
            if (name.Length > 20)
            {
                Error += "The Name must be less than 20 charactors: ";
            }

            try
            {
                //copy the dob value to the tempDOB variable
                tempDOB = Convert.ToDateTime(dob);
                //check to see if the dob less than 18 years
                if (tempDOB > minAge)
                {
                    Error += "The DOB cannot be less than 18 years old : ";
                }
                //check to see if the dob less than 18 years
                if (tempDOB < maxAge)
                {
                    Error += "The DOB cannot be more than 100 years old : ";
                }
            }
            catch
            {
                //record the error
                Error += "The date was not a valid date : ";
            }
            
            //return any error messages
            return Error;
        }
    }
}