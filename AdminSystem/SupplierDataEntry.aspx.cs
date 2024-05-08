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
        supplier.Name = txtSupplierName.Text;
        // capture the city
        supplier.City = txtSupplierCity.Text;
        // capture the email
        supplier.Email = txtSupplierEmail.Text;
        // capture the telephone number
        supplier.TelephoneNumber = txtSupplierTelephoneNumber.Text;
        // capture availability check box
        supplier.Availability = chkSupplierAvailability.Checked;
        // capture add date
        supplier.AddDate = Convert.ToDateTime(DateTime.Now);
        // store the supplier info in the session object
        Session["supplier"] = supplier;
        // navigate to the supplier view page
        Response.Redirect("SupplierViewer.aspx");
    }
}