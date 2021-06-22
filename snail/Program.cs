using System;

namespace snail
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
            Console.WriteLine("Enter the depth: ");
            int depth = Convert.ToInt32(Console.ReadLine());

            calc(depth);
        }

        public void calc(int depth)
        {
            int tim = 0;
            int hieght = 0;
          
            while (depth >0)
            {
                tim++;
               // hieght += 5;
                depth -= 5;

                if (tim % 30 == 0 && depth !=0 )
                {
                   
                 
                        depth += 30;
                        tim = tim + 10;
                    
                }

               
            }
            Console.WriteLine(tim);
            ask();
        }
    }
}
