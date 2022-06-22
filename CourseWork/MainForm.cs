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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void UserWatch_Click(object sender, EventArgs e)
        {
            this.Hide();
            WatchUser watchuser = new WatchUser();
            watchuser.Show();
        }

        private void LoginAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MagicButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MagicForm magic = new MagicForm();
            magic.Show();
        }
    }
}