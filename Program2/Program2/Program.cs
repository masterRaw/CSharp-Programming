using System;
using System.Linq;
using System.Collections.Generic;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }

        void ask()
        {
            Console.WriteLine("Enter the Integer: \n");
            int input = Convert.ToInt32(Console.ReadLine());

            int[] digit = input.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            List<int> digitlist = digit.ToList();

            int round = 0;
            calc(input, digitlist, round);
        }

        void calc(int input,List<int> digitlist, int round)
        {
            int multiplication = 0;
            int counter = 0;

            while (counter != digitlist.Count())
            {
                int newinput = input * digitlist[counter];
                int[] digitvar = newinput.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
                List<int>  digitvarlist = digitvar.ToList();

                digitlist = digitlist.Concat(digitvar).ToList();

                    for (int k = 0; k < digitlist.Count() - 1; k++)
                    {
                        if (digitlist[k] == digitlist[k + 1])
                        {
                            multiplication++;
                            break;
                        }
                    }
                /*
                    if (multiplication < 1)
                    {
                    int rem = digitlist.IndexOf(digitlist.Last());
                    digitlist = digitlist.RemoveRange(digitvar.Length, rem);
                    }
                    
                    counter++;
                */
                }
                

        }
    }
}



