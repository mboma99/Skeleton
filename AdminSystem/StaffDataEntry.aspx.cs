using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the StaffID to be processed
        StaffID = Convert.ToInt32(Session["StaffID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (StaffID != -1)
            {
                DisplayStaff();
            }
        }
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
            try
            {
                //capture the staff data
                AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
                AStaff.Name = txtName.Text;
                AStaff.DOB = Convert.ToDateTime(txtDOB.Text);
                AStaff.Address = txtAddress.Text;
                AStaff.Salary = Convert.ToDouble(txtSalary.Text);
                AStaff.IsActive = chkActive.Checked;

                //create a new instance of the staff collection
                clsStaffCollection StaffList = new clsStaffCollection();

                //if this is a new record i.e. StaffID = -1 then add the data
                if (StaffID == -1)
                {
                    //set the SingleStaff property
                    StaffList.SingleStaff = AStaff;
                    //add the new record
                    StaffList.Add();
                }
                else //otherwise it must be a update
                {
                    //find the record to update
                    StaffList.SingleStaff.Find(StaffID);
                    //set the SingleStaff property
                    StaffList.SingleStaff = AStaff;
                    //update the record
                    StaffList.Update();
                }

                //redirect back to the list page
                Response.Redirect("StaffList.aspx");
            }
            catch
            {
                txtStaffID.Text = Convert.ToString(0);
                lblError.Text = "Please try again";
            }
            
        }
        else
        {
            //display the error
            lblError.Text = Error;
        }
        
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //redirect back to the list page
        Response.Redirect("StaffList.aspx");
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
            txtDOB.Text = AStaff.DOB.ToString("MM/dd/yyyy");
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

    void DisplayStaff()
    {
        //create an instance of the staff collection
        clsStaffCollection StaffList = new clsStaffCollection();
        //find the record to update 
        StaffList.SingleStaff.Find(StaffID);
        //display the data for this record
        txtStaffID.Text = StaffList.SingleStaff.StaffID.ToString();
        txtName.Text = StaffList.SingleStaff.Name;
        txtDOB.Text = StaffList.SingleStaff.DOB.ToString("MM/dd/yyyy");
        txtAddress.Text = StaffList.SingleStaff.Address;
        txtSalary.Text = StaffList.SingleStaff.Salary.ToString();
        chkActive.Checked = StaffList.SingleStaff.IsActive;
    }
}