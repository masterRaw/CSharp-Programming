using System;
using System.Linq;

namespace stringreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }

        public void ask()
        {
            Console.WriteLine("The words with ODD lengths will get reversed.");
            Console.WriteLine("Enter the String:\n");
            string str = Console.ReadLine();
            //Console.WriteLine("\n");

            calc(str);
        }

        public void calc(string str)
        {
            Console.Write("Reversed string: ");

            char[] spearator = { ' ', ' ' };

            String[] strlist = str.Split(spearator,
           StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < strlist.Length; i++)
            {
                if (strlist[i].Length % 2 != 0)
                {
                    string output = new string(strlist[i].ToCharArray().Reverse().ToArray());


                    Console.Write(output+ " ");
                }
                else Console.Write( strlist[i] +" ");
            }

            Console.Write(" \n");

            ask();

        }
    }
}
