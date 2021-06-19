using System;
using System.Collections.Generic;
using System.Text;

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

        
       

        public static Driver GetInstance()
        {
            if (instance == null)
                instance = new Driver();

            return instance;
        }
    }
}
