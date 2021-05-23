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


        
        
        
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = new Form3();
            form3.Show();
        }




        

        private void button3_Click(object sender, EventArgs e)
        {
            admin_login a = new admin_login();
            a.Show();

        }
    
}
