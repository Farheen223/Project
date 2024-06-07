using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;


public partial class _1_List : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsStockUser anUser = new clsStockUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);

        Found = anUser.FindUser(UserName, Password);

        Session["anUser"] = anUser;

        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a username";

        }

        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a password ";

        }

        else if (Found == true)
        {
            Response.Redirect("StockList.aspx");
        }

        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect, please try again";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}