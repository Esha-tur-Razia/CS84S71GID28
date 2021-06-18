using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiForMid
{
    public partial class add_recipie : Form
    {

        String path = Environment.CurrentDirectory + "/" + "Name.txt";
        String path2 = Environment.CurrentDirectory + "/" + "Ingredient.txt";
        String path3 = Environment.CurrentDirectory + "/" + "Quantity.txt";
        String path4 = Environment.CurrentDirectory + "/" + "Recipe.txt";
        public add_recipie()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine();
            }
            using (StreamWriter sw = new StreamWriter(path2))
            {
                sw.WriteLine();
            }
            using (StreamWriter sw = new StreamWriter(path3))
            {
                sw.WriteLine();
            }
            using (StreamWriter sw = new StreamWriter(path4))
            {
                sw.WriteLine();
            }

        }
    }
}
