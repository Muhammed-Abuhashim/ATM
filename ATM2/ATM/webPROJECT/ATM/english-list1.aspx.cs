using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ATM
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("select-language.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {

        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("english-list2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}