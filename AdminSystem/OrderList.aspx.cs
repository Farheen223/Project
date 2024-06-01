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
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrder();
            }
            
        }
    }
    void DisplayOrder()
    {

        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.ThisOrder.Find(OrderId);

        txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString;
        chkPaymentSuccessful.Checked = OrderBook.ThisOrder.PaymentSuccessful.ToString;
        txtStaffId.Text = OrderBook.ThisOrder.StaffId.ToString;
        txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString;
        txtStockId.Text = OrderBook.ThisOrder.StockId.ToString;
        txtQuantity.Text = OrderBook.ThisOrder.Quantity.ToString;
        txtDate.Text = OrderBook.ThisOrder.Date.ToString;
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderId;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }
}