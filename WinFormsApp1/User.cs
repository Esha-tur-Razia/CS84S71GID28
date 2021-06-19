using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class User
    {
        private String name;

        private String contact;

        private int age;

        private String Gender;

        private String ID;

        private String Password;

        public User()
        { }

        public User(String gender, String password)
        {
            this.Gender = gender;
            this.Password = password;
        }

        public Boolean SetName(String name)
        {
            Boolean flag = false;
            int size = name.Length;
            for (int i = 0; i < size; i++)
            {
                if ((name[i] >= 'A' && name[i] <= 'Z') || (name[i] == ' ') || (name[i] >= 'a' && name[i] <= 'z'))
                {
                    flag = true;
                }
                else
                {
                    return false;
                }

            }
            this.name = name;
            return flag;
        }

        public String GetName()
        {
            return this.name;
        }

        public Boolean SetContact(String contact)
        {
            Boolean flag = false;
            int size = contact.Length;
            if (size == 11)
            {
                for (int i = 0; i < size; i++)
                {
                    if ((contact[i] >= '0' && contact[i] <= '9'))
                    {
                        flag = true;
                    }
                    else
                        return false;
                }
            }
            else
                return false;
            this.contact = contact;
            return flag;
        }

        public String GetContact()
        {
            return this.contact;
        }

        public String GetGender()
        {
            return this.Gender;
        }

        public String GetPassword()
        {
            return this.Password;
        }

        public Boolean SetAge(String age)
        {
            int size = age.Length;
            Boolean flag = false;
            for (int i = 0; i < size; i++)
            {
                if ((age[i] >= '0' && age[i] <= '9'))
                {
                    flag = true;
                }
                else
                    return false;
            }
            int AGE = Convert.ToInt32(age);
            if (AGE > 15 && AGE < 60)
                this.age = AGE;
            else
                return false;

            return flag;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void GenerateID()
        {
            String id = "ID-";
            Random rand = new Random();
            for(int i=0;i<4;i++)
            {
                id += rand.Next(10);
            }
            this.ID = id;
        }

        public String GetID()
        {
            return this.ID;
        }

        public void SetID(String ID)
        {
            this.ID = ID;
        }
    }
}
