using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtCustomerId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }



    protected void txtAddressId_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the CustomerName
        AnCustomer.CustomerName = txtCustomerName.Text;
        //caputure the Date of Birth
        AnCustomer.DateOfBirth = Convert.ToDateTime(DateTime.Now);
        //capture the email
        AnCustomer.Email = Convert.ToString(txtEmail.Text);
        //capture the Is Active
        AnCustomer.Active = chkActive.Checked;
        //store the address in the section object
        Session["AnCustomer"] = AnCustomer;
        //navigate to the view page
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }



    protected void txtDateOfBirth_TextChanged(object sender, EventArgs e)

    {

    }

    protected void chkActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer AnCustomer = new clsCustomer();
        //create a vaiable to store the primary key
        Int32 CustomerId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        //find the record
        Found = AnCustomer.Find(CustomerId);
        //if found
        if (Found == true)
        {
            //displau the value of the properties in the form
            txtCustomerName.Text = AnCustomer.CustomerName;
            txtDateOfBirth.Text = AnCustomer.DateOfBirth.ToString();
            txtEmail.Text = AnCustomer.Email;
            chkActive.Checked = AnCustomer.Active;

        }
       }
    }