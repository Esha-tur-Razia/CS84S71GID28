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
                String name = textBox1.Text;
                sw.WriteLine(name);
            }
            using (StreamWriter sw = new StreamWriter(path2))
            {
                String ingredients = textBox2.Text;
                sw.WriteLine(ingredients);
            }
            using (StreamWriter sw = new StreamWriter(path3))
            {
                String quantity = textBox3.Text;
                sw.WriteLine(quantity);
            }
            using (StreamWriter sw = new StreamWriter(path4))
            {
                String description = textBox4.Text;
                sw.WriteLine(description);
            }

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String name = textBox1.Text;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            String ingredients = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            String quantity = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            String description = textBox4.Text;
        }
    }
}
