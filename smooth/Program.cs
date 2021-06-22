using System;

namespace smooth
{
    class Program
    {
        string str;
        static int  counter=0;

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ask();
        }

        void ask()
        {
            Console.WriteLine("Please enter the String to be checked.");
            str = Console.ReadLine();

            compute(str);
        }
        
        public void compute(string str)
        {
            str = str.ToLower();
            string[] check = str.Split(" ");

            for (int i = 0; i < check.Length - 1; i++)
            {
                string x1 = check[i].Substring(check[i].Length - 1);
                string x2 = check[i + 1].Substring(0, 1);

                if (x1 != x2)
                {
                    Console.WriteLine("\nFalse.\n");
                    counter = 1;
                    break;
                }
               else counter = 0;
            }
            if (counter == 0)
            {
                Console.WriteLine("\nTrue.\n");
            }
            ask();
        }
    }
}
