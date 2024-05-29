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

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Store -1 into the session object to indicate this is a new record
        Session["SupplierId"] = -1;
        // Redirect to the data entry page
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // Variable to store the primary key value of the record to be edited
        Int32 SupplierID;
        // If a record has been selected from the list
        if (lstSupplierList.SelectedIndex != -1)
        {
            // Get the primary key value of the record to edit
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            // Store the data in the session object
            Session["SupplierID"] = SupplierID;
            // Redirect to the edit page
            Response.Redirect("SupplierDataEntrey.aspx");
        }
        else // If no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;
        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupllierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();
        AllSuppliers.ReportByCity(txtCity.Text);
        lstSupplierList.DataSource = AllSuppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "City";
        lstSupplierList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();
        AllSuppliers.ReportByCity("");
        txtCity.Text = "";
        lstSupplierList.DataSource = AllSuppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "City";
        lstSupplierList.DataBind();

    }
}