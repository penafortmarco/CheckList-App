using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList
{
    public class UserData
    {
        private  string _username, _password;

        public UserData()
        {
            this._username = "admin";
            this._password = "123456789";
        }

        public string Username { get => _username; }
        public string Password { get => _password; }
    }
}
