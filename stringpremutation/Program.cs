using System;
using System.Linq;

namespace stringpremutation
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
                Console.WriteLine("Enter the String:");
                string str = Console.ReadLine();

                calc(str);
            }

    
        void calc(string str)
        {
            string x = str;
            // char[] arr = str.ToCharArray();

            for (int i = 0; i < str.Length; i++)
            {
                char one = str[i];
                string two = x.Remove(i);

                string s = string.Concat(one, two);
                Console.WriteLine(s);

                
                two = new string(two.ToCharArray().Reverse().ToArray());
                s = string.Concat(one, two);
                Console.WriteLine(s);

                x = str;
            }
            ask();
        }
    }
}
        
    
