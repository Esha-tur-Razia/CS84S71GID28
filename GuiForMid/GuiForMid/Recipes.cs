using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuiForMid
{
    class Recipes

    {
        private string Title;
        private Instruction instruction;
        private static Recipes instance;


        
        
           List<Recipes> RecipeList = new List<Recipes>();
        
        public static Recipes getInstance()
        {
            if (instance == null)
            {
                instance = new Recipes();
            }

            return instance;
        }
        public void addRecipes(Recipes R)
        {
            RecipeList.Add(R);
        }

        private int searchRecipes(String name)
        {
            int index = -1;
            for (int i = 0; i < name.Length; i++)
            {
                if (RecipeList.FindIndex(i).getRecipesName().equals(name))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }


        public Recipes getRecipes(String name)
        {
            int index = searchRecipes(name);
            return RecipeList.Contains(index);
        }
        public Boolean updateRecipes(string name, Recipes R)
        {
            int index = searchRecipes(name);

            if (index == -1)
                return false;
            else
            {
                RecipeList.Equals(index, R);
                return true;
            }
        }

        public Recipes(string title, Instruction instruction)
        {
            Title = title;
            this.instruction = instruction;
        }

        public Recipes()
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Recipes recipes &&
                   Title == recipes.Title &&
                   EqualityComparer<Instruction>.Default.Equals(instruction, recipes.instruction);
        }

        public override int GetHashCode()
        {
            int hashCode = -1631324304;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<Instruction>.Default.GetHashCode(instruction);
            return hashCode;
        }
        public Boolean deleteRecipes(String name)
        {
            int index = searchRecipes(name);

            if (index == -1)
                return false;
            else
            {
                RecipeList.Remove(index);
                return true;
            }
        }

        public List<RecipeList> getAllRecipes()
        {
            return Recipes;
        }
        public void ReadData()
        {
            FileStream fs = new FileStream("Recipes.txt", FileMode.Open, FileAccess.Read);
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
            FileStream fs = new FileStream("Recipes.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
 
            string str = Console.ReadLine();
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

    }
}