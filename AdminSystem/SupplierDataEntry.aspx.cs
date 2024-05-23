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
        // create a new instance of clsSupplier
        clsSupplier supplier = new clsSupplier();
        // capture the name
        string Name = txtSupplierName.Text;
        // capture the city
        string City = txtSupplierCity.Text;
        // capture the email
        string Email = txtSupplierEmail.Text;
        // capture the telephone number
        string TelephoneNumber = txtSupplierTelephoneNumber.Text;
        // Variable to store any error messages
        string Error = "";
        // Validate the data
        Error = supplier.Valid(Name, City, Email, TelephoneNumber);
        if (Error == "")
        {
            // capture the name
            supplier.Name = Name;
            // capture the city
            supplier.City = City;
            // capture the email
            supplier.Email = Email;
            // capture the telephone number
            supplier.TelephoneNumber = TelephoneNumber;
            // capture add date
            supplier.AddDate = Convert.ToDateTime(DateTime.Now);
            // capture availability check box
            supplier.Availability = chkSupplierAvailability.Checked;
            // Create a new instance of the supplier collection
            clsSupplierCollection SupplierList = new clsSupplierCollection();
            // Set the ThisSupplier property
            SupplierList.ThisSupplier = supplier;
            // Add the new record
            SupplierList.Add();
            // Redirect back to the list page
            Response.Redirect("SupplierList.aspx");
        }
        else
        {
            // Display error message
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of the supplier class
        clsSupplier supplier = new clsSupplier();
        // Create a variable to store the primary key
        Int32 SupplierId;
        // Create a variable to store the result of the find operation
        Boolean Found = false;
        // Get the primary key entered by the user
        SupplierId = Convert.ToInt32(txtSupplierId.Text);

        // Find the record
        Found = supplier.Find(SupplierId);
        if (Found == true)
        {
            // Display the values of the properties in the form if record
            // is found
            txtSupplierName.Text = supplier.Name;
            txtSupplierCity.Text = supplier.City;
            txtSupplierEmail.Text = supplier.Email;
            txtSupplierTelephoneNumber.Text = supplier.TelephoneNumber;
            chkSupplierAvailability.Checked = supplier.Availability;

        }
    }
}