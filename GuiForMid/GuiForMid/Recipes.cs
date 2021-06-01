using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiForMid
{
    class Recipes
    {
        private string Title;
        private Instruction instruction;

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