using System;

namespace power
{
    class Program
    {
        int pow, low, upp;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }

        public void ask()
        {
            Console.WriteLine("Enter the power: ");
            pow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the lower limit: ");
            low = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Upper Limit: ");
            upp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            calc(pow, low, upp);
        }

        void calc(int pow, int low, int upp)
        {
            Console.WriteLine("The numbers in the range of "+low +" and "+ upp +" are: ");
            for (int i = 1; i < upp; i++)
            {
                if (Math.Pow(i, pow) >= low && Math.Pow(i, pow) < upp)
                {
                    Console.WriteLine(Math.Pow(i,pow));
                }
            }
            Console.WriteLine();
            ask();
        }
    }
}
