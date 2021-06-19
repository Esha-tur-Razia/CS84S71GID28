using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            AddRecipe rec = new AddRecipe();
            rec.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logging out successfully!!");
            mainpage m = new mainpage();
            m.Show();
            this.Hide();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deleterecipe del = new Deleterecipe();
            del.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editrecipe edit = new Editrecipe();
            edit.Show();
            this.Hide();
        }
    }
}
