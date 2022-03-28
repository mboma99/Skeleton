using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            clsOrdersCollection OrderList = new clsOrdersCollection();
            DisplayOrderList(OrderList);
        }
    }

    void DisplayOrderList(clsOrdersCollection OrderList)
    {

        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[5]
        {
            new DataColumn("orderID"), new DataColumn("customerID"), new DataColumn("approval"), new DataColumn("saleApplied"), new DataColumn("orderStatus")
        });

        foreach (clsOrders AnOrder in OrderList.Order)
        {
            dt.Rows.Add(AnOrder.OrderID, AnOrder.CustomerID, AnOrder.Approval, AnOrder.SaleApplied, AnOrder.OrderStatus);
        }
        grvOrderList.DataSource = dt;
        grvOrderList.DataBind();
    }

    protected void grvOrderList_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        int In = grvOrderList.SelectedIndex;
        foreach (GridViewRow row in grvOrderList.Rows)
        {
            if (row.RowIndex == grvOrderList.SelectedIndex)
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
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 OrderID;
        //if a record has been selected from the list
        if (grvOrderList.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to edit
            OrderID = Convert.ToInt32(grvOrderList.SelectedRow.Cells[0].Text);
            //store teh data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderDataEntry.aspx");
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
        if (grvOrderList.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to delete
            OrderID = Convert.ToInt32(grvOrderList.SelectedRow.Cells[0].Text);
            //store teh data in the session object
            Session["OrderID"] = OrderID;
            //redirect to the edit page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {

        clsOrdersCollection OrderList = new clsOrdersCollection();

        OrderList.FilterByOrderStatus(chkActive.Checked);

        DisplayOrderList(OrderList);
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrdersCollection OrderList = new clsOrdersCollection();
        DisplayOrderList(OrderList);
    }
}