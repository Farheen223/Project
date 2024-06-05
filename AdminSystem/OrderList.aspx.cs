using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["OrderId"]);
        if (IsPostBack == false)
        {
            if (OrderId != -1)
            {
                DisplayOrders();
            }
            clsOrderUser AnUser = new clsOrderUser();
            AnUser = (clsOrderUser)Session["AnUser"];
            Response.Write("Logged in as: " + AnUser.UserName);
        }
    }
    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "Quantity";
        lstOrderList.DataBind();
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

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        AnOrder.ReportByQuantity(txtFilter.Text);
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "Quantity";
        lstOrderList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AnOrder = new clsOrderCollection();
        AnOrder.ReportByQuantity("");
        txtFilter.Text = "";
        lstOrderList.DataSource = AnOrder.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "Quantity";
        lstOrderList.DataBind();
    }
} 