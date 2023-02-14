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
    public partial class MainPageView : Form
    {
        LoginController loginController = new LoginController();
        public MainPageView()
        {
            InitializeComponent();
        }

        private void MainPageView_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = loginController.ReadAllUsers();
        }
    }
}
