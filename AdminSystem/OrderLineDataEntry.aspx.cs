using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();

        AnOrderLine.OrderStatus = txtOrderStatus.Text;

        Session["AnOrderLine"] = AnOrderLine;

        Response.Redirect("OrderLineViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();

        Int32 OrderID;

        Boolean Found = false;

        OrderID = Convert.ToInt32(txtOrderID.Text);

        Found = AnOrderLine.Find(OrderID);

        if(Found == true)
        {
            txtQuantity.Text = AnOrderLine.Quantity.ToString();
            txtPricePaid.Text = AnOrderLine.PricePaid.ToString();
            txtPetPrice.Text = AnOrderLine.PetPrice.ToString();
            txtPetID.Text = AnOrderLine.PetID.ToString();
            txtOrderStatus.Text = AnOrderLine.OrderStatus;
            txtOrderID.Text = AnOrderLine.OrderID.ToString();
        }
    }
}