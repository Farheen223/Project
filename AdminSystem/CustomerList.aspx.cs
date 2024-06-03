using ClassLibrary;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    Int32 CustomerId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            DisplayCustomer();
            //if (CustomerId != -1)
           // {
           //     DisplayCustomer();
           // }
        }
        clsCustomerUser AnUser = new clsCustomerUser();
        AnUser = (clsCustomerUser)Session["AnUser"];
        Response.Write("Logged in as:" + AnUser.UserName);
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customer = new clsCustomerCollection();
        lstCustomerList.DataSource = Customer.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "CustomerName";
        lstCustomerList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomeId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please selct a record from the list to edit ";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        AnCustomer.ReportByEmail(txtFilter.Text);
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "Email";
        lstCustomerList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsCustomerCollection AnCustomer = new clsCustomerCollection();
        AnCustomer.ReportByEmail("");
        txtFilter.Text = "";
        lstCustomerList.DataSource = AnCustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "Email";
        lstCustomerList.DataBind();
    }

    protected void btnReturnToMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
