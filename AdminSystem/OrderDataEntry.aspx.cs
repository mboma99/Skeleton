using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (OrderID != -1)
            {
                DisplayOrders();
            }
        }
    }

    private void DisplayOrders()
    {
        clsOrdersCollection OrderList = new clsOrdersCollection();

        OrderList.SingleOrder.Find(OrderID);

        txtOrderID.Text = OrderList.SingleOrder.OrderID.ToString();
        txtCustomerID.Text = OrderList.SingleOrder.CustomerID.ToString();
        txtApproval.Text = OrderList.SingleOrder.Approval.ToString();
        txtOrderStatus.Text = OrderList.SingleOrder.OrderStatus;
        txtSaleApplied.Text = OrderList.SingleOrder.SaleApplied.ToString();

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();

        string CustomerID = txtCustomerID.Text;
        string Approval = txtApproval.Text;
        string SaleApplied = txtSaleApplied.Text;
        string OrderStatus = txtOrderStatus.Text;

        string Error = "";

        Error = AnOrder.Valid(CustomerID, Approval, SaleApplied, OrderStatus);

        if (Error == "")
        {
            //clear Error label
            lblError.Text = "";
            try
            {
                //capture the staff data
                AnOrder.OrderStatus = txtOrderStatus.Text;
                AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
                AnOrder.Approval = Convert.ToBoolean(txtApproval.Text);
                AnOrder.SaleApplied = Convert.ToBoolean(txtSaleApplied.Text);
                AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);

                //create a new instance of the staff collection
                clsOrdersCollection OrdersList = new clsOrdersCollection();

                //if this is a new record i.e. StaffID = -1 then add the data
                if (OrderID == -1)
                {
                    //set the SingleStaff property
                    OrdersList.SingleOrder = AnOrder;
                    //add the new record
                    OrdersList.Add();
                }
                else //otherwise it must be a update
                {
                    //find the record to update
                    OrdersList.SingleOrder.Find(OrderID);
                    //set the SingleStaff property
                    OrdersList.SingleOrder = AnOrder;
                    //update the record
                    OrdersList.Update();
                }

                //redirect back to the list page
                Response.Redirect("OrderViewer.aspx");
            }
            catch
            {
                txtOrderID.Text = Convert.ToString(0);
                lblError.Text = "Please try again";
            }

        }
        else
        {
            //display the error
            lblError.Text = Error;
        }

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();

        Int32 OrderID;

        Boolean Found = false;

        OrderID = Convert.ToInt32(txtOrderID.Text);

        Found = AnOrder.Find(OrderID);

        if (Found == true)
        {
            txtApproval.Text = AnOrder.Approval.ToString();
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtSaleApplied.Text = AnOrder.SaleApplied.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus;
            txtOrderID.Text = AnOrder.OrderID.ToString();
        }
    }
}