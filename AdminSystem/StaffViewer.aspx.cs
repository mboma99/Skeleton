using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //get the date from the session object
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff ID for this entry
        Response.Write(AStaff.StaffID);
        Response.Write(AStaff.Name);
        Response.Write(AStaff.DOB);
        Response.Write(AStaff.Address);
        Response.Write(AStaff.Salary);
        Response.Write(AStaff.IsActive);
    }
}