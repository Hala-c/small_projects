using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace userlogin
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }

    public class UserManager
    {
        private List<User> _users = new List<User>();

        public void Register(string username, string password)
        {
            if (_users.Exists(u => u.Username == username))
            {
                Console.WriteLine("Username already exists.");
                return;
            }

            _users.Add(new User(username, password));
            Console.WriteLine("Registration successful!");
        }

        public bool Login(string username, string password)
        {
            User user = _users.Find(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                Console.WriteLine("Login successful!");
                return true;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                return false;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            UserManager userManager = new UserManager();

            userManager.Register("user1", "password1");
            userManager.Register("user2", "password2");

            userManager.Login("user1", "password1");
            userManager.Login("user1", "wrong_password"); 
            userManager.Login("user2", "password2");
            userManager.Login("nonexistent_user", "any_password"); 
        }

    }

}
