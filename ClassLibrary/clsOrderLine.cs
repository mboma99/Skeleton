using System;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsOrderLine
    {
        private Int32 mOrderID;
        public int OrderID
        {
            get
            {
                //return the private data
                return mOrderID;
            }
            set
            {
                //set the value of the private data member
                mOrderID = value;
            }
        }

        private Int32 mPetID;
        public int PetID
        {
            get
            {
                //return the private data
                return mPetID;
            }
            set
            {
                //set the value of the private data member
                mPetID = value;
            }
        }

        private Int32 mQuantity;
        public int Quantity
        {
            get
            {
                //return the private data
                return mQuantity;
            }
            set
            {
                //set the value of the private data member
                mQuantity = value;
            }
        }

        public string Valid(string petID, string quantity, string pricePaid, string petPrice, string orderStatus)
        {
            return "";
        }

        private double mPricePaid;
        public double PricePaid
        {
            get
            {
                //return the private data
                return mPricePaid;
            }
            set
            {
                //set the value of the private data member
                mPricePaid = value;
            }
        }

        private double mPetPrice;
        public double PetPrice
        {
            get
            {
                //return the private data
                return mPetPrice;
            }
            set
            {
                //set the value of the private data member
                mPetPrice = value;
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
            DB.Execute("sproc_tblOrderLine_FilterByOrderID");
            //if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mPetID = Convert.ToInt32(DB.DataTable.Rows[0]["PetID"]);
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mPricePaid = Convert.ToDouble(DB.DataTable.Rows[0]["PricePaid"]);
                mPetPrice = Convert.ToDouble(DB.DataTable.Rows[0]["PetPrice"]);
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