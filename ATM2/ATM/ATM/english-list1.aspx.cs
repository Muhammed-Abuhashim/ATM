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
        public string FilePath = "C:\\Users\\Muhammed Abuhashim\\Desktop\\projects\\ATM2\\ATM\\ATM\\Users\\users.txt";
        public List<Users> ReadUsersFile()
        {
            List<Users> ResultArr = new List<Users>();
            string[] lines = File.ReadLines(FilePath).ToArray();
            for (int i = 0; i < lines.Length; i++)
            {

                string[] UsersBalance = lines[i].Split(',');
                string Username = UsersBalance[0];
                double Balance = Convert.ToDouble(UsersBalance[1]);
                Users User = new Users(Username, Balance);
                ResultArr.Add(User);
                Username = "";
                Balance = 0;
            }

            return ResultArr;
        }

        public string ConvertUsersListToString(List<Users> Users)
        {
            string Res = "";
            for (int i = 0; i < Users.Count; i++)
            {
                Res = Res + Users[i].Username + "," + Users[i].Balance.ToString() + Environment.NewLine;
            }
            return Res;
        }

        public string Withdraw(string Username, double Amount)
        {
            List<Users> AllUsers = ReadUsersFile();
            List<string> FileContent = new List<string>();
            for (int i = 0; i < AllUsers.Count; i++)
            {
                if (AllUsers[i].Username == Username)
                {
                    if (Amount > AllUsers[i].Balance)
                    {
                        Server.Transfer("Error.aspx");
                       // return "the withdrwal amount is greater than your balance";

                    }
                    else
                    {
                        AllUsers[i].Balance = AllUsers[i].Balance - Amount;
                        File.Delete(FilePath);

                        using (StreamWriter sw = File.CreateText(FilePath))
                        {
                            string FileContentString = ConvertUsersListToString(AllUsers);
                            sw.Write(FileContentString);
                        }

                        return "SUCCESS";
                    }
                }
            }
            return "";
        }

        public double Deposite(string Username, double Amount)
        {
            return 0;
        }

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
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 1000);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            // To Move From Site To Another
            Server.Transfer("english-list2.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 50);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 100);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 300);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 200);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 500);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 2000);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 3000);
            Server.Transfer("ask_another_thing.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            //var AllUsers = ReadUsersFile();
            Withdraw("Eissa", 5000);
            Server.Transfer("ask_another_thing.aspx");
        }
    }
}