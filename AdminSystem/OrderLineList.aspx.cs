using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
            DisplayOrderLineList(OrderLineList);
        }
    }

    void DisplayOrderLineList(clsOrderLineCollection OrderLineList)
    {
        
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[6]
        {
            new DataColumn("orderID"), new DataColumn("petID"), new DataColumn("quantity"), new DataColumn("pricePaid"), new DataColumn("petPrice"), new DataColumn("orderStatus")
        });

        foreach (clsOrderLine AOrderLine in OrderLineList.OrderLine)
        {
            dt.Rows.Add(AOrderLine.OrderID, AOrderLine.PetID, AOrderLine.PetPrice, AOrderLine.PricePaid, AOrderLine.Quantity, AOrderLine.OrderStatus);
        }
        grvOrderLineList.DataSource = dt;
        grvOrderLineList.DataBind();
    }

    protected void grvOrderLineList_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int In = grvOrderLineList.SelectedIndex;
        foreach (GridViewRow row in grvOrderLineList.Rows)
        {
            if (row.RowIndex == grvOrderLineList.SelectedIndex)
            {
                row.BackColor = ColorTranslator.FromHtml("#6ba4ff");
            }
            else
            {
                row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OrderID"] = -1;
        //redirect to the data entry page
        Response.Redirect("OrderLineDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (grvOrderLineList.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(grvOrderLineList.SelectedRow.Cells[0].Text);
            //store teh data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderLineDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OrderID;
        //if a record has been selected from the list
        if (grvOrderLineList.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(grvOrderLineList.SelectedRow.Cells[0].Text);
            //store teh data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderLineConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();

        OrderLineList.FilterByOrderStatus(chkActive.Checked);
        
        DisplayOrderLineList(OrderLineList);
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();
        DisplayOrderLineList(OrderLineList);
    }

}