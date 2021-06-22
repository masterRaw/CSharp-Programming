using System;

namespace stringmangle
{
    class Program
    {
        char[] arr;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }

        public void ask()
        {
            Console.WriteLine("Enter the String. ");
            string str = Console.ReadLine();

            calc(str);
        }

        public void calc(string str)
        {
            char[] spearator = { ' ', ' ' };

            String[] ar = str.Split(spearator,
           StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar[i].Length; j++)
                {
                     arr = ar[i].ToCharArray();

                    if (arr[j] == 'z')
                    {
                        arr[j] = 'a';
                    }
                    else
                    {
                        char a = (char)(str[j] + 1);
                        arr[j] = a;

                        string up = Convert.ToString(a);


                        if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                        {

                            up = up.ToUpper();
                            arr[j] = Convert.ToChar(up);
                        }

                    }
                }
                string output = string.Join("", arr);

            }

            
            
            Console.WriteLine(arr);


        }
    }
}
