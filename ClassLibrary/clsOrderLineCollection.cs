using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderLineCollection
    {

        List<clsOrderLine> mAllOrderLine = new List<clsOrderLine>();

        clsOrderLine mSingleOrderLine = new clsOrderLine();

        public List<clsOrderLine> OrderLine
        {
            get
            {
                //return the private data
                return mAllOrderLine;
            }
            set
            {
                //set the private data
                mAllOrderLine = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of  the list
                return mAllOrderLine.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsOrderLine SingleOrderLine
        {
            get
            {
                //return the private data
                return mSingleOrderLine;
            }
            set
            {
                //set the private data
                mSingleOrderLine = value;
            }
        }

        public clsOrderLineCollection()
        {
            //object for data conneection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrderLine_SelectAll");
            //populate the array list with the data tale
            PopulateList(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("OrderStatus", mSingleOrderLine.OrderStatus);
            DB.AddParameter("PetID", mSingleOrderLine.PetID);
            DB.AddParameter("PetPrice", mSingleOrderLine.PetPrice);
            DB.AddParameter("PricePaid", mSingleOrderLine.PricePaid);
            DB.AddParameter("Quantity", mSingleOrderLine.Quantity);

            return DB.Execute("sproc_tblOrderLine_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("OrderID", mSingleOrderLine.OrderID);
            DB.AddParameter("OrderStatus", mSingleOrderLine.OrderStatus);
            DB.AddParameter("PetID", mSingleOrderLine.PetID);
            DB.AddParameter("PetPrice", mSingleOrderLine.PetPrice);
            DB.AddParameter("PricePaid", mSingleOrderLine.PricePaid);
            DB.AddParameter("Quantity", mSingleOrderLine.Quantity);

            DB.Execute("sproc_tblOrderLine_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mSingleOrderLine.OrderID);

            DB.Execute("sproc_tblOrderLine_Delete");
        }

        public void FilterByOrderStatus(bool orderStatus)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@orderStatus", orderStatus);

            DB.Execute("sproc_tblOrderLine_FilterByOrderStatus");

            PopulateList(DB);
        }

        void PopulateList(clsDataConnection DB)
        {
            //var for the index
            int Index = 0;
            //var to store the record count
            int RecordCount = 0;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mAllOrderLine = new List<clsOrderLine>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsOrderLine AnOrderLine = new clsOrderLine();

                AnOrderLine.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrderLine.PetID = Convert.ToInt32(DB.DataTable.Rows[Index]["PetID"]);
                AnOrderLine.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AnOrderLine.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);
                AnOrderLine.PricePaid = Convert.ToDouble(DB.DataTable.Rows[Index]["PricePaid"]);
                AnOrderLine.PetPrice = Convert.ToDouble(DB.DataTable.Rows[Index]["PetPrice"]);
                AnOrderLine.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);

                mAllOrderLine.Add(AnOrderLine);

                Index++;
            }
        }
    }
}
