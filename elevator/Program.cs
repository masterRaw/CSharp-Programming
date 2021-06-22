using System;
using System.Threading;

namespace elevator
{
    class Program
    {
        int curfloor = 0, desfloor;
        const int minfloor = 0;
        const int maxfloor = 10;

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.input();
        }

        void input()
        {
            Console.WriteLine("Enter the Destination Floor");
            desfloor = Convert.ToInt32(Console.ReadLine());

            if (desfloor < minfloor || desfloor > maxfloor || desfloor == curfloor)
                Console.WriteLine("Error with the user Input. You have Entered out-of-range floor.");

            else if (curfloor > desfloor)
                down(desfloor);

            else if (curfloor < desfloor)
                up(desfloor);
        }

        void up(int desfloor)
        {
            Console.WriteLine("Current Floor is: " + curfloor);

            while (curfloor < desfloor)
            {
                curfloor++;
                Console.WriteLine("going up...Current Floor: " + curfloor);
                delay(600);
            }
            Console.WriteLine("You have reached the destination floor: " + desfloor);
            input();
        }

        void down(int desfloor)
        {
            Console.WriteLine("Current Floor is: " + curfloor);

            while (curfloor > desfloor)
            {
                curfloor--;
                Console.WriteLine("going down... Current Floor: " + curfloor);
                delay(600);
            }
            Console.WriteLine("You have reached the destination floor: " + desfloor);
            input();
        }

        void delay(int ms)
        {
            Thread.Sleep(ms);
        }
    }
}