using System;

namespace Number_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            ask();
        }

        static void ask()
        {
            Console.WriteLine("Enter the String: ");
            string str = Console.ReadLine();
            calc(str);
        }

        static void calc(string str)
        {
            double sum = 0;
            double letter = 0;
           
            char[] strlist = str.ToCharArray();

            for (int i = 0; i < strlist.Length; i++)
            {
                if (char.IsLetter(strlist[i]))
                { 
                    letter++;
                }
                if (char.IsNumber(strlist[i]))
                {
                    sum += Convert.ToDouble(strlist[i].ToString());
                }
            }

            double total1 = sum / letter;
            var total = (int)Math.Round(total1);
            Console.WriteLine(total+"\n");

            ask();

        }
    }
}
