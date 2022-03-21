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
        //capture the staff data for validation
        string Name = txtName.Text;
        string DOB = txtDOB.Text;
        string Address = txtAddress.Text;
        string Salary = txtSalary.Text;
        //variable to store any error messages
        string Error = "";
        //Validate the data
        Error = AStaff.Valid(Name, DOB, Address, Salary);
        if (Error == "")
        {
            //clear Error label
            lblError.Text = "";
            //capture the staff data
            AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
            AStaff.Name = txtName.Text;
            AStaff.DOB = Convert.ToDateTime(txtDOB.Text);
            AStaff.Address = txtAddress.Text;
            AStaff.Salary = Convert.ToDouble(txtSalary.Text);
            AStaff.IsActive = chkActive.Checked;
            //create a new instance of the staff collection
            clsStaffCollection StaffList = new clsStaffCollection();
            //set the SingleStaff property
            StaffList.SingleStaff = AStaff;
            //add the new record
            StaffList.Add();
            //redirect back to teh list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            //display the error
            lblError.Text = Error;
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff AStaff = new clsStaff();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(StaffID);
        if (Found == true)
        {
            //txtStaffID.Text = AStaff.StaffID;
            txtName.Text = AStaff.Name;
            txtDOB.Text = Convert.ToString(AStaff.DOB);
            txtAddress.Text = AStaff.Address;
            txtSalary.Text = Convert.ToString(AStaff.Salary);
            chkActive.Checked = AStaff.IsActive;
        }
        else
        {
            txtName.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtSalary.Text = string.Empty;
            chkActive.Checked = false;
            lblError.Text = "StaffID: " + StaffID + " doesn't exist";
        }
    }
}