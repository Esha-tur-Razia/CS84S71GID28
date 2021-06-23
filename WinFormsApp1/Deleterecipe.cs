using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Deleterecipe : Form
    {
        public Deleterecipe()
        {
            InitializeComponent();
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            AdminMenu a = new AdminMenu();
            a.Show();
            this.Hide();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            String name = text.Text;
            if (!name.Equals(null))
            {
                int check=-1;
                for(int i = 0; i < Driver.GetInstance().GetRecipe().Count;i++)
                {
                    if (name.Equals(Driver.GetInstance().GetRecipe()[i].GetName()))
                    {
                        Driver.GetInstance().GetRecipe().RemoveAt(i);
                        Driver.GetInstance().GetProcess1().RemoveAt(i);
                        check = 0;
                        break;
                    }
                    else
                    {
                        check = 1;
                    }
                    
                }
                if (check == 0)
                {
                    MessageBox.Show("Data has been removed successfully");
                    Driver.GetInstance().WriteRecipe();
                    AdminMenu m = new AdminMenu();
                    m.Show();
                    this.Hide();
                }
                else if (check == 1)
                {
                    MessageBox.Show("Data not found!!");
                }
            }
            else
                {
                MessageBox.Show("Field is empty");
            }
        }
    }
}
