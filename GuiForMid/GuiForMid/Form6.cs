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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var form1 = new Homepage();
            form1.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsFilled(UserName.Text))
            {
                if (IsFilled(pass.Text))
                {
                    var form8 = new Form8();
                    form8.Show();
                }
            }
            else
            {
                MessageBox.Show("Please fill in the requirement");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String password = pass.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.Save();
            }
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            String Name = UserName.Text;
 
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
