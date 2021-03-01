using System;
using System.Collections.Generic;

namespace Ex13_LambdaExpression
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });
			
			// Now process each argument within a group of
			// code statements.
			List<int> evenNumbers = list.FindAll((i) =>
			{
				Console.WriteLine("value of i is currently: {0}", i);
				bool isEven = ((i % 2) == 0);
				return isEven;
			});
			
			Console.WriteLine("Here are your even numbers:");
			foreach (int evenNumber in evenNumbers)
			{
				Console.Write("{0}\t", evenNumber);
			}
			Console.WriteLine();
		}
	}
}
