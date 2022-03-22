using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            //DisplayStaffList();
            clsStaffCollection StaffList = new clsStaffCollection();
            DisplayGridView(StaffList);
        }
    }

    void DisplayGridView(clsStaffCollection StaffList)
    {
        //create an instance of the Staff Collection
        //clsStaffCollection StaffList = new clsStaffCollection();
        DataTable dt = new DataTable();
        dt.Columns.AddRange(new DataColumn[6]
        {
            new DataColumn("StaffID"), new DataColumn("Name"), new DataColumn("DOB"), new DataColumn("Address"), new DataColumn("Salary"), new DataColumn("IsActive")
        });

        foreach (clsStaff AStaff in StaffList.StaffList)
        {
            dt.Rows.Add(AStaff.StaffID, AStaff.Name, AStaff.DOB.ToString("MM/dd/yyyy"), AStaff.Address, AStaff.Salary, AStaff.IsActive);
        }
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }

    protected void OnSelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow row in GridView1.Rows)
        {
            if (row.RowIndex == GridView1.SelectedIndex)
            {
                row.BackColor = ColorTranslator.FromHtml("#1d90ff");
            }
            else
            {
                row.BackColor = ColorTranslator.FromHtml("#FFFFFF");
            }
        }
    }

    /*void DisplayStaffList()
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
*/
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (GridView1.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
            //store teh data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }

        //if a record has been selected from the list
        /*if (lstStaffList.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store teh data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to edit from the list";
        }*/
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (GridView1.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(GridView1.SelectedRow.Cells[0].Text);
            //store teh data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }
        /*//if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //Clear the error label
            lblError.Text = "";
            //get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store teh data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else //if no record has been selected
        {
            lblError.Text = "Please select a record to delete from the list";
        }*/
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the Staff Collection
        clsStaffCollection StaffList = new clsStaffCollection();
        StaffList.FilterByIsActive(chkActive.Checked);
        DisplayGridView(StaffList);
        /*//set the data source to list of staff in the collection
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
        lstStaffList.DataBind();*/
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //DisplayStaffList();
        clsStaffCollection StaffList = new clsStaffCollection();
        DisplayGridView(StaffList);
    }
}