using System;

namespace sortcheck
{
    class Program
    {
        int size;
        int counter;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }
        void ask()
        {
            Console.WriteLine("Enter the size of the array");
            size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("\nEnter your number:\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            calc(arr);
        }

        void calc(int[] arr)
        {

            Array.Sort(arr);
            

            if (size - 1 < 1)
                Console.WriteLine("Size is less than 1. ");

            for (int i = 0; i < arr.Length-1; i++)
            {
                int x1 = arr[i + 1];
                int x2 = arr[i];

                if (x1 - x2 != 1)
                {
                    Console.WriteLine("\nThe elements are not consecutive.\n");
                    counter = 1;
                    break;
                }
               else counter = 0;
            }
            if (counter == 0)
            {
                Console.WriteLine("\nThe elements are consecutive.\n");
                Console.Write("Elements in array are: \n");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0}  ", arr[i]);
                }
                Console.WriteLine("\n");
            }
            ask();
        }
    }

}
