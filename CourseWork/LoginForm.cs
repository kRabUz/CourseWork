using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            PasswordBox.UseSystemPasswordChar = true;
        }

        private void Authorization_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(UserBox.Text) == "Admin" && Convert.ToString(PasswordBox.Text) == "123456")
            {
                this.Hide();
                AdminMenu menu = new AdminMenu();
                menu.Show();
            }
            else if (Convert.ToString(UserBox.Text) != "Admin") MessageBox.Show("Неправильний логін.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Convert.ToString(PasswordBox.Text) != "123456") MessageBox.Show("Неправильний пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
