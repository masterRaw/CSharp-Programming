using System;
using System.Linq;

namespace Program3
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
            Console.WriteLine("Enter nos of days for stock price listing: ");
            int days = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[days];

            for (int i = 0; i < days; i++)
            {
                Console.Write("\nEnter stock price for day " + i+1 + " :     ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            calc(arr);
        }
        public void calc(int[] arr)
        {
            int[] diff = new int[100];
            int x = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    diff[x] = arr[j] - arr[i];
                    x++;
                }
            }
            /*  
              for (int i = 0; i < x; i++)
              { 
                  Console.WriteLine(diff[i]); 
              }
            */
            if (diff.Max() > 0)
                Console.WriteLine("\nThe Maximum stock Price is: " + diff.Max() + "\n");
            else
                Console.WriteLine("\nThe Maximum stock Price is: -1\n");
            ask();
        }


    }
}
