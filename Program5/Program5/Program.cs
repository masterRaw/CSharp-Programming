using System;
using System.Collections;

namespace Program5
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
            Console.Write("Enter the character string:     ");
            string str = Console.ReadLine();

            calc(str);
        }

        public void calc(string str)
        {
            Stack s = new Stack();
            char[] braces = str.ToCharArray();
            int x = 1;
            int counter = 0;
            int empty = 0;

            for (int i = 0; i < braces.Length; i++)
            {
                if (braces[i] != 40 && braces[i] == 41 && counter ==0)
                {
                    s.Push(x);
                    x++;
                }
               else if (braces[i] == 40)
                {
                    counter = 1;
                    s.Push(x);
                    x++;
                }
                else if (braces[i] == 41 )
                {
  
                        s.Pop();
                        x--;
                    
                }
            }
                if (x > 1)
                {
                    int total = (int)s.Peek() + empty;
                    Console.WriteLine("Minimum Number of brackets to be removed is/are:   " + total + "\n");
                }
                else
                    Console.WriteLine("Minimum Number of brackets to be removed is/are:   0\n");
           
            ask();
        }
           
    }

}
