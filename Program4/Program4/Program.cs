using System;

namespace Program4
{
	class Program
	{
		static public void Main()
		{
			Console.WriteLine("Enter the Number: ");
			int s = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Number of ways = " + steps(s)+"\n");

			Main();
		}
		static int steps(int n)
		{
			if (n <= 2)
				return n;

			return steps(n - 1) + steps(n - 2);
		}

	}
}

