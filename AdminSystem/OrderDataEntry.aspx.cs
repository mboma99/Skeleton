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
                DisplayOrder();
            }
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the list page
        Response.Redirect("OrderList.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();

        string OrderStatus = txtOrderStatus.Text;
        string CustomerID = txtCustomerID.Text;
        string Approval = txtApproval.Text;
        string SaleApplied = txtSaleApplied.Text;

        string Error = "";

        Error = AnOrder.Valid(SaleApplied, Approval, CustomerID, OrderStatus);

        if (Error == "")
        {
            //clear Error label
            lblError.Text = "";
            try
            {                
                AnOrder.OrderStatus = txtOrderStatus.Text;
                AnOrder.OrderID = Convert.ToInt32(txtOrderID.Text);
                AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
                AnOrder.Approval = Convert.ToBoolean(txtApproval.Text);
                AnOrder.SaleApplied = Convert.ToBoolean(txtSaleApplied.Text);

                clsOrdersCollection OrderList = new clsOrdersCollection();

                if (OrderID == -1)
                {
                    OrderList.SingleOrder = AnOrder;
                    //add the new record
                    OrderList.Add();
                }
                else //otherwise it must be a update
                {
                    //find the record to update
                    OrderList.SingleOrder.Find(OrderID);
                    OrderList.SingleOrder = AnOrder;
                    //update the record
                    OrderList.Update();
                }

                //redirect back to the list page
                Response.Redirect("OrderList.aspx");
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
            //txtOrderID.Text = AnOrder.OrderID;
            txtCustomerID.Text = Convert.ToString(AnOrder.CustomerID);
            txtApproval.Text = Convert.ToString(AnOrder.Approval);
            txtSaleApplied.Text = Convert.ToString(AnOrder.SaleApplied);
            txtOrderStatus.Text = AnOrder.OrderStatus;
            lblError.Text = "";
        }
        else
        {
            txtCustomerID.Text = string.Empty;
            txtApproval.Text = string.Empty;
            txtSaleApplied.Text = string.Empty;
            txtOrderStatus.Text = string.Empty;
            lblError.Text = "OrderID: " + OrderID + " doesn't exist";
        }
    }

    private void DisplayOrder()
    {
        clsOrdersCollection OrderList = new clsOrdersCollection();

        OrderList.SingleOrder.Find(OrderID);

        txtOrderID.Text = OrderList.SingleOrder.OrderID.ToString();
        txtSaleApplied.Text = OrderList.SingleOrder.SaleApplied.ToString();
        txtApproval.Text = OrderList.SingleOrder.Approval.ToString();
        txtOrderStatus.Text = OrderList.SingleOrder.OrderStatus;
        txtCustomerID.Text = OrderList.SingleOrder.CustomerID.ToString();
    }
}