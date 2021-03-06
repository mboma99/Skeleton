using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ClassLibrary
{
    public class clsCustomer
    {

        private Int32 mCustomerID;
        public int CustomerID
        {
            get 
            { return mCustomerID; }
            set 
            { mCustomerID = value; }
        }
        
        private String mName;
        public string Name 
        { 
            get { return mName; }
            set { mName = value; }
        }

        private DateTime mDateOfBirth;
        public DateTime DateOfBirth 
        { 
            get { return mDateOfBirth; }
            set { mDateOfBirth = value; }
        }

        private String mCustomerDetails;
        public string CustomerDetails 
        { 
            get { return mCustomerDetails; }
            set { mCustomerDetails = value; }
        }

        private double mAccountBalance;
        public double AccountBalance 
        { 
            get { return mAccountBalance; }
            set { mAccountBalance = value; }
        }

        private bool mPendingOrder;
        public bool PendingOrder 
        { 
            get { return mPendingOrder; }
            set { mPendingOrder = value; }
        }

        public bool Find(int CustomerID)
        {
            //create an instace of a data connection 
            clsDataConnection DB = new clsDataConnection();

            //add the parameter for the Customer Id
            DB.AddParameter("@CustomerID", CustomerID);
            //execute stored Procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerID");
            //if one record is found (there should be either one or zero)
            if (DB.Count == 1) 
            {
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[0]["Dob"]);
                mCustomerDetails = Convert.ToString(DB.DataTable.Rows[0]["CustomerDetails"]);
                mAccountBalance = Convert.ToDouble(DB.DataTable.Rows[0]["AccountBalance"]);
                mPendingOrder = Convert.ToBoolean(DB.DataTable.Rows[0]["PendingOrder"]);

                //return true if everything worked
                return true;
            }
            //lock if no record found
            else
            {
                //indicate ther's a problem
                return false;
            }
        }

        public string Valid(string name, string dob, string customerDetails, string accountBalance)
        {
            //create a string variable to store the error 
            String Error = "";
            //Create Date Time of temp variable
            DateTime DateTemp;
            //create Double for temp variable 
            double DoubleTemp;
            //if Name is blank/empty
            if (name.Length == 0)
            {
                //record error 
                Error += "The Name may cannot be left blank : ";
            }
            if (name.Length > 50)
            {
                Error += "The name cannot have more than 50 characters : ";
            }
            if (name.Contains("@")||name.Contains("$") || name.Contains("£") || name.Contains("%") || name.Contains("!")
                || name.Contains("#") || name.Contains("~") || name.Contains("?"))
            {
                Error += "Invalid characters @,$,£,%,!,#,~,? please remove from name : ";
            }
            try
            {
                //copy dob to DataTemp
                DateTemp = Convert.ToDateTime(dob);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record error
                    Error += "DOB must be within the last 100 years : ";
                }
                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    Error += "Too young to make account, must be at least 18 years old : ";
                }
            }
            catch
            {
                Error += "This is not a valid date format : ";
            }

            if (customerDetails.Length == 0)
            {
                Error += "Can't leave Address Blank : ";
            }
            if (customerDetails.Length > 200)
            {
                Error += "Customer details cannot have more than 200 characters : ";
            }
            if (customerDetails.Length < 1)
            {
                Error += "Please Enter valid details, cannot be less than 1 character : ";
            }
            if (customerDetails.Contains("@") || customerDetails.Contains("$") || customerDetails.Contains("£") || customerDetails.Contains("%") || customerDetails.Contains("!")
                || customerDetails.Contains("#") || customerDetails.Contains("~") || customerDetails.Contains("?"))
            {
                Error += "Invalid characters @,$,£,%,!,#,~,? please remove from customer details : ";
            }
            try
            {
                DoubleTemp = Convert.ToDouble(accountBalance);
                if (DoubleTemp < 0.00)
                {
                    Error += "Value is less than valid Account Balance. 0.00 is allowed minimum : ";
                }
                if (DoubleTemp > 1000.00)
                {
                    Error += "Value is more than valid Account Balance. 1000.00 is allowed maximum : ";
                }

            }
            catch
            {
                Error += "This is not a valid double value : ";
            }
            //return any error message 
            return Error;
        }
    }
}