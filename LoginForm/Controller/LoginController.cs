using LoginForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controller
{
    internal static class LoginController
    {
        static List<User> users = new List<User>()
        {
            new User("user1", "123"),
            new User("user2", "321")
        };

        public static void AddUser(User user)
        {
            if (user.Username != string.Empty || user != null)
            {
                users.Add(user);
            }
        }

        public static List<User> GetAllUsers()
        {
            return users;
        }
    }
}
