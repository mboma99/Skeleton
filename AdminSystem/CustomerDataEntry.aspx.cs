using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the CUstomer to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (CustomerID != -1)
            {
                DisplayCustomer();
            }
        }
    }
    void DisplayCustomer()
    {
        //create an instance of the customer book
        clsCustomerCollection CustomerBook = new clsCustomerCollection();
        //find the record to update
        CustomerBook.ThisCustomer.Find(CustomerID);
        //display the data for this record
        txtCustomerID.Text = CustomerBook.ThisCustomer.CustomerID.ToString();
        txtName.Text = CustomerBook.ThisCustomer.Name;
        txtDOB.Text = CustomerBook.ThisCustomer.DateOfBirth.ToString();
        txtCustomerDetails.Text = CustomerBook.ThisCustomer.CustomerDetails;
        txtAccountBalance.Text = CustomerBook.ThisCustomer.AccountBalance.ToString();
        lblPendingOrder.Checked = CustomerBook.ThisCustomer.PendingOrder;
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
            //capture CustomerID
            ACustomer.CustomerID = CustomerID;
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

            if (CustomerID == -1)
            {
                //set the thisCustomer property
                CustomerList.ThisCustomer = ACustomer;
                //add new record 
                CustomerList.Add();
            }
             else
            {
                //find the record to update
                CustomerList.ThisCustomer.Find(CustomerID);
                //set the thisCustomer 
                CustomerList.ThisCustomer = ACustomer;

                CustomerList.Update();
            }   
            
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
            txtName.Text = Acustomer.Name;
            txtDOB.Text = Acustomer.DateOfBirth.ToString();
            txtCustomerDetails.Text = Acustomer.CustomerDetails;
            txtAccountBalance.Text = Acustomer.AccountBalance.ToString();
        }

    }


}
