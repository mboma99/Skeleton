using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
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
                DisplayOrderLine();
            }
        }
    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrderLine AnOrderLine = new clsOrderLine();

        string OrderStatus = txtOrderStatus.Text;
        string PetID = txtPetID.Text;
        string PetPrice = txtPetPrice.Text;
        string PricePaid = txtPricePaid.Text;
        string Quantity = txtQuantity.Text;

        string Error = "";

        Error = AnOrderLine.Valid(PetID, Quantity, PricePaid, PetPrice, OrderStatus);

        if (Error == "")
        {
            //clear Error label
            lblError.Text = "";
            try
            {
                //capture the staff data
                AnOrderLine.OrderStatus = txtOrderStatus.Text;
                AnOrderLine.OrderID = Convert.ToInt32(txtOrderID.Text);
                AnOrderLine.PetID = Convert.ToInt32(txtPetID.Text);
                AnOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
                AnOrderLine.PetPrice = Convert.ToDouble(txtPetPrice.Text);
                AnOrderLine.PricePaid = Convert.ToDouble(txtPricePaid.Text);

                //create a new instance of the staff collection
                clsOrderLineCollection OrderLineList = new clsOrderLineCollection();

                //if this is a new record i.e. StaffID = -1 then add the data
                if (OrderID == -1)
                {
                    //set the SingleStaff property
                    OrderLineList.SingleOrderLine = AnOrderLine;
                    //add the new record
                    OrderLineList.Add();
                }
                else //otherwise it must be a update
                {
                    //find the record to update
                    OrderLineList.SingleOrderLine.Find(OrderID);
                    //set the SingleStaff property
                    OrderLineList.SingleOrderLine = AnOrderLine;
                    //update the record
                    OrderLineList.Update();
                }

                //redirect back to the list page
                Response.Redirect("OrderLineViewer.aspx");
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
        clsOrderLine AnOrderLine = new clsOrderLine();

        Int32 OrderID;

        Boolean Found = false;

        OrderID = Convert.ToInt32(txtOrderID.Text);

        Found = AnOrderLine.Find(OrderID);

        if (Found == true)
        {
            txtQuantity.Text = AnOrderLine.Quantity.ToString();
            txtPricePaid.Text = AnOrderLine.PricePaid.ToString();
            txtPetPrice.Text = AnOrderLine.PetPrice.ToString();
            txtPetID.Text = AnOrderLine.PetID.ToString();
            txtOrderStatus.Text = AnOrderLine.OrderStatus;
            txtOrderID.Text = AnOrderLine.OrderID.ToString();
        }
    }

    private void DisplayOrderLine()
    {
        clsOrderLineCollection OrderLineList = new clsOrderLineCollection();

        OrderLineList.SingleOrderLine.Find(OrderID);

        txtOrderID.Text = OrderLineList.SingleOrderLine.OrderID.ToString();
        txtPetID.Text = OrderLineList.SingleOrderLine.PetID.ToString();
        txtQuantity.Text = OrderLineList.SingleOrderLine.Quantity.ToString();
        txtOrderStatus.Text = OrderLineList.SingleOrderLine.OrderStatus;
        txtPricePaid.Text = OrderLineList.SingleOrderLine.PricePaid.ToString();
        txtPetPrice.Text = OrderLineList.SingleOrderLine.PetPrice.ToString();

    }
}