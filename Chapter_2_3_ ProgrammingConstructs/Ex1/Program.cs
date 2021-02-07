using System;

namespace Ex1
{
	class Program
	{
		static void Main(string[] args)
		{
			// Display a simple message to the user.
			Console.WriteLine("Enter number ");
			int num1 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Enter number ");
			double num2 = double.Parse(Console.ReadLine());

			double res = num1 + num2;

			Console.WriteLine("Sum is "+res);
			Console.WriteLine("Sum is {0}", res);

		}
	}
}
