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
    public partial class admin_menu : Form
    {
        public admin_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_recipie b = new add_recipie();
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete_recipie c = new delete_recipie();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_recipie d = new edit_recipie();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search_recipie f = new search_recipie();
            f.Show();
        }

        private void admin_menu_Load(object sender, EventArgs e)
        {

        }
    }
}
