using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm3.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("WebForm4.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("english-list1.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("arabic-list1.aspx");
        }
    }
}