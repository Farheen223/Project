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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void txtSupplyDate_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //crete a nrew instance of clsStock
        clsStock aStock = new clsStock();
        //capture stock no ?
        aStock.ItemName = txtItemName.Text;
        //store in session object
        Session["aStock"] = aStock;
        //navigate to the view page
        Response.Redirect("StockViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {

    }

    protected void txtSupplierID_TextChanged(object sender, EventArgs e)
    {

    }
}