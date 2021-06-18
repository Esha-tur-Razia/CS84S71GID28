using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace GuiForMid
{
    class Ingredients
    { 
        private String name;


       
        
            List<String> IngredientList = new List<String>();
        
        public void addIngredient(Ingredients I)
        {
            IngredientList.Add(I);
        }

        private int searchIngredients(String name)
        {
            int index = -1;
            for (int i = 0; i < name.Length; i++)
            {
                if (IngredientList.FindIndex(i).getIngredientsName().equals(name))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }


        public RecipeList getIngredients(String name)
        {
            int index = searchIngredients(name);
            return IngredientList.Equals(index);
        }
        public Boolean updateInngredient(string name, RecipeList I)
        {
            int index = searchIngredients(name);

            if (index == -1)
                return false;
            else
            {
                IngredientList.Equals(index, I);
                return true;
            }
        }



        public override string ToString()
        {
            return base.ToString();
        }

        public Ingredients(string name, List<string> ingredientList) : this(name)
        {
            IngredientList = ingredientList;
        }


        public Boolean deleteIngredient(String name)
        {
            int index = searchIngredients(name);

            if (index == -1)
                return false;
            else
            {
                IngredientList.Remove(index);
                return true;
            }
        }

        public void ReadData()
        {
            FileStream fs = new FileStream("Ingredient.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
            fs.Close();
        }
        public void WriteData()
        {
            FileStream fs = new FileStream("Ingredient.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

    }
}
