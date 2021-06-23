using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

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
                    if (j==(Driver.GetInstance().GetRecipe()[i].list.Count) - 1)
                    {
                        s1 += Driver.GetInstance().GetRecipe()[i].list[j].GetName() ;
                        s2 += Driver.GetInstance().GetRecipe()[i].list[j].GetQuantity() ;
                    }
                    else
                    {
                        s1 += Driver.GetInstance().GetRecipe()[i].list[j].GetName() + ",";
                        s2 += Driver.GetInstance().GetRecipe()[i].list[j].GetQuantity() + ",";
                    }
                }

                sw.WriteLine(recipe[i].GetName() + ";"+s1+";"+s2+";"+ recipe[i].GetDescription());

               
            }

            sw.Flush();
            sw.Close();
        }

        public void WriteProcess()
        {
            try
            {
                StreamWriter s = new StreamWriter("Processes.txt");
                for (int i = 0; i < Driver.GetInstance().GetProcess1().Count; i++)
                {
                    if (i == 0)
                        s.WriteLine(Driver.GetInstance().GetProcess1()[i].GetDescription());
                    else
                        s.WriteLine(",\n" + Driver.GetInstance().GetProcess1()[i].GetDescription());
                }
                s.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Process file not found");
            }
        }

        public void ReadProcess()
        {
            try
            {
                String pro = File.ReadAllText("Processes.txt");
                if (pro.Equals(null))
                {
                    Console.WriteLine("No data Entered Yet");
                }
                else
                {
                    String[] toks = pro.Split(",\n");
                    for (int i = 0; i < toks.Length; i++)
                    {
                        Process1 p = new Process1();
                        p.SetProcess(toks[i]);
                        Driver.GetInstance().GetProcess1().Add(p);
                        Console.WriteLine(p.GetDescription());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Process file not found");
            }
        }
        public void ReadRecipe()
        {
            try
            {
                StreamReader rd = new StreamReader("Recipe.txt");
                String line = rd.ReadLine();
                while(line!=null)
                {
                    Recipe rec = new Recipe();
                    String[] toks = line.Split(";");
                    
                    rec.SetName(toks[0]);
                    rec.SetDescription(toks[3]);
                    String[] token1 = toks[1].Split(",");
                    String[] token2 = toks[2].Split(",");
                    for(int j=0;j<token1.Length;j++)
                    {
                        Ingredients ing = new Ingredients();
                        ing.SetName(token1[j]);
                        ing.SetQuantity(token2[j]);
                        rec.list.Add(ing);
                    }
                    Driver.GetInstance().GetRecipe().Add(rec);
                    //MessageBox.Show(rec.ToString());
                    line = rd.ReadLine();

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Recipe File not found");
            }
        }


        public static Driver GetInstance()
        {
            if (instance == null)
                instance = new Driver();

            return instance;
        }
    }
}
