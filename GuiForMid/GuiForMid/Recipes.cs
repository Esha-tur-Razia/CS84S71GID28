using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiForMid
{
    class Recipes : Ingredients

    {
        private string Title;
        private Instruction instruction;
        private static Recipes instance;


        private Recipes()
        {
            var Ingredients = new ArrayList();
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
            Ingredients.add(I);
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
        public Boolean updateContact(String name, Ingredients I)
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

        
    }
}