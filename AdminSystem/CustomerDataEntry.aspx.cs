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
        String Name = txtName.Text;

        //capture The CustomerDOB
        String DateOfBirth = txtDOB.Text;

        //capture the Customer Details
        String CustomerDetails = txtCustomerDetails.Text;

        //capture the Account accountBalance
        String AccountBalance = txtAccountBalance.Text;

        //Store error messages
        String Error = "";

        //Validate the data 
        Error = ACustomer.Valid(Name, DateOfBirth, CustomerDetails, AccountBalance);
        if (Error == "") 
        {
            //capture Name 
            ACustomer.Name = Name;
            //Capture DOB
            ACustomer.DateOfBirth = Convert.ToDateTime(DateOfBirth);
            //Capture Customer Details
            ACustomer.CustomerDetails = CustomerDetails;
            //Capture Account Balance
            ACustomer.AccountBalance = Convert.ToDouble(AccountBalance);
            //capture Pending Order
            ACustomer.PendingOrder = lblPendingOrder.Checked;

            //Create a new instance of address collection
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            //set the thisCustomer property
            CustomerList.ThisCustomer = ACustomer;
            //add new record 
            CustomerList.Add();
            Response.Redirect("CustomerList.aspx");

        }
        else
        {
            //display the error message 
            lblError.Text = Error;
        }
        


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
