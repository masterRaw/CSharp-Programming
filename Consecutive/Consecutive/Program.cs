using System;
using System.Linq;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length of Array:     ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter Element: "+(i+1)+" :   ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            calc(arr);
        }

        static void calc(int[] arr)
        {
           Array.Sort(arr);
            int min = arr[0];
            int max = arr[arr.Length-1];
            int total = max - arr.Length-min+1;
            
            Console.WriteLine(total);
        }
    }
}
