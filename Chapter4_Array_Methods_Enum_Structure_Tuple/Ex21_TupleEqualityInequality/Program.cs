using System;

namespace Ex21_TupleEqualityInequality
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Tuples Equality/Inequality");
			// lifted conversions
			var left = (a: 5, b: 10);
			Console.WriteLine($"{left.a}, {left.b}");
			
			(int? a, int? b) nullableMembers = (5, 10);
			Console.WriteLine($"{nullableMembers.a}, {nullableMembers.b}");
			
			Console.WriteLine(left == nullableMembers); // Also true
														// converted type of left is (long, long)
			(long a, long b) longTuple = (5, 10);
			Console.WriteLine($"{longTuple.a}, {longTuple.b}");
			Console.WriteLine(left == longTuple); // Also true
												  // comparisons performed on (long, long) tuples
			(long a, int b) longFirst = (5, 10);
			(int a, long b) longSecond = (5, 10);
			Console.WriteLine($"{longFirst.a}, {longFirst.b}");
			Console.WriteLine($"{longSecond.a}, {longSecond.b}");
			Console.WriteLine(longFirst == longSecond); // Also true
		}
	}
}
