using System;

namespace Ex11_Conditions
{
	class Program
	{
		static void Main(string[] args)
		{
			string stringData = "My textual data";
			if (stringData.Length > 0)
			{
				Console.WriteLine("string is greater than 0 characters");
			}
			else
			{
				Console.WriteLine("string is not greater than 0 characters");
			}
			Console.WriteLine();
			/**********************************************/
			Console.WriteLine("===If Else Pattern Matching ===/n");
			object testItem1 = 123;
			object testItem2 = "Hello";
			if (testItem1 is string myStringValue1)
			{
				Console.WriteLine($"{myStringValue1} is a string");
			}
			if (testItem1 is int myValue1)
			{
				Console.WriteLine($"{myValue1} is an int");
			}
			if (testItem2 is string myStringValue2)
			{
				Console.WriteLine($"{myStringValue2} is a string");
			}
			if (testItem2 is int myValue2)
			{
				Console.WriteLine($"{myValue2} is an int");
			}
			Console.WriteLine();
			/**********************************************/
			stringData = "My textual data";
			Console.WriteLine(stringData.Length > 0 ? "string is greater than 0 characters" : "string is not greater than 0 characters");

			/**********************************************/

			Console.WriteLine("1 [C#], 2 [VB]");
			Console.Write("Please pick your language preference: ");
			string langChoice = Console.ReadLine();
			int n = int.Parse(langChoice);
			switch (n)
			{
				case 1:
					Console.WriteLine("Good choice, C# is a fine language.");
					break;
				case 2:
					Console.WriteLine("VB: OOP, multithreading, and more!");
					break;
				default:
					Console.WriteLine("Well...good luck with that!");
					break;
			}

			Console.Write("Please pick your language preference: ");
			langChoice = Console.ReadLine();
			switch (langChoice.ToUpper())
			{
				case "C#":
					Console.WriteLine("Good choice, C# is a fine language.");
					break;
				case "VB":
					Console.WriteLine("VB: OOP, multithreading and more!");
					break;
				default:
					Console.WriteLine("Well...good luck with that!");
					break;
			}

			var foo = 5;
			switch (foo)
			{
				case 1:
					//do something
					goto case 2;
				case 2:
					//do something else
					break;
				case 3:
					//yet another action
					goto default;
				default:
					//default action
					break;
			}

			Console.WriteLine(FromRainbow("Yellow")); 
			Console.WriteLine(RockPaperScissors("paper", "rock"));
			Console.WriteLine(RockPaperScissors("scissors", "rock"));
		}

		static string FromRainbow(string colorBand)
		{
			return colorBand switch
			{
				"Red" => "#FF0000",
				"Orange" => "#FF7F00",
				"Yellow" => "#FFFF00",
				"Green" => "#00FF00",
				"Blue" => "#0000FF",
				"Indigo" => "#4B0082",
				"Violet" => "#9400D3",
				_ => "#FFFFFF",
			};
		}
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
