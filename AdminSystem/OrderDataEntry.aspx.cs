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

    protected void txtPaymentSuccessful_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //capture the total amount
        AnOrder.OrderId = txtOrderId.Text;
        //store the total amount in the session object
        Session["AnOrder"] = AnOrder;
        //navigate to the view page
        Response.Redirect("OrderViewer.aspx");
    }
}
 /*   protected void btnFind_Click(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(txtOrderId.Text);
        Found = AnOrder.Find(OrderId);

        if (Found == true)
        {
            txtCustomerId.Text = AnOrder.CustomerId;
            txtTotalAmount.Text = AnOrder.TotalAmount;
            txtPaymentSuccessful.Text = AnOrder.PaymentSuccesful.ToString;
            txtStaffId.Text = AnOrder.StaffId;
            txtCustomerId.Text = AnOrder.CustomerId.ToString;
            txtDate.Text = AnOrder.Date.ToString;
            txtQuantity.Text = AnOrder.Quantity;
            txtStockId.Text = AnOrder.StockId.ToString;
            chkActive.Checked = AnOrder.Active;
        }

    }
}  */


    


