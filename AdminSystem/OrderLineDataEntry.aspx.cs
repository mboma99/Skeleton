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

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the list page
        Response.Redirect("OrderLineList.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsOrderLine AnOrderLine = new clsOrderLine();

        string petID = txtPetID.Text;
        string quantity = txtQuantity.Text;
        string pricePaid = txtPricePaid.Text;
        string petPrice = txtPetPrice.Text;
        string orderStatus = txtOrderStatus.Text;
        //variable to store any error messages
        string Error = "";
        //Validate the data
        Error = AnOrderLine.Valid(petID, quantity, pricePaid, petPrice, orderStatus);
        if (Error == "")
        {
            //clear Error label
            lblError.Text = "";
            try
            {

                AnOrderLine.OrderID = Convert.ToInt32(txtOrderID.Text);
                AnOrderLine.PetID = Convert.ToInt32(txtPetID.Text);
                AnOrderLine.Quantity = Convert.ToInt32(txtQuantity.Text);
                AnOrderLine.OrderStatus = txtOrderStatus.Text;
                AnOrderLine.PetPrice = Convert.ToDouble(txtPetPrice.Text);
                AnOrderLine.PricePaid = Convert.ToDouble(txtPricePaid.Text);

                clsOrderLineCollection OrderLineList = new clsOrderLineCollection();


                if (OrderID == -1)
                {

                    OrderLineList.SingleOrderLine = AnOrderLine;
                    //add the new record
                    OrderLineList.Add();
                }
                else //otherwise it must be a update
                {
                    //find the record to update
                    OrderLineList.SingleOrderLine.Find(OrderID);

                    OrderLineList.SingleOrderLine = AnOrderLine;
                    //update the record
                    OrderLineList.Update();
                }

                //redirect back to the list page
                Response.Redirect("OrderLineList.aspx");
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
            //txtOrderID.Text = AnOrderLine.OrderID;
            txtPetID.Text = Convert.ToString(AnOrderLine.PetID);
            txtQuantity.Text = Convert.ToString(AnOrderLine.Quantity);
            txtPricePaid.Text = Convert.ToString(AnOrderLine.PricePaid);
            txtPetPrice.Text = Convert.ToString(AnOrderLine.PetPrice);
            txtOrderStatus.Text = AnOrderLine.OrderStatus;
            lblError.Text = "";
        }
        else
        {
            txtPetID.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPricePaid.Text = string.Empty;
            txtPetPrice.Text = string.Empty;
            txtOrderStatus.Text = string.Empty;
            lblError.Text = "OrderID: " + OrderID + " doesn't exist";
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