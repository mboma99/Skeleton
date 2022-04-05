using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is first page displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }

    void DisplayCustomers()
    {
        //cerate instance of Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        //set the data source to list of customers in the collection 
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "Name";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into session object to indicate this record is new
        Session["CustomerID"] = -1;
        //redirect to data entry page 
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 CustomerID;
        //if a reccord has been selected from the list 
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primafry key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //stored the data in the session object 
            Session["CustomerID"] = CustomerID;
            //redirect to edit page
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from list";
        }
    }






    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value
        Int32 CustomerID;
        //if a reccord has been selected from the list 
        if (lstCustomerList.SelectedIndex != -1)
        {
            //get the primafry key value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            //stored the data in the session object 
            Session["CustomerID"] = CustomerID;
            //redirect to edit page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //cerate instance of Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportyByName(txtFilter.Text);
        lstCustomerList.DataSource = Customers.CustomerList;
        //set name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the sat to the list
        lstCustomerList.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {

        //cerate instance of Customer Collection
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportyByName("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        lstCustomerList.DataSource = Customers.CustomerList;
        //set name of the primary key
        lstCustomerList.DataValueField = "CustomerID";
        //set name of the field to display
        lstCustomerList.DataTextField = "Name";
        //bind the sat to the list
        lstCustomerList.DataBind();
    }
}