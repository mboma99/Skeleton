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

        clsOrderLine AnOrderLine = new clsOrderLine();

        AnOrderLine = (clsOrderLine)Session["AnOrderLine"];
        
        Response.Write(AnOrderLine.OrderID);
        Response.Write(AnOrderLine.PricePaid);
        Response.Write(AnOrderLine.PetPrice);
        Response.Write(AnOrderLine.PetID);
        Response.Write(AnOrderLine.OrderStatus);
        Response.Write(AnOrderLine.Quantity);

    }
}