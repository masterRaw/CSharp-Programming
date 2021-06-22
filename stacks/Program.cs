using System;

namespace stacks
{
    class Program
    {
        int choice;
        int ele = 0;
        int top = -1;
        int max;
        int[] stackdsa = new int[50];

        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.ask();
        }

        void ask()
        {
            Console.WriteLine("What would you like to do?");
            Console.Write(" 1. Push the Element. ");
            Console.Write(" 2. Pop the Element. ");
            Console.WriteLine(" 3. Display the Elements of the stack. ");

            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                push(ele);
            }
            else if (choice == 2)
            {
                pop();
            }
            else if (choice == 3)
            {
                show();
            }
            else
            {
                Console.WriteLine("Please Enter a valid Choice.");
                ask();
            }
        }

        void push(int ele)
        {
            Console.WriteLine("Enter the element to be pushed.");
            ele = Convert.ToInt32(Console.ReadLine());

            stackdsa[++top] = ele;
            Console.WriteLine("Element pushed");
            ask();
        }

        public void pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");

            }
            else
            {
                Console.WriteLine("{0} popped from stack ", stackdsa[top]);
                stackdsa[top] = stackdsa[top--];
            }
            ask();
        }

        void show()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Elements in the stack are: " + stackdsa[i]);
                }
            }
            ask();
        }
    }
}