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
            //the path of the file
            FileStream inFile = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);
            string record;
            String userSearch = search.Text;
            try
            {
                //the program reads the record and displays it on the screen
                record = reader.ReadLine();
                while (record != null)
                {
                    if (record.Contains(userSearch))
                    {
                        richTextBox1.LoadFile(path);
                    }
                    record = reader.ReadLine();
                }
            }
            finally
            {
                //after the record is done being read, the progam closes
                reader.Close();
                inFile.Close();
            }

        }
    }
}
