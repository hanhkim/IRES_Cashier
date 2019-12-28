using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class UserModel
    {
        public UserModel(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        private string username;
        private string password;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Boolean isValidUsername()
        {

            return true;
        }
        public Boolean isValidPassword()
        {
            return true;
        }
    }
}
