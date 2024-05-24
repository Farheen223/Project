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
        string CustomerName = txtCustomerName.Text;
        string CustomerSurname = TxtCustomerSurname.Text;
        //caputure the Date of Birth
        string DateAdded = txtDateAdded.Text;
        //capture the email
        string Email = txtEmail.Text;
        string ContactNumber = TxtContactNumber.Text;
        //capture the Is Active
        string Active = chkActive.Text;
        string Error = "";
        Error = AnCustomer.Valid(CustomerName, CustomerSurname, Email, DateAdded, ContactNumber);
        if (Error == "")
        {
            AnCustomer.CustomerName = CustomerName;
            AnCustomer.CustomerSurname = CustomerSurname;
            AnCustomer.Email = Email;
            AnCustomer.DateAdded = Convert.ToDateTime(DateAdded);
            AnCustomer.ContactNumber = ContactNumber;


            //store the address in the section object
            Session["AnCustomer"] = AnCustomer;
            //navigate to the view page
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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
            TxtCustomerSurname.Text = AnCustomer.CustomerSurname;
            txtDateAdded.Text = AnCustomer.DateAdded.ToString();
            txtEmail.Text = AnCustomer.Email;
            TxtContactNumber.Text = AnCustomer.ContactNumber;
            chkActive.Checked = AnCustomer.Active;
        }
       }
    }