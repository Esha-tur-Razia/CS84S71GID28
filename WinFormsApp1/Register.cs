using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(maleRadio.Checked)
            {
                femaleRadio.Checked = false;
            }
        }

        private void femaleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (femaleRadio.Checked)
            {
                maleRadio.Checked = false;
            }
        }

        private void cancelButon_Click(object sender, EventArgs e)
        {
            UserLogin user = new UserLogin();
            user.Show();
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            String name = this.name.Text;
            String password = this.password.Text;
            String contact = this.contactno.Text;
            String age = this.age.Text;
            String gender = "";
            if (maleRadio.Checked)
                gender = "Male";
            else if (femaleRadio.Checked)
                gender = "Female";
            else
                MessageBox.Show("Gender is not Selected!");

            if(!name.Equals(null) && !password.Equals(null) && !contact.Equals(null) && !age.Equals(null) && !gender.Equals(""))
            {
                User user = new User(gender, password);
                if(user.SetName(name))
                {
                    if(user.SetContact(contact))
                    {
                        if(user.SetAge(age))
                        {
                            Driver.GetInstance().GetUser().Add(user);
                            MessageBox.Show("You have been registered Successfully");
                            UserLogin userc = new UserLogin();
                            userc.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("Age should be in Digits! \n Age should be between 15 to 60");
                    }
                    else
                        MessageBox.Show("Invalid Contact!");
                }
                else
                    MessageBox.Show("Invalid Name!");
            }
            else
                MessageBox.Show("Fields are Empty!");
        }
    }
}
