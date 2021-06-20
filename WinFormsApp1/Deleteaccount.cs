using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Deleteaccount : Form
    {
        public Deleteaccount()
        {
            InitializeComponent();
            Insert();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            AdminMenu ad = new AdminMenu();
            ad.Show();
            this.Hide();

        }
        public void Insert()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Id");
            data.Columns.Add("Name");
            dataGridView1.DataSource = data;
            for(int i = 0; i < Driver.GetInstance().GetUser().Count; i++)
            {
                data.Rows.Add(Driver.GetInstance().GetUser()[i].GetID(), Driver.GetInstance().GetUser()[i].GetName());
                dataGridView1.DataSource = data;
            }
        }

        private void DELBTN_Click(object sender, EventArgs e)
        {
            String id = Idtext.Text;
            if (!id.Equals(null))
            {
                int check = -1;
                for (int i = 0; i < Driver.GetInstance().GetUser().Count; i++)
                {
                   
                    if (id.Equals(Driver.GetInstance().GetUser()[i].GetID()))
                    {
                        check = i;
                       
                        break;
                    }
                    else
                    {
                        check = -1;
                        
                    }
                }
                if (check == -1)
                {
                    MessageBox.Show("ID not found!!");
                }
                else
                {
                    Driver.GetInstance().GetUser().RemoveAt(check);
                    Insert();
                    MessageBox.Show("Data has been deleted!");
                }
            }

            else
            {
                MessageBox.Show("Fields are empty!!");
            }

        }
    }
}
