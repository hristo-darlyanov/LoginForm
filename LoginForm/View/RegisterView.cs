using LoginForm.Controller;
using LoginForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm.View
{
    public partial class RegisterView : Form
    {
        LoginController loginController = new LoginController();
        public RegisterView()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            loginController.CreateUser(new User(username, password));
            MainPageView mainPageView = new MainPageView();
            this.Hide();
            mainPageView.Show();
        }
    }
}
