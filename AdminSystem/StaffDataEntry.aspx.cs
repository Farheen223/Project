using ClassLibrary;
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
        //Creating new instance of the class staff
        clsStaff Staff = new clsStaff();
        //Capture the name 
        string Name = txtName.Text;
        //Capture Hours worked
        string Hours = txtHoursWorked.Text;
        //Capture Email
        string Email = txtEmail.Text;
        //Capture Phone number
        string PhoneNumber = txtPhoneNumber.Text;
        //Capture Date
        string DateAdded = txtDateAdded.Text;
        //Capture checkbox
        string FullTime = chkFulltime.Text;
        string Error = "";
        //validate data
        Error = Staff.Valid(Name, Hours, PhoneNumber, Email, DateAdded);
        if (Error == "")
        {
            Staff.Name = Name;
            Staff.Hours = Hours;
            Staff.PhoneNumber = PhoneNumber;
            Staff.Email = Email;
            Staff.DateAdded = Convert.ToDateTime(DateAdded);
            Staff.FullTime = chkFulltime.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();
            //set ThisStaff property
            StaffList.ThisStaff = Staff;
            //add the new record
            StaffList.Add();
            //redirect to the list page
            Response.Redirect("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }


    protected void txtDateCreated_TextChanged(object sender, EventArgs e)
    {

    }

    protected void chkFulltime_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaff Staff = new clsStaff();
        Int32 StaffId;
        Boolean Found = false;
        StaffId = Convert.ToInt32(txtStaffId.Text);
        Found = Staff.Find(StaffId);
        if(Found == true)
        {
            txtName.Text = Staff.Name;
            txtPhoneNumber.Text = Staff.PhoneNumber;
            txtHoursWorked.Text = Staff.Hours;
            txtEmail.Text = Staff.Email;
            txtDateAdded.Text = Staff.DateAdded.ToString();
            chkFulltime.Checked = Staff.FullTime;
        }
    }
}