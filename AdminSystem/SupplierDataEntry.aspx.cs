using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    // Variable to store the primary key with page level scope
    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the number of the supplier to be processed
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            // If this not a new record
            if (SupplierID != -1)
            {
                // Display the current data for the record
                DisplaySupplier();
            }
        }
    }

    void DisplaySupplier()
    {
        // Create an instance of the supplier collection
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();
        // Find the record to update
        AllSuppliers.ThisSupplier.Find(SupplierID);
        // Display the data for the record
        txtSupplierName.Text = AllSuppliers.ThisSupplier.Name.ToString();
        txtSupplierCity.Text = AllSuppliers.ThisSupplier.City.ToString();
        txtSupplierEmail.Text = AllSuppliers.ThisSupplier.Email.ToString();
        txtSupplierTelephoneNumber.Text = AllSuppliers.ThisSupplier.TelephoneNumber.ToString();
        chkSupplierAvailability.Checked = AllSuppliers.ThisSupplier.Availability;
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
            // Capture the supplier id
            supplier.SupplierID = SupplierID;
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
            
            // If this is a new record i.e. SupplierID = -1 then add the data
            if (SupplierID == -1)
            {
                // Set the ThisSupplier property
                SupplierList.ThisSupplier = supplier;
                // Add the new record
                SupplierList.Add();
            }
            // Otherwise it must be an update
            else
            {
                // Find the record to update
                SupplierList.ThisSupplier.Find(SupplierID);
                // Set the ThisSupplier property
                SupplierList.ThisSupplier = supplier;
                // Update the record
                SupplierList.Update();
            }
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