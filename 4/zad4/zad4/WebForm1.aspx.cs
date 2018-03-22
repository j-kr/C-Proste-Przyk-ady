using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zad4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

       

        protected void Page_Load(object sender, EventArgs e)
        {

                Session["ch1"] = "false";
                Session["ch2"] = "false";
                Session["ch3"] = "false";
                Session["ch4"] = "false";
                Session["ch5"] = "false";

                Label1.Visible = true;
                Label2.Visible = true;
                RadioButtonList1.Visible = true;
                RadioButtonList2.Visible = true;
                Button2.Visible = true;

            Label3.Text = Session["towar1"].ToString();


                for (int a = 1; a <= int.Parse(Session["towar1"].ToString()); a++)
                {
                    DropDownList1.Items.Add(a.ToString());
                }

                for (int a = 1; a <= int.Parse(Session["towar2"].ToString()); a++)
                {
                    DropDownList2.Items.Add(a.ToString());
                }


                for (int a = 1; a <= int.Parse(Session["towar3"].ToString()); a++)
                {
                    DropDownList3.Items.Add(a.ToString());
                }


                for (int a = 1; a <= int.Parse(Session["towar4"].ToString()); a++)
                {
                    DropDownList4.Items.Add(a.ToString());
                }

                for (int a = 1; a <= int.Parse(Session["towar5"].ToString()); a++)
                {
                    DropDownList5.Items.Add(a.ToString());
                }
            
        }





        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                Session["ch1"] = "true";
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox2.Checked == true)
            {
                Session["ch2"] = "true";
            }
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked == true)
            {
                Session["ch3"] = "true";
            }
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked == true)
            {
                Session["ch4"] = "true";
            }
        }

        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox5.Checked == true)
            {
                Session["ch5"] = "true";
            }
        }

        protected void RadioButtonList1_wybierz(object sender, EventArgs e)
        {
            Session["dostawa"] = RadioButtonList1.SelectedValue;
        }

        protected void RadioButtonList2_wybierz(object sender, EventArgs e)
        {
            Session["zaplata"] = RadioButtonList2.SelectedValue;
        }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
            Session["towar1_akt"] = DropDownList1.Text;
            Session["towar2_akt"] = DropDownList2.Text;
            Session["towar3_akt"] = DropDownList3.Text;
            Session["towar4_akt"] = DropDownList4.Text;
            Session["towar5_akt"] = DropDownList5.Text;

            //Label1.Visible = true;
            //Label2.Visible = true;
            //RadioButtonList1.Visible = true;
            //RadioButtonList2.Visible = true;
            //Button2.Visible = true;
        }*/

        protected void Button2_Click(object sender, EventArgs e)
        {

            Session["towar1_akt"] = DropDownList1.Text;
            Session["towar2_akt"] = DropDownList2.Text;
            Session["towar3_akt"] = DropDownList3.Text;
            Session["towar4_akt"] = DropDownList4.Text;
            Session["towar5_akt"] = DropDownList5.Text;

            //Label1.Visible = true;
            //Label2.Visible = true;
            //RadioButtonList1.Visible = true;
            //RadioButtonList2.Visible = true;
            //Button2.Visible = true;

            Response.Redirect("~/WebForm2.aspx");
        }

        
    }
}