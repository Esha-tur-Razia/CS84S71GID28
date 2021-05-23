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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void goToHomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new Homepage();
            form1.Show();
        }

        private void goToAboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form4 = new Form4();
            form4.Show();
        }
    }
}
