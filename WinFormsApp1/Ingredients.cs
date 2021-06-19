using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Ingredients
    {
        private String name;

        private double quantity;

        private String units;

        public Boolean SetName(String name)
        {
            Boolean flag = false;
            int size = name.Length;
            for(int i =0; i<size;i++)
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

        public Boolean SetUnits(String units)
        {
            Boolean flag = false;
            int size = units.Length;
            for (int i = 0; i < size; i++)
            {
                if ((units[i] >= 'A' && units[i] <= 'Z') || (units[i] == ' ') || (units[i] >= 'a' && units[i] <= 'z'))
                {
                    flag = true;
                }
                else
                {
                    return false;
                }

            }
            this.units = units;
            return flag;
        }

        public String GetName()
        {
            return this.name;
        }

        public String GetUnits()
        {
            return this.units;
        }

        public double GetQuantity()
        {
            return this.quantity;
        }

        public Boolean SetQuantity(String Quantity)
        {
            int size = Quantity.Length;
            Boolean flag = false;
            for (int i = 0; i < size; i++)
            {
                if ((Quantity[i] >= '0' && Quantity[i] <= '9') || (Quantity[i] =='.'))
                {
                    flag = true;
                }
                else
                    return false;
            }
            double quan = Convert.ToDouble(Quantity);
            this.quantity = quan;
            return flag;
        }
    }
}
