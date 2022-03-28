using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();

        AnOrder = (clsOrders)Session["AnOrder"];

        Response.Write(AnOrder.OrderID);
        Response.Write(AnOrder.OrderStatus);
        Response.Write(AnOrder.SaleApplied);
        Response.Write(AnOrder.Approval);
        Response.Write(AnOrder.CustomerID);
    }
}