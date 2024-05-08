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
        //create new instance of clsStock
        clsStock aStock = new clsStock();
        //get the data from session object
        aStock = (clsStock)Session["aStock"];
        //display stock no for this entry
        Response.Write(aStock.ItemName);
    }
}