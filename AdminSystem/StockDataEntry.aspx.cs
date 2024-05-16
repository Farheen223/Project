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
        //capture item name ?
        aStock.ItemName = txtItemName.Text;
        //capture item id
        aStock.ItemID = Convert.ToInt32(txtItemID.Text);
        //capture supplierid
        aStock.SupplierID = Convert.ToInt32(txtSupplierID.Text);
        //capture item price
        aStock.ItemPrice = Convert.ToInt32(txtItemPrice.Text);
        //capture item description
        aStock.Description = txtItemDescription.Text;
        //date of delivery
        aStock.DateAdded = Convert.ToDateTime(DateTime.Now);
        //instock
        aStock.inStock = chkInStock.Checked;


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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class 
        clsStock aStock = new clsStock();
        //create a variable to store the primary key
        Int32 ItemID;
        //create a variable to store the result of the find op
        Boolean Found = false;
        //get the primary key entered by user
        ItemID = Convert.ToInt32(txtItemID.Text);
        //find record
        Found = aStock.Find(ItemID);
        //if found
        if (Found == true) {

            //display the values of the properties in  the form
            txtItemDescription.Text = aStock.Description;
            txtItemID.Text = aStock.ItemID.ToString();
            txtItemName.Text = aStock.ItemName;
            txtItemPrice.Text = aStock.ItemPrice.ToString();
            txtSupplierID.Text = aStock.SupplierID.ToString();
            txtSupplyDate.Text = aStock.DateAdded.ToString();
            chkInStock.Checked = aStock.inStock;

        
        }
    }
}