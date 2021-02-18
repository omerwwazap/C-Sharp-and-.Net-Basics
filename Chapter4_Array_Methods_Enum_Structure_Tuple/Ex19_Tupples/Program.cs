using System;

namespace Ex19_Tupples
{
	class Program
	{
		static void Main(string[] args)
		{
			//tuple provides concise syntax to group multiple data elements in a lightweight data structure. 
			(string, int, string) values = ("a", 5, "c");
			var values2 = ("a", 5, "c");


			Console.WriteLine($"First item: {values.Item1}");
			Console.WriteLine($"Second item: {values.Item2}");
			Console.WriteLine($"Third item: {values.Item3}");

			(double Sum, int Count) t2 = (4.5, 3);
			Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

			var t = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
					11, 12, 13, 14, 15, 16, 17, 18,
					19, 20, 21, 22, 23, 24, 25, 26);
			Console.WriteLine(t.Item26);

			(string FirstLetter, int TheNumber, string SecondLetter) valuesWithNames = ("a", 5, "c");
		
			Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
			Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
			Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");

			//Using the item notation still works!
			var valuesWithNames2 = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");
			Console.WriteLine($"First item: {valuesWithNames.Item1}");
			Console.WriteLine($"Second item: {valuesWithNames.Item2}");
			Console.WriteLine($"Third item: {valuesWithNames.Item3}");

			Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
			Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
			Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");


			(int, int) example = (Custom1: 5, Custom2: 7);
			(int Field1, int Field2) example2 = (Custom1: 5, Custom2: 7);

			Console.WriteLine($"First item: {example.Item1}");
			Console.WriteLine($"Second item: {example.Item2}");

			Console.WriteLine($"First item: {example2.Field1}");
			Console.WriteLine($"Second item: {example2.Field2}");

			

		}
		
	}
}
