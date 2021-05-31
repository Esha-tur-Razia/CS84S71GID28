using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiForMid
{
    class Instruction
    {
        private String cookTime;
        private String temprature;
        private String narrative;



        public Instruction()
        {
        }

        public Instruction(string cookTime, string temprature, string narrative)
        {
            this.cookTime = cookTime;
            this.temprature = temprature;
            this.narrative = narrative;
        }




        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
