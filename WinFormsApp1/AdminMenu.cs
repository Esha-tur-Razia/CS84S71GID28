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
    }
}
