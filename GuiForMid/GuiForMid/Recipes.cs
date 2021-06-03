using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GuiForMid
{
    class Recipes : Ingredients

    {
        private string Title;
        private Instruction instruction;
        private static Recipes instance;


        private Recipes()
        {
     ArrayList Ingredients = new ArrayList();
        }
        public static Recipes getInstance()
        {
            if (instance == null)
            {
                instance = new Recipes();
            }

            return instance;
        }
        public void addContact(Ingredients I)
        {
            Ingredients.Add(I);
        }

        private int searchIngredients(String name)
        {
            int index = -1;
            for (int i = 0; i < name.Length; i++)
            {
                if (Ingredients.get(i).getIngredientsName().equals(name))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }


        public Ingredients getIngredients(String name)
        {
            int index = searchIngredients(name);
            return Ingredients.set(index);
        }
        public Boolean updateInngredient(string name, Ingredients I)
        {
            int index = searchIngredients(name);

            if (index == -1)
                return false;
            else
            {
                Ingredients.Equals(index, I);
                return true;
            }
        }

        public Recipes(string title, Instruction instruction)
        {
            Title = title;
            this.instruction = instruction;
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
        public Boolean delteIngredient(String name)
        {
            int index = searchIngredients(name);

            if (index == -1)
                return false;
            else
            {
                Ingredients.remove(index);
                return true;
            }
        }

        public List<Ingredients> getAllIngredients()
        {
            return Ingredients;
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