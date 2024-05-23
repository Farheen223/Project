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
        // If this is the first time the page is displayed
        if (IsPostBack == false)
        {
            // Update the list box
            DisplaySuppliers();
        }

    }

    void DisplaySuppliers()
    {
        // Create an instance of the supplier collection
        clsSupplierCollection Suppliers = new clsSupplierCollection();
        // Set the data source to list of suppliers in the collection
        lstSupplierList.DataSource = Suppliers.SupplierList;
        // Set the name of the primary key
        lstSupplierList.DataValueField = "SupplierID";
        // Set the data field to display
        lstSupplierList.DataTextField = "Name";
        // Bind the data to the list
        lstSupplierList.DataBind();
    }
}