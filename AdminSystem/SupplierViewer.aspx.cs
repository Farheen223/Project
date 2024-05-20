using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of clsSupplier
        clsSupplier supplier = new clsSupplier();
        // get the data from the session object
        supplier = (clsSupplier)Session["supplier"];
        // display the supplier data
        Response.Write(supplier.SupplierID + "\n"
                      +supplier.Name + "\n"
                      +supplier.City + "\n"
                      +supplier.Email + "\n"
                      +supplier.TelephoneNumber + "\n"
                      +supplier.AddDate + "\n"
                      +supplier.Availability + "\n");
    }
}