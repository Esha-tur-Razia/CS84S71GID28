using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace WinFormsApp1
{
    class Driver
    {
        private static Driver instance;

        private List<User> user;
        private List<Recipe> recipe;
        

        public List<User> GetUser()
        {
            return user;
           
        }

        private Driver()
        {
            user = new List<User>();
            recipe = new List<Recipe>();
            Pro = new List<Process1>();
        }
        public List<Recipe> GetRecipe()
        {
            return recipe;
        }
        private List<Process1> Pro;
        public List<Process1> GetProcess1()
        {
            return Pro;
        }
        public void WriteRecipe()
        {
            StreamWriter sw = new StreamWriter("Recipe.txt");
            string s1="";

            string s2 = "";
           

            for (int i = 0; i < Driver.GetInstance().GetRecipe().Count;i++)
            {
                for(int j=0;j< Driver.GetInstance().GetRecipe()[i].list.Count; j++)
                {
                    s1 += Driver.GetInstance().GetRecipe()[i].list[j].GetName() + ",";
                    s2+= Driver.GetInstance().GetRecipe()[i].list[j].GetQuantity() + ",";
                }

                sw.WriteLine(recipe[i].GetName() + ";"+s1+";"+s2+";"+ recipe[i].GetDescription());

               
            }

            sw.Flush();
            sw.Close();
        }

        
       

        public static Driver GetInstance()
        {
            if (instance == null)
                instance = new Driver();

            return instance;
        }
    }
}
