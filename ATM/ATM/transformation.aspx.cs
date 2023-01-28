using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class transformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                Server.Transfer("ask_another_thing.aspx");
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}