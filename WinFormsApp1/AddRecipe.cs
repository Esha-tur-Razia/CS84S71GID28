using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddRecipe : Form
    {
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            AdminMenu menu = new AdminMenu();
            menu.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            /*Process pr = new Process();
             pr.Show();
             this.Hide();*/
            String name = nameText.Text;
            String quantity = quanText.Text;
            String description = desText.Text;
            String ingredients = ingredientText.Text;

            if(!name.Equals(null) && !ingredients.Equals(null) && !quantity.Equals(null) && !description.Equals(null))
            {
                Recipe res = new Recipe();
                if (res.SetName(name))
                {
                    if (res.SetDescription(description))
                    {
                        String[] token1 = quantity.Split(',');
                        String[] token2 = ingredients.Split(',');
                        if (token2.Length == token1.Length)
                        {
                            int check=-1;
                            Ingredients ing = new Ingredients();

                            for(int i = 0; i < token1.Length; i++)
                            {
                                if (ing.SetQuantity(token1[i]))
                                {
                                    check = 1;
                                    if (ing.SetName(token2[i]))
                                    {
                                        check =1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ingredients  should be in valid");
                                        check = 0;
                                        break;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Quantities should be in digits");
                                    check = 0;
                                    break;
                                }
                            }
                            if (check == 1)
                            {
                                res.list.Add(ing);
                                Driver.GetInstance().GetRecipe().Add(res);
                                MessageBox.Show("Your data has been added successfully");
                                Process pr = new Process();
                                            pr.Show();
                                            this.Hide();
                            }

                        }
                        else
                        {
                            MessageBox.Show("quantities should be equal to ingredients");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Description is invalid!");
                    }
                }
                else
                {
                    MessageBox.Show("Name is invalid!");
                }
            }
            else
            {
                MessageBox.Show("Fields are empty");
            }
        }
    }
}
