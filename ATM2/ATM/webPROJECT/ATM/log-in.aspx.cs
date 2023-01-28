using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ATM
{
    public partial class WebForm10 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_TextChanged(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            // validation of UserName and Password  
            if (TextBox1.Text == "")
            {
                Label4.Text = "Enter UserName";
            }
            else if (TextBox2.Text == "")
            {
                Label3.Text = "Enter Password";
            }
            else
            {
                if ((TextBox1.Text == "karma" && TextBox2.Text == "0000" ) || (TextBox1.Text == "noha" && TextBox2.Text == "1111") || (TextBox1.Text == "eissa" && TextBox2.Text == "3333") || (TextBox1.Text == "abuhashim" && TextBox2.Text == "4444"))
                {
                    // To Move From Site To Another
                    Server.Transfer("select-language.aspx");
                }
                else
                {
                    Label5.Text = "Invalid Name or Password";
                }
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Clear UserName and Password in case of incorrect
            TextBox1.Text = string.Empty;
            TextBox2.Text = string.Empty;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("message-cancel-process.aspx");
        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("message-forget-password.aspx");
        }
    }
}