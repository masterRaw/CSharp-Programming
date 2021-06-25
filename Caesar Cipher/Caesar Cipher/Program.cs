using System;
using System.Collections.Generic;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to encrypted: ");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the string to encrypted: ");
            int x  = Convert.ToInt32(Console.ReadLine());

            calc(str,x);
        }

        static void calc(string str, int x)
        {
            char[] strlist = str.ToCharArray();
            char[] cipher = new char[str.Length];

            for (int i = 0; i < strlist.Length; i++)
            {
                if (Char.IsLetter(strlist[i]))
                {
                    cipher[i]= (char)((int)(strlist[i]+ x));
                }
            }

            Console.WriteLine(cipher);
        }
    }
}
