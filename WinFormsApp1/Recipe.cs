using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Recipe
    {
        public List<Ingredients> list;
        public Recipe()
        {
            list = new List<Ingredients>();
        }
        private String name;
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
        private String description;
        public Boolean SetDescription(String description)
        {
            Boolean flag = false;
            int size = description.Length;
            for(int i = 0; i < size; i++)
            {
                if((description[i]>='A'&& description[i] <= 'Z')||(description[i] >= 'a' && description[i] <= 'z')||(description[i]==' ')||(description[i] == ':')||(description[i] == '.')||(description[i]=='\n'))
                {
                    flag = true;
                   
                }
                else
                {
                    return false;

                }
            }
            this.description = description;
            return flag;
        }
        public String GetDescription()
        {
            return this.description;
        }

    }
}
