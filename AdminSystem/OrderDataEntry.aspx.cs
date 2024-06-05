using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
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
            txtOrderId.Text = OrderBook.ThisOrder.OrderId.ToString();
            chkPaymentSuccessful.Checked = OrderBook.ThisOrder.PaymentSuccessful;
            txtStaffId.Text = OrderBook.ThisOrder.StaffId.ToString();
            txtCustomerId.Text = OrderBook.ThisOrder.CustomerId.ToString();
            txtStockId.Text = OrderBook.ThisOrder.StockId.ToString();
            txtQuantity.Text = OrderBook.ThisOrder.Quantity.ToString();
            txtDate.Text = OrderBook.ThisOrder.Date.ToString();
        }

        protected void txtPaymentSuccessful_TextChanged(object sender, EventArgs e)
        {

        }

    protected void btnOK_Click1(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string PaymentSuccessful = chkPaymentSuccessful.Text;
        string TotalAmount = txtTotalAmount.Text;
        string Date = txtDate.Text;
        string Quantity = txtQuantity.Text;
        string CustomerId = txtCustomerId.Text;
        string StockId = txtStockId.Text;
        string StaffId = txtStaffId.Text;
        string Error = "";
        Error = AnOrder.Valid(TotalAmount, Date, Quantity, CustomerId, StockId, StaffId);
        if (Error == "")
        {
            AnOrder.OrderId = OrderId;
            AnOrder.PaymentSuccessful = chkPaymentSuccessful.Checked;
            AnOrder.TotalAmount = TotalAmount;
            AnOrder.Date = Convert.ToDateTime(Date);
            AnOrder.Quantity = Quantity;
            AnOrder.CustomerId = Convert.ToInt32(CustomerId);
            AnOrder.StockId = Convert.ToInt32(StockId);
            AnOrder.StaffId = Convert.ToInt32(StaffId);
            clsOrderCollection OrderList = new clsOrderCollection();
            OrderList.ThisOrder = AnOrder;
            OrderList.Add();
            if (OrderId == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderId);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnReturnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
} 

