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
            mOrderID = 3;
            mPetID = 3;
            mQuantity = 3;
            mPricePaid = 3.55;
            mPetPrice = 3.55;
            mOrderStatus = "En Route";

            return true;
        }
    }
}