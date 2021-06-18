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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String recipe = textBox1.Text;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
