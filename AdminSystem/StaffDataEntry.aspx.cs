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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the staff data
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.Name = txtName.Text;
        AStaff.DOB = Convert.ToDateTime(txtDOB.Text);
        AStaff.Address = txtAddress.Text;
        AStaff.Salary = Convert.ToDouble(txtSalary.Text);
        AStaff.IsActive = chkActive.Checked;
        //store the staff ID in the session object
        Session["AStaff"] = AStaff;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }
}