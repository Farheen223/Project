using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
    }

    protected void btnYesDelete_Click(object sender, EventArgs e)
    {
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderId);
        OrderBook.Delete();
        Response.Redirect("OrderList.aspx");
    }

    protected void btnNoDelete_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}