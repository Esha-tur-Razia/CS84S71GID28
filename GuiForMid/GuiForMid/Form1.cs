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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }













        private void button4_Click(object sender, EventArgs e)
        {
            admin_login a = new admin_login();
            a.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form6 = new Form6();
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var form7 = new Form7();
            form7.Show();
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

        
        
        
        
        
        
        
        
        
        
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            admin_login a = new admin_login();
            a.Show();

        }
    }
}
