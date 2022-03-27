using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsOrdersCollection
    {
        List<clsOrders> mAllOrders = new List<clsOrders>();

        clsOrders mSingleOrder = new clsOrders();

        public List<clsOrders> Order
        {
            get
            {
                //return the private data
                return mAllOrders;
            }
            set
            {
                //set the private data
                mAllOrders = value;
            }
        }

        public int Count
        {
            get
            {
                //return the count of  the list
                return mAllOrders.Count;
            }
            set
            {
                //we shall worry about this later
            }
        }

        public clsOrders SingleOrder
        {
            get
            {
                //return the private data
                return mSingleOrder;
            }
            set
            {
                //set the private data
                mSingleOrder = value;
            }
        }

        public clsOrdersCollection()
        {
            //object for data conneection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrders_SelectAll");
            //populate the array list with the data tale
            PopulateList(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("OrderID", mSingleOrder.OrderID);
            DB.AddParameter("OrderStatus", mSingleOrder.OrderStatus);
            DB.AddParameter("CustomerID", mSingleOrder.CustomerID);
            DB.AddParameter("Approval", mSingleOrder.Approval);
            DB.AddParameter("SaleApplied", mSingleOrder.SaleApplied);

            return DB.Execute("sproc_tblOrders_SelectAll");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("OrderID", mSingleOrder.OrderID);
            DB.AddParameter("OrderStatus", mSingleOrder.OrderStatus);
            DB.AddParameter("CustomerID", mSingleOrder.CustomerID);
            DB.AddParameter("Approval", mSingleOrder.Approval);
            DB.AddParameter("SaleApplied", mSingleOrder.SaleApplied);

            DB.Execute("sproc_tblOrders_Update");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@OrderID", mSingleOrder.OrderID);

            DB.Execute("sproc_tblOrders_Delete");
        }

        public void FilterByorderStatus(bool orderStatus)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@orderStatus", orderStatus);

            DB.Execute("sproc_tbltblOrders_FilterByorderStatus");

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
            mAllOrders = new List<clsOrders>();
            //while there are records to process
            while (Index < RecordCount)
            {
                clsOrders AnOrder = new clsOrders();

                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                AnOrder.SaleApplied = Convert.ToBoolean(DB.DataTable.Rows[Index]["SaleApplied"]);
                AnOrder.Approval = Convert.ToBoolean(DB.DataTable.Rows[Index]["Approval"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["OrderStatus"]);

                mAllOrders.Add(AnOrder);

                Index++;
            }
        }
    }
}
