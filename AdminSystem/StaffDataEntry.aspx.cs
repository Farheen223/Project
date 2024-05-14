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
        Staff.Name = txtName.Text;
        //Capture Hours worked
        Staff.Hours = txtHoursWorked.Text;
        //Capture Email
        Staff.Email = txtEmail.Text;
        //Capture Phone number
        Staff.PhoneNumber = txtPhoneNumber.Text;
        //Capture Date
        Staff.DateAdded = Convert.ToDateTime(DateTime.Now);
        //Capture checkbox
        Staff.FullTime = chkFulltime.Checked;
        Session["Staff"] = Staff;
        //Takes the user to the view page
        Response.Redirect("StaffViewer.aspx");

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
            txtDateCreated.Text = Staff.DateAdded.ToString();
            chkFulltime.Checked = Staff.FullTime;
        }
    }
}