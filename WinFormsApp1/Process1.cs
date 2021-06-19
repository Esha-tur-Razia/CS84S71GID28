using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Process1
    {
        private String process;
        public Boolean SetProcess(String description)
        {
            Boolean flag = false;
            int size = description.Length;
            for (int i = 0; i < size; i++)
            {
                if ((description[i] >= 'A' && description[i] <= 'Z') || (description[i] >= 'a' && description[i] <= 'z') || (description[i] == ' ') || (description[i] == ':') || (description[i] == '.') || (description[i] == '\n'))
                {
                    flag = true;

                }
                else
                {
                    return false;

                }
            }
            this.process = description;
            return flag;
        }
        public String GetDescription()
        {
            return this.process;
        }

    }
}
