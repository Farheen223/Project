using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 ItemID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the id of the item to be processed
        ItemID = Convert.ToInt32(Session["ItemID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (ItemID != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //crete a nrew instance of clsStock
        clsStock aStock = new clsStock();
        //capture item name ?
        string ItemName = txtItemName.Text;
        //capture item id
        int ItemID = Convert.ToInt32(txtItemID.Text);
        //capture supplierid
        int SupplierID = Convert.ToInt32(txtSupplierID.Text);
        //capture item price
        int ItemPrice = Convert.ToInt32(txtItemPrice.Text);
        //capture item description
        string Description = txtItemDescription.Text;
        //date of delivery
        string DateAdded = txtDateAdded.Text;
        //instock
        string inStock = chkInStock.Text;
        //variable to store error messages
        string Error = "";
        //validate the data
        Error = aStock.Valid(SupplierID, ItemName, ItemPrice, Description, DateAdded);
        if (Error == "")
        {
            //capture itemname
            aStock.ItemName = ItemName;
            //capture itemID

            
            aStock.ItemID = ItemID;
            aStock.SupplierID = SupplierID;
            aStock.ItemPrice = ItemPrice;
            aStock.Description = Description;
            aStock.DateAdded = Convert.ToDateTime(DateAdded);

            //capture instock
            aStock.inStock = chkInStock.Checked;

            //creater a new instance of stockcollection
            clsStockCollection StockList = new clsStockCollection();

            if (ItemID == -1)
            {
                StockList.ThisStock = aStock;

            }

            else
            {
                StockList.ThisStock.Find(ItemID);
                StockList.ThisStock = aStock;
                StockList.Update();
            }

            //redirect to the list page
            Response.Redirect("StockList.aspx");

        }

        else
        {
            //display error message
            lblError.Text = Error;
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockList.aspx");
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
            txtDateAdded.Text = aStock.DateAdded.ToString();
            chkInStock.Checked = aStock.inStock;

        
        }
    }

    void DisplayStock()
    {
        clsStockCollection StockBook = new clsStockCollection();
        StockBook.ThisStock.Find(ItemID);
        txtItemID.Text = StockBook.ThisStock.ItemID.ToString();
        txtItemName.Text = StockBook.ThisStock.ItemName.ToString();
        txtItemPrice.Text = StockBook.ThisStock.ItemPrice.ToString();
        txtItemDescription.Text = StockBook.ThisStock.Description.ToString();
        txtDateAdded.Text = StockBook.ThisStock.DateAdded.ToString();
        txtSupplierID.Text = StockBook.ThisStock.SupplierID.ToString();
        chkInStock.Checked = StockBook.ThisStock.inStock;
    }



    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}