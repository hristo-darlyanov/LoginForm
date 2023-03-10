using LoginForm.Controller;
using LoginForm.Model;
using System;
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

        private void RefreshData()
        {
            dgvUsers.DataSource = loginController.ReadAllUsers();
        }

        private void MainPageView_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var user = new User(txtUsername.Text, txtPassword.Text);
            loginController.CreateUser(user);
            RefreshData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            User user = new User();
            user.Username = txtUsername.Text;
            user.Password = txtPassword.Text;
            loginController.UpdateUser(id, user);
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            loginController.DeleteUser(id);
            RefreshData();
        }
    }
}
