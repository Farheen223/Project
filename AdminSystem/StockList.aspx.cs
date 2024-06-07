using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    Int32 ItemID;
    protected void Page_Load(object sender, EventArgs e)
    {
        ItemID = Convert.ToInt32(Session["ItemID"]);
        if (IsPostBack == false)
        {
            
                DisplayStocks();
            
        }
        clsStockUser anUser = new clsStockUser();
        anUser = (clsStockUser)Session["anUser"];
        Response.Write("Logged in as: " + anUser.UserName);
    }

    void DisplayStocks()
    {
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to lost of addresses in the collection
        lstStockList.DataSource = Stock.StockList;
        //set name of the primary key
        lstStockList.DataValueField = "ItemID";
        //set the data field to display
        lstStockList.DataTextField = "ItemPrice";
        //bind data to list
        lstStockList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the sessiomn object to indicaTE THisa is a new record
        Session["ItemID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void lblEdit_Click(object sender, EventArgs e)
    {
        //variablen to store primary key value
        Int32 ItemID;
        if (lstStockList.SelectedIndex != 1)
        {
            ItemID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ItemID"] = ItemID;
            Response.Redirect("StockDataEntry.aspx");
        }

        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ItemID;
        if (lstStockList.SelectedIndex != 1)
        {
            ItemID = Convert.ToInt32(lstStockList.SelectedValue);
            Session["ItemID"] = ItemID;
            Response.Redirect("StockConfirmDelete.aspx");
        }

        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
            
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection aStock = new clsStockCollection();
        aStock.ReportByItemName(txtFilter.Text);
        lstStockList.DataSource = aStock.StockList;
        lstStockList.DataValueField = "ItemID";
        lstStockList.DataTextField = "ItemName";
        lstStockList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsStockCollection aStock = new clsStockCollection();
        aStock.ReportByItemName("");
        lstStockList.DataSource = aStock.StockList;
        lstStockList.DataValueField = "ItemID";
        lstStockList.DataTextField = "ItemName";
        lstStockList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}