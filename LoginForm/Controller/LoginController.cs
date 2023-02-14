using LoginForm.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginForm.Controller
{
    internal class LoginController
    {
        public void CreateUser(User user)
        {
            using (NavigationDBEntities db = new NavigationDBEntities())
            {
                var lastUser = db.User.ToList().LastOrDefault();
                if (lastUser == null)
                {
                    lastUser = new User();
                    lastUser.Id = 0;
                }
                user.Id = lastUser.Id + 1;
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public List<User> ReadAllUsers()
        {
            using (NavigationDBEntities db = new NavigationDBEntities())
            {
                return db.User.ToList();
            }
        }
    }
}
