using System;

namespace Arith_Geo_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 8 };
            int[] arr1 = { 2, 6,18,54 };
            int[] arr2 = { 2, 4, 6, 4};

            calc(arr);
            calc(arr1);
            calc(arr2);
        }

        static void calc(int[] arr)
        {
            int counter = 0;
            int arith = 0;
            int geo = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] - arr[i + 1] != arr[i + 1] - arr[i + 2])
                {
                    counter = 1;
                    
                }
                else if (counter != 1)
                {
                    arith = 1;
                    Console.WriteLine("Arithmetic");
                    break;
                }
            }

            for (int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] / arr[i + 1] != arr[i + 1] / arr[i + 2])
                {
                    counter = 1;

                }
                else if (counter != 1)
                {
                    geo = 1;
                    Console.WriteLine("Geometric");
                    break;
                }
            }

            if (arith != 0 && geo != 0)
            {
                Console.WriteLine("-1");
                
            }



        }
    }
}
