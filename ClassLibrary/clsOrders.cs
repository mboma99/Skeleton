using System;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrders
    {
        private Int32 mOrderID;
        public int OrderID
        {
            get
            {
                return mOrderID;

            }

            set
            {
                mOrderID = value;
            }
        }

        private Int32 mCustomerID;
        public int CustomerID
        {
            get
            {
                return mCustomerID;

            }

            set
            {
                mCustomerID = value;
            }
        }

        private Boolean mApproval;
        public bool Approval
        {
            get
            {
                //return the private data
                return mApproval;
            }
            set
            {
                //set the value of the private data member
                mApproval = value;
            }
        }

        public string Valid(string customerID, string approval, string saleApplied, string orderStatus)
        {
            return "";
        }

        private Boolean mSaleApplied;
        public bool SaleApplied
        {
            get
            {
                //return the private data
                return mSaleApplied;
            }
            set
            {
                //set the value of the private data member
                mSaleApplied = value;
            }
        }

        private string mOrderStatus;
        public string OrderStatus
        {
            get
            {
                //return the private data
                return mOrderStatus;
            }
            set
            {
                //set the value of the private data member
                mOrderStatus = value;
            }
        }

        public bool Find(int OrderID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff ID to search for
            DB.AddParameter("@OrderID", OrderID);
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mApproval = Convert.ToBoolean(DB.DataTable.Rows[0]["Approval"]);
                mSaleApplied = Convert.ToBoolean(DB.DataTable.Rows[0]["SaleApplied"]);
                mOrderStatus = Convert.ToString(DB.DataTable.Rows[0]["OrderStatus"]);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}