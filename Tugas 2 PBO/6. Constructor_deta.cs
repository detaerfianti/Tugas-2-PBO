using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Program
    {
        public class User
        {
            public string username;
            public string password;

            public User(string username, string password)
            {
                this.username = username;
                this.password = password;
            }

        }
        public static void Main(string[] args)
        {
            User petani = new User("Deta Eka Erfianti", "21051214005");
            Console.WriteLine("Username: " + petani.username);
            Console.WriteLine("Password: " + petani.password);
            Console.ReadLine();
        }
    }
}