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
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }

    }

    void DisplayStock()
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
}