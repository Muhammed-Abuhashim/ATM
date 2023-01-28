using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATM
{
    public class Users
    {
        public string Username { get; set; }
        public double Balance { get; set; }

        public Users(string _Username, double _Balance)
        {
            Username = _Username;
            Balance = _Balance;
        }
    }
}