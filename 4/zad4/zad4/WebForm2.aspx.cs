using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zad4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void wyswietl()
        {
            if (Session["ch1"].ToString() == "true")
                Label1.Text = Label1.Text + "Towar 1     sztuk:" + Session["towar1_akt"].ToString() + "<br/>";

            if (Session["ch2"].ToString() == "true")
                Label1.Text = Label1.Text + "Towar 2     sztuk:" + Session["towar2_akt"].ToString() + "<br/>";

            if (Session["ch3"].ToString() == "true")
                Label1.Text = Label1.Text + "Towar 3     sztuk:" + Session["towar3_akt"].ToString() + "<br/>";

            if (Session["ch4"].ToString() == "true")
                Label1.Text = Label1.Text + "Towar 4     sztuk:" + Session["towar4_akt"].ToString() + "<br/>";

            if (Session["ch5"].ToString() == "true")
                Label1.Text = Label1.Text + "Towar 5     sztuk:" + Session["towar5_akt"].ToString() + "<br/>";


            if (Session["dostawa"].ToString() == "1")
            {
                Label2.Text = "Odbiór osobisty";
            }

            if (Session["dostawa"].ToString() == "2")
            {
                Label2.Text = "Dostawa kurierem";
            }

            if (Session["dostawa"].ToString() == "3")
            {
                Label2.Text = "Odbiór w paczkomacie";
            }


            if (Session["zaplata"].ToString() == "1")
            {
                Label3.Text = "Przelew bankowy";
            }

            if (Session["zaplata"].ToString() == "2")
            {
                Label3.Text = "Płatność gotówką";
            }

            if (Session["zaplata"].ToString() == "3")
            {
                Label3.Text = "Płatność kartą";
            }


            int x1 = int.Parse(Session["towar1"].ToString());
            int x2 = int.Parse(Session["towar2"].ToString());
            int x3 = int.Parse(Session["towar3"].ToString());
            int x4 = int.Parse(Session["towar4"].ToString());
            int x5 = int.Parse(Session["towar5"].ToString());

            if (Session["ch1"].ToString() == "true")
            {
                x1 = (int.Parse(Session["towar1"].ToString()) - int.Parse(Session["towar1_akt"].ToString()));
                Session["towar1"] = x1;
            }

            if (Session["ch2"].ToString() == "true")
            {
                x2 = (int.Parse(Session["towar2"].ToString()) - int.Parse(Session["towar2_akt"].ToString()));
                Session["towar2"] = x2;
            }

            if (Session["ch3"].ToString() == "true")
            {
                x3 = (int.Parse(Session["towar3"].ToString()) - int.Parse(Session["towar3_akt"].ToString()));
                Session["towar3"] = x3;
            }

            if (Session["ch4"].ToString() == "true")
            {
                x4 = (int.Parse(Session["towar4"].ToString()) - int.Parse(Session["towar4_akt"].ToString()));
                Session["towar4"] = x4;
            }

            if (Session["ch5"].ToString() == "true")
            {
                x5 = (int.Parse(Session["towar5"].ToString()) - int.Parse(Session["towar5_akt"].ToString()));
                Session["towar5"] = x5;
            }

            Label4.Text = Label4.Text + "Towar 1     sztuk:" + x1 + "<br/>";
            Label4.Text = Label4.Text + "Towar 2     sztuk:" + x2 + "<br/>";
            Label4.Text = Label4.Text + "Towar 3     sztuk:" + x3 + "<br/>";
            Label4.Text = Label4.Text + "Towar 4     sztuk:" + x4 + "<br/>";
            Label4.Text = Label4.Text + "Towar 5     sztuk:" + x5 + "<br/>";
        }
            

        protected void Button1_Click(object sender, EventArgs e)
        {

            
        Response.Redirect("~/WebForm1.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            wyswietl();
            Session["zaplata"] = 0;
            Session["dostawa"] = 0;
        }
    }
}