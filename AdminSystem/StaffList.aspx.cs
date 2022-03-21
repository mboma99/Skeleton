using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaffList();
        }
    }

    void DisplayStaffList()
    {
        //create an instance of the Staff Collection
        clsStaffCollection StaffList = new clsStaffCollection();
        //set the data source to list of staff in the collection
        lstStaffList.DataSource = StaffList.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "Name";
        //lstStaffList.DataTextField = "DOB";
        //lstStaffList.DataTextField = "Address";
        //lstStaffList.DataTextField = "Salary";
        //lstStaffList.DataTextField = "IsActive";
        //bind the data to the list
        lstStaffList.DataBind();
    }
}