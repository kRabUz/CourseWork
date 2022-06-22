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
    public partial class MagicForm : Form
    {
        public MagicForm()
        {
            InitializeComponent();
            WMP.URL = @"C:\Education\ОП\CourseWork\CourseWork\video.mp4";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
            WMP.URL = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
