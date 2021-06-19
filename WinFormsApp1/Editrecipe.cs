using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Editrecipe : Form
    {
        int index= -1;
        public Editrecipe()
        {
            InitializeComponent();
        }

        private void BTN_Click(object sender, EventArgs e)
        {
            AdminMenu m = new AdminMenu();
            m.Show();
            this.Hide();
        }

        private void enterbtn_Click(object sender, EventArgs e)
        {
            String name = text.Text;
            if (!text.Equals(null))
            {
                for (int i = 0; i < Driver.GetInstance().GetRecipe().Count; i++)
                {
                    if (name.Equals(Driver.GetInstance().GetRecipe()[i].GetName()))
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
                    textname.Text = Driver.GetInstance().GetRecipe()[index].GetName();
                    richText.Text = Driver.GetInstance().GetRecipe()[index].GetDescription();
                }
            }
            else
            {
                MessageBox.Show("Field is empty");
            }
        }

        private void bTN1_Click(object sender, EventArgs e)
        {
            if (!(index == -1))
            {
                if (textname.Text.Equals(null) || textname.Text.Equals("")){
                      
                }
                else
                {
                    Boolean flag = Driver.GetInstance().GetRecipe()[index].SetName(textname.Text);
                }

                if (richText.Text.Equals(null) || richText.Text.Equals(""))
                {

                }
                else
                {
                    Boolean flag = Driver.GetInstance().GetRecipe()[index].SetDescription(richText.Text);
                    
                }
                MessageBox.Show("Data updated successfully");
                AdminMenu ad = new AdminMenu();
                ad.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("First you need to search the recipe");
            }
        }
    }
}
