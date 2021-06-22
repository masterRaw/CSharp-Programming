using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace longeststring
{
    class Program
    {
        string s;
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
            

            String[] strlist = str.Split(" ");
            strlist[0] = Regex.Replace(strlist[0], @"[^a-zA-Z]+", "");
            int max = strlist[0].Length;

            for (int i = 1; i < strlist.Length; i++)
            {
                strlist[i] = Regex.Replace(strlist[i], @"[^a-zA-Z]+", "");
                if (strlist[i].Length > max)
                    max = strlist[i].Length;
                  s = strlist[i];

            }

            Console.WriteLine(s);

            ask();

        }
    }
}
