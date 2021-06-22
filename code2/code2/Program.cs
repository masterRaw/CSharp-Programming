using System;
using System.Linq;

namespace code2
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
            Console.WriteLine("Enter the String:\n");
            string str = Console.ReadLine();

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
                    string output = new string(strlist[i].ToCharArray().Reverse().ToArray());
                    Console.Write(output + " ");
            }

            Console.Write(" \n");
            ask();

        }
    }
}
