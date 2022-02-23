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
}