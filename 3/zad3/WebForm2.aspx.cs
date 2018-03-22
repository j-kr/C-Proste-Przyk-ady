using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace zad3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Random rand = new Random();
        List<int> liczby = new List<int>();
        HashSet<int> liczby_bez = new HashSet<int>();

        int random = 0;

        protected void Page_Load(object sender, EventArgs e)
        {


            if (int.Parse(Session["gorna_granica"].ToString()) - int.Parse(Session["dolna_granica"].ToString()) <= 100)
            {
                Label1.Text = "Rożnica w zakresie musi wynosić minimum 100";
            }


            else
            {

                for (int k = 0; k < int.Parse(Session["ile"].ToString()); k++)
                {
                    random = (rand.Next(int.Parse(Session["dolna_granica"].ToString()), int.Parse(Session["gorna_granica"].ToString())));
                    liczby.Add(random);
                    liczby_bez.Add(random);
                }

                Label1.Text = "<b>Wylosowane liczby:</b> ";
                foreach (int i in liczby)
                {
                    Label1.Text = Label1.Text + " " + i;
                }


                Label2.Text = "<b>Wylosowane liczby bez powtórzeń:</b> ";
                foreach (int z in liczby_bez)
                {
                    Label2.Text = Label2.Text + " " + z;
                }


                Label3.Text = "<b>Wylosowane powtórzenia:</b> ";

                var duplicates = liczby.GroupBy(s => s).SelectMany(grp => grp.Skip(1));
                duplicates = duplicates.Distinct();

                foreach (int b in duplicates)
                {
                    Label3.Text = Label3.Text + " " + b;
                }

            }
        }

    }
}