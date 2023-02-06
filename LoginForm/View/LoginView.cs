using LoginForm.Controller;
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
    public partial class LoginView : Form
    {
        LoginController loginController = new LoginController();
        public LoginView()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var users = loginController.GetAllUsers();
            bool correctUsername = false;
            bool correctPassword = false;
            foreach (var item in users)
            {
                if (username == item.Username)
                {
                    correctUsername = true;
                    if (password == item.Password)
                    {
                        correctPassword = true;
                    }
                }
            }

            if (correctUsername)
            {
                if (correctPassword)
                {
                    MainPageView mainpage = new MainPageView();
                    this.Hide();
                    mainpage.Show();
                }
                else
                {
                    MessageBox.Show("Wrong Password");
                }
            }
            else
            {
                MessageBox.Show("Wrong username");
            }
        }
    }
}
