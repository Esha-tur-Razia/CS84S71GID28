using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Process : Form
    {
        public Process()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            String process = Processtext.Text;
            if (!process.Equals(null))
            {
                Process1 pro = new Process1();
                if (pro.SetProcess(process))
                {
                    Driver.GetInstance().GetProcess1().Add(pro);
                    Driver.GetInstance().WriteProcess();
                    AdminMenu a = new AdminMenu();
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Data is invalid!");
                }
            }
            else
            {
                MessageBox.Show("Field is empty");
            }
        }
    }
}
