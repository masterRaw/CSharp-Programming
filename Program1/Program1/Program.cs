using System;

namespace Program1
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
			Console.WriteLine("Enter the number: ");
			int num = Convert.ToInt32(Console.ReadLine());

			calc(num);
		}

		int calc(int number)
		{
			int count = 0;
			int remainder = number;
			int sub = number;

			if (number >= 11)
			{
				count += number / 11;
				remainder = number % 11;
				number = remainder;

			}
			if (remainder >= 9)
			{
				count += remainder / 9;
				remainder = number % 9;
				number = remainder;

			}
			if (remainder >= 7)
			{
				count += remainder / 7;
				remainder = number % 7;
				number = remainder;

			}
			if (remainder >= 5)
			{
				count += remainder / 5;
				remainder = remainder % 5;
				number = remainder;

			}
			if (remainder > 0)
			{
					count+= remainder;	
			}
			Console.WriteLine("Count = " + count);

			ask();
			return 1;
		}
	}
}
