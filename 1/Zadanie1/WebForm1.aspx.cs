using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Session["imie"] = TextBox1.Text;
            Session["nazwisko"] = TextBox2.Text;
            Session["wiek"] = TextBox3.Text;
            Session["pesel"] = TextBox4.Text;
            Session["kraj"] = TextBox5.Text;
            Session["miasto"] = TextBox6.Text;
            Session["ulica"] = TextBox7.Text;
            Session["dom"] = TextBox8.Text;


            Session["rozmiar"] = DropDownList1.SelectedValue;
            Session["kroj"] = DropDownList2.SelectedValue;
            Session["tlo"] = DropDownList3.SelectedValue;
  

            if (CheckBoxList1.Items[0].Selected == true) { Session["pogrobienie"] = CheckBoxList1.Items[0].Value; } else { Session["pogrobienie"] = "none"; }
            if (CheckBoxList1.Items[1].Selected == true) { Session["podkresl"] = CheckBoxList1.Items[1].Value; } else { Session["podkresl"] = "none"; }
            if (CheckBoxList1.Items[2].Selected == true) { Session["pochyl"] = CheckBoxList1.Items[2].Value; } else { Session["pochyl"] = "none"; }

            Response.Redirect("/WebForm2.aspx");
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}