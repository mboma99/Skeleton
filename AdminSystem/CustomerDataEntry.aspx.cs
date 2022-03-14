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

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clasCustomer
        clsCustomer ACustomer = new clsCustomer();

        //capture the Customer Name
        ACustomer.Name = txtName.Text;

        //capture The CustomerDOB
        ACustomer.DateOfBirth = Convert.ToDateTime(txtDOB.Text);

        //capture the Customer Details
        ACustomer.CustomerDetails = txtCustomerDetails.Text;

        //capture the Account accountBalance
        ACustomer.AccountBalance = Convert.ToDouble(txtAccountBalance.Text);
        
        //check if Pending order is checked
        ACustomer.PendingOrder = lblPendingOrder.Checked;
        
        //store name in the session object
        Session["ACustomer"] = ACustomer;
        
        //navigate to the viewer page
        Response.Redirect("CustomerViewer.aspx");


    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtDOB_TextChanged(object sender, EventArgs e)
    {

    }

    protected void lblPendingOrder_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCustomer Acustomer = new clsCustomer();

        Int32 CustomerID;

        Boolean Found = false;

        CustomerID = Convert.ToInt32(txtCustomerID.Text);

        Found = Acustomer.Find(CustomerID);

        if (Found == true)
        {
            txtCustomerID.Text = Acustomer.CustomerID.ToString();
            txtName.Text = Acustomer.Name;
            txtDOB.Text = Acustomer.DateOfBirth.ToString();
            txtCustomerDetails.Text = Acustomer.CustomerDetails;
            txtAccountBalance.Text = Acustomer.AccountBalance.ToString();
        }
    }
}
