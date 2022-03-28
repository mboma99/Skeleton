using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
        //find the record to delete
        OrderLineList.SingleOrderLine.Find(OrderID);
        //delete the record
        OrderLineList.Delete();
        //redirect back to the main page
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to the list page
        Response.Redirect("OrderLineList.aspx");
    }

}