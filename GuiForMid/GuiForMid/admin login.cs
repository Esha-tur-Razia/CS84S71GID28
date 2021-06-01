using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiForMid
{
    public partial class admin_login : Form
    {
        public admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFilled(textBox1.Text))
            {
                if (IsFilled(textBox2.Text))
                {
                    admin_menu b = new admin_menu();
                    b.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill in the requirement");
            }

        }
        private bool IsFilled(string s)
        {
            if (s != "")
            { return true; }
            else
            { return false; }
        }
    }
}
