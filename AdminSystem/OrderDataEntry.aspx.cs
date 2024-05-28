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
        clsOrder AnOrder = new clsOrder();
        string PaymentSuccessful = chkPaymentSuccessful.Text;
        string TotalAmount = txtTotalAmount.Text;
        string Date = txtDate.Text;
        string Quantity = txtQuantity.Text;
        //string Active = chkActive.Text;
        string Error = "";
        Error = AnOrder.Valid(TotalAmount, Date, Quantity);
        if (Error == "")
        {
            AnOrder.PaymentSuccessful = chkPaymentSuccessful.Checked;
            AnOrder.TotalAmount = TotalAmount;
            AnOrder.Date = Convert.ToDateTime(Date);
            AnOrder.Quantity = Quantity;
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }
}

