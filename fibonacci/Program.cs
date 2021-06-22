using System;

namespace fibonacci
{
    class Program
    {
        int num;
        int a = 0;
        int b = 1;
        int fib = 0;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }

        void ask()
        {
            Console.WriteLine("Enter the Number");
            num = Convert.ToInt32(Console.ReadLine());
            fibo(num);
        }

        public void fibo(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                fib = fib + i;
            }

            string str = Convert.ToString(fib);
            Console.WriteLine("The "+ num +"th number of the fibonacci series is : " +str );
            Console.WriteLine();
            ask();
        }
    }
}
