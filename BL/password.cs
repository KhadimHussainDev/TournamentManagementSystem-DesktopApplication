using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
namespace BL
{
    internal class logInfo
    {
        private string username;
        private string password;
        public logInfo() { }
        public logInfo(string username,string password) { this.username = username; this.password = password; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public bool athentication()
        {
            if (Username == passwordDL.Log.Username && Password == passwordDL.Log.Password)
            {
                return true;
            }
            return false;
        }
    }
}
