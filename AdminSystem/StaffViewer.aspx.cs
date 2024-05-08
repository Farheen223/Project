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
        //Create new instance of class
        clsStaff Staff = new clsStaff();
        // get the data from the session
        Staff = (clsStaff)Session["Staff"];
        //Display the Name from the entry
        Response.Write(Staff.Name);

    }
}