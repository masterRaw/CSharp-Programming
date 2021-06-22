using System;

namespace perfect
{
    class Program
    {
        int num, sum;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }

        public void ask()
        {
            Console.WriteLine("Enter the number.\n");
            num = Convert.ToInt32(Console.ReadLine());

            calc(num);
        }

        public void calc(int num)
        {
            for (int i = 1; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                   // Console.WriteLine(i);
                    sum += i;
                }
               
            }
            if (sum == num)
            {
                Console.WriteLine("A Perfect Number. \n");
                sum = 0;
            }
            else
            {
                sum = 0;
                Console.WriteLine("Not a Perfect Number.\n");
            }
            ask();
        }
    }
}
