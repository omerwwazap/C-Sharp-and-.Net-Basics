using System;
using System.Linq;

namespace Ex10_Iteration
{
	class Program
	{
		static void Main(string[] args)
		{
			// Note! "i" is only visible within the scope of the for loop.
			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("Number is: {0} ", i);
			}
			// "i" is not visible here.
			/******************************************************/
			string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
			foreach (string c in carTypes)
			{
				Console.WriteLine(c);
			}

			int[] myInts = { 10, 20, 30, 40 };
			foreach (int i in myInts)
			{
				Console.WriteLine(i);
			}

			/******************************************************/

			int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
			// LINQ query!
			var subset = from i in numbers where i < 10 select i;
			Console.Write("Values in subset: ");
			foreach (var i in subset)
			{
				Console.Write("{0} ", i);
			}
			Console.WriteLine();
			// Hmm...what type is subset?
			Console.WriteLine("subset is a: {0}", subset.GetType().Name);
			Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);

			/******************************************************/
			string userIsDone = "";
			// Test on a lower-class copy of the string.
			while (userIsDone.ToLower() != "yes")
			{
				Console.WriteLine("In while loop");
				Console.Write("Are you done? [yes] [no]: ");
				userIsDone = Console.ReadLine();
			}
			/******************************************************/
			userIsDone = "";
			do
			{
				Console.WriteLine("In do/while loop");
				Console.Write("Are you done? [yes] [no]: ");
				userIsDone = Console.ReadLine();
			} while (userIsDone.ToLower() != "yes"); // Note the semicolon!
		}
	}
}
