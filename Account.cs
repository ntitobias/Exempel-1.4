using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exempel_1._4
{
    class Account
    {
        private string username;
        private string password;

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username
        {
            get { return username; }
        }

        public string Password
        {
            get { return password; }
        }

        public static bool CheckPassword(string password)
        {
            if (password.Length >= 8) 
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
