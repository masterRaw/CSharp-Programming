using System;

namespace isogram
{
    class Program
    {
        string str;
        int cnt = 0;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ask();
        }

        public void ask()
        {
            Console.WriteLine("Enter the string: \n");
            str = Console.ReadLine();
            calc(str);
        }

        public void calc(string str)
        {
            char []arr = str.ToCharArray();
            Array.Sort(arr);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    Console.WriteLine("False.\n");
                    cnt = 1;
                    break;
                }
                else cnt = 0;
                
            }
        
            if(cnt == 0)
            Console.WriteLine("True.\n");
            ask();
            
           
        }
    }
}
