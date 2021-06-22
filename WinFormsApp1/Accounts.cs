using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
            InsertData();

        }
        public void InsertData()
        {
            DataTable data = new DataTable();
            data.Columns.Add("Id");
            data.Columns.Add("Name");
            data.Columns.Add("Contact");
            data.Columns.Add("Gender");
            data.Columns.Add("Password");
            data.Columns.Add("Age");
           dataGridView1.DataSource = data;
           for(int i = 0; i < Driver.GetInstance().GetUser().Count; i++)
            {

                data.Rows.Add(Driver.GetInstance().GetUser()[i].GetID(), Driver.GetInstance().GetUser()[i].GetName(), Driver.GetInstance().GetUser()[i].GetContact(), Driver.GetInstance().GetUser()[i].GetGender(), Driver.GetInstance().GetUser()[i].GetPassword(), Driver.GetInstance().GetUser()[i].GetAge());
                dataGridView1.DataSource = data;
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            AdminMenu ad = new AdminMenu();
            ad.Show();
            this.Hide();
            
        }
    }
}
