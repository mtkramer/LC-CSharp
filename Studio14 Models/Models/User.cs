using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studio14_Models.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Joined { get; }

        public User(string username, string email, string password)
        {
            Username = username;
            Email = email;
            Password = password;
            Joined = DateTime.Now.ToString();
        }
        public User() { Joined = DateTime.Now.ToString(); }

    }
}