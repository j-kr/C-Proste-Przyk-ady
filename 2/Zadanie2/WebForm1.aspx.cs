using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Zadanie2
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        private static double wynik=0;
        private static string znak;

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "7";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "8";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "9";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "4";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "5";
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "6";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "1";
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "2";
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "3";
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            var tab = TextBox1.Text.ToCharArray();
            int dl= TextBox1.Text.Length - 1;
            TextBox1.Text = "";

            for (int i=0;i<dl; i++)
            {
                TextBox1.Text = TextBox1.Text + tab[i].ToString();
            }
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text!=""){ wynik = Convert.ToDouble(TextBox1.Text); }
           
            TextBox2.Text = Convert.ToString(wynik);

            znak = "+";
            TextBox1.Text = "";
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "") { wynik = Convert.ToDouble(TextBox1.Text); }

            TextBox2.Text = Convert.ToString(wynik);

            znak = "-";
            TextBox1.Text = "";
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                if(wynik==0)
                {
                    wynik = Convert.ToDouble(TextBox1.Text);
                }
                else
                { 
                    wynik = wynik / Convert.ToDouble(TextBox1.Text);
                }
            }

            TextBox2.Text = Convert.ToString(wynik);

            znak = "/";
            TextBox1.Text = "";
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                TextBox1.Text = Convert.ToString(Convert.ToDouble(TextBox1.Text) - (Convert.ToDouble(TextBox1.Text) * 2));
            }
            else
            {
                if ((TextBox2.Text != "") && (TextBox1.Text == ""))
                {
                    TextBox2.Text = Convert.ToString(Convert.ToDouble(TextBox2.Text) - (Convert.ToDouble(TextBox2.Text) * 2));
                }
            }
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                if (znak == "+")
                {
                    wynik = wynik + Convert.ToDouble(TextBox1.Text);
                    TextBox2.Text = Convert.ToString(wynik);
                    TextBox1.Text = "";
                    znak = "";
                }
                if (znak == "-")
                {
                    wynik = wynik - Convert.ToDouble(TextBox1.Text);
                    TextBox2.Text = Convert.ToString(wynik);
                    TextBox1.Text = "";
                    znak = "";
                }
                if (znak == "*")
                {
                    wynik = wynik * Convert.ToDouble(TextBox1.Text);
                    TextBox2.Text = Convert.ToString(wynik);
                    TextBox1.Text = "";
                    znak = "";
                }
                if (znak == "/")
                {
                    wynik = wynik / Convert.ToDouble(TextBox1.Text);
                    TextBox2.Text = Convert.ToString(wynik);
                    TextBox1.Text = "";
                    znak = "";
                }
            }
            else
            {             
                TextBox2.Text = Convert.ToString(wynik);
                TextBox1.Text = "";
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            

            if (TextBox1.Text != "")
            {
                if (wynik == 0) { wynik = 1; }
                wynik = wynik * Convert.ToDouble(TextBox1.Text);
            }

            TextBox2.Text = Convert.ToString(wynik);

            znak = "*";
            TextBox1.Text = "";
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            wynik = 0;
            znak = "";
            TextBox1.Text = "";
            TextBox2.Text = "";
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                wynik = Math.Sqrt(Convert.ToDouble(TextBox1.Text));
            }
            else
            {
                if ((TextBox2.Text != "") && (TextBox1.Text == ""))
                {
                    wynik = Math.Sqrt(Convert.ToDouble(TextBox2.Text));
                }
            }
            
            
            TextBox2.Text = Convert.ToString(wynik);
            TextBox1.Text = "";
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            TextBox1.Text = TextBox1.Text + "0";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                wynik = (1 / Convert.ToDouble(TextBox1.Text));
            }
            else
            {
                if ((TextBox2.Text != "") && (TextBox1.Text == ""))
                {
                    wynik = (1 / Convert.ToDouble(TextBox2.Text) );
                }
            }


            TextBox2.Text = Convert.ToString(wynik);

            TextBox1.Text = "";
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "")
            {
                wynik =(Convert.ToDouble(TextBox1.Text) * Convert.ToDouble(TextBox1.Text));
            }
            else
            {
                if ((TextBox2.Text != "") && (TextBox1.Text == ""))
                {
                    wynik = (Convert.ToDouble(TextBox2.Text) * Convert.ToDouble(TextBox2.Text));
                }
            }

            TextBox2.Text = Convert.ToString(wynik);
            TextBox1.Text = ""; 
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
           

            if(TextBox1.Text=="")
            {
                TextBox1.Text = "0,";
            }else
            {
                char[] tab = TextBox1.Text.ToCharArray();

                for(int i=0; i<= TextBox1.Text.Length-1; i++)
                {
                    if(tab[i] == ',')
                    {
                        break;
                    }

                    else if(i == (TextBox1.Text.Length-1))
                    {
                        TextBox1.Text = TextBox1.Text + ",";
                        break;
                    }
                }
            }       
        }
    }
}