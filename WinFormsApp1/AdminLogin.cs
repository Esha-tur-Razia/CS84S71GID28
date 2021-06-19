using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            mainpage page = new mainpage();
            page.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adimname_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (!nameText.Text.Equals(null) && !nameText.Text.Equals("") && !passText.Text.Equals(null) && !passText.Text.Equals(""))
            {
                if(nameText.Text.Equals("Admin") && passText.Text.Equals("Admin"))
                {
                    AdminMenu menu = new AdminMenu();

                    menu.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("Credentials not Found !");
            }
            else
                MessageBox.Show("Fields are empty");
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
