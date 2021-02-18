using System;

namespace Ex22_TuplesAsMethodReturnValues
{
	class Program
	{
		static void Main(string[] args)
		{
			var (minimum, maximum) = FindMinMax(3, 8, 7, 4, 2, 10, 100);
			Console.WriteLine("minimum {0}, maximum {1}", minimum, maximum);
			
			
			var samples = FillTheseValues();
			Console.WriteLine($"Int is: {samples.a}");
			Console.WriteLine($"String is: {samples.b}");
			Console.WriteLine($"Boolean is: {samples.c}");

			var res = RockPaperScissors("rock", "paper");
			Console.WriteLine($"Res : {res}");
			

		}
		public static (int min, int max) FindMinMax(params int[] input)
		{
			if (input is null || input.Length == 0)
			{
				throw new ArgumentException("Cannot find minimum and maximum of a null or empty array.");
			}

			var min = int.MaxValue;
			var max = int.MinValue;
			foreach (var i in input)
			{
				if (i < min)
				{
					min = i;
				}
				if (i > max)
				{
					max = i;
				}
			}
			return (min, max);
		}
		static (int a, string b, bool c) FillTheseValues()
		{
			return (9, "Enjoy your string.", true);
		}

		//Switch expression with Tuples
		static string RockPaperScissors(string first, string second)
		{
			return (first, second) switch
			{
				("rock", "paper") => "Paper wins.",
				("rock", "scissors") => "Rock wins.",
				("paper", "rock") => "Paper wins.",
				("paper", "scissors") => "Scissors wins.",
				("scissors", "rock") => "Rock wins.",
				("scissors", "paper") => "Scissors wins.",
				(_, _) => "Tie.",
			};
		}
	}
}
