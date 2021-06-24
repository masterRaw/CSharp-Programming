using System;

namespace Multiplicative_Persistence
{
    class Program
    {
        static void Main(string[] args)
        {
            ask();
        }

        public static void ask()
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            calc(num);
        }

        public static void calc(int num)
        {
            if (num < 10)
            {
                Console.WriteLine("0");
            }

            else if (num < 100)
            {
                int counter = 1;

                int multiply = (num / 10) * (num % 10);

                while (multiply >= 10)
                {
                    multiply = (multiply / 10) * (multiply % 10);
                    counter++;
                }

                Console.WriteLine(counter);
            }
            else if (num >= 100 && num < 1000)
            {
                int counter = 1;

                int multiply = (num / 100) * ((num % 100) / 10) * ((num % 100) % 10);

                while (multiply >= 10)
                {
                    multiply = (multiply / 10) * (multiply % 10);
                    counter++;
                }
                Console.WriteLine(counter);

            }

            else
                Console.WriteLine("Please write a positive number less than 1000. ");

            ask();
        }
    }
}
