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
            mOrderID = 3;
            mCustomerID = 3;
            mApproval = true;
            mSaleApplied = true;
            mOrderStatus = "En Route";
            return true;
        }
    }
}