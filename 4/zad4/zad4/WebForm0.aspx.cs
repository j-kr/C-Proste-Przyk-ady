using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zad4
{
    public partial class WebForm0 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["towar1"] = 5;
            Session["towar2"] = 2;
            Session["towar3"] = 5;
            Session["towar4"] = 10;
            Session["towar5"] = 8;

            Response.Redirect("~/WebForm1.aspx");

        }
    }
}