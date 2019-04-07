using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           
            string b = Label1.Text;
            string c = TextBox1.Text;
            Label1.Text = string.Format("{0}" + "+" + "{1}", Initial.a, Initial.b);
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Format("{0}", Initial.SumInf()))
                Label2.Text = "Правыльно"; 
            else
            {
                Label2.Text = "Неправыльно";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

    }
}
