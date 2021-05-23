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
    public partial class Form7 : Form
    {
        public Form7()
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
    }
}
