using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    public partial class user_search : Form
    {
        int index = -1;
        public user_search()
        {
            InitializeComponent();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            String userSearch = search.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Events eve = new Events();
            eve.Show();
            this.Hide();
        }
        String path = Environment.CurrentDirectory + "/" + "Recipe.txt";

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


            String userSearch = search.Text;
            if (!userSearch.Equals(null))
            {
                for (int i = 0; i < Driver.GetInstance().GetRecipe().Count; i++)
                {
                    if (userSearch.Equals(Driver.GetInstance().GetRecipe()[i].GetName()))
                    {
                        index = i;
                        break;
                    }
                    else
                    {
                        index = -1;
                    }
                }
                if (index == -1)
                {
                    MessageBox.Show("Recipe not found!!");
                }
                else
                {
                    
                    richTextBox1.Text = Driver.GetInstance().GetRecipe()[index].GetDescription();
                }
            }
            else
            {
                MessageBox.Show("Field is empty");
            }
        }
    }
}
