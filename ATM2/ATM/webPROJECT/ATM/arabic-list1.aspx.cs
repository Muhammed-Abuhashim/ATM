using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ATM
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("select-language.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("arabic-list2.aspx");
        }
    }
}