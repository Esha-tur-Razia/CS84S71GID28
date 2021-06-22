using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminLogin ad = new AdminLogin();
            ad.Show();
            this.Hide();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UserLogin u = new UserLogin();
            u.Show();
            this.Hide();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutUs ab = new AboutUs();
            ab.Show();
            this.Hide();
        }
    }
}
