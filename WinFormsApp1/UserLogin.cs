using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            mainpage page = new mainpage();
            page.Show();
            this.Hide();
        }

        private void login_Click(object sender, EventArgs e)
        {
            user_search us = new user_search();
            us.Show();
            this.Hide();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }
    }
}
