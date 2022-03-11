using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();

        AnOrder.OrderStatus = txtOrderStatus.Text;

        Session["AnOrder"] = AnOrder;


        Response.Redirect("OrderViewer.aspx");
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