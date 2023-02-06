using LoginForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controller
{
    internal class LoginController
    {
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>()
            {
                new User("user1", "123"),
                new User("user2", "321")
            };
            return users;
        }
    }
}
