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
        if (IsPostBack == false)
        {
            DisplayStaff();
        }

        clsStaffUser Staff = new clsStaffUser();
        //get the data from the session object
        Staff = (clsStaffUser)Session["Staff"];
        //Display the username
        Response.Write("Logged in as: " + Staff.UserName);
    }



    void DisplayStaff()
    {
        clsStaffCollection Staff = new clsStaffCollection();
        //set the data source  to list of staff in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the data field to display
        lstStaffList.DataValueField = "StaffId";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate the new record
        Session["StaffId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnFilter_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        //retrieve the value of the name from the presentation layer
        Staff.ReportByID(txtFilter.Text);
        //set the data source to the list of addresses in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffId";
        //Bind the Data to the list
        lstStaffList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsStaffCollection Staff = new clsStaffCollection();
        //set an empty string
        Staff.ReportByID("");
        //clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        //set the data source to the list of addresses in the collection
        lstStaffList.DataSource = Staff.StaffList;
        //Set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffId";
        lstStaffList.DataBind();
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffId;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            StaffId = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffId"] = StaffId;
            //redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }

    protected void BtnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

}