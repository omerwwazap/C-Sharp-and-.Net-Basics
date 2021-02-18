using System;

namespace Ex12_MethodUsingNamedArguments
{
	class Program
	{
		static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
		{

			// Store old colors to restore after message is printed.
			ConsoleColor oldTextColor = Console.ForegroundColor;
			ConsoleColor oldbackgroundColor = Console.BackgroundColor;
			// Set new colors and print message.
			Console.ForegroundColor = textColor;
			Console.BackgroundColor = backgroundColor;
			Console.WriteLine(message);
			// Restore previous colors.
			Console.ForegroundColor = oldTextColor;
			Console.BackgroundColor = oldbackgroundColor;
		}
		static void Main(string[] args)
		{
			DisplayFancyMessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
			DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...",textColor: ConsoleColor.DarkBlue);

			// This is OK, as positional args are listed before named args.
			DisplayFancyMessage(ConsoleColor.Blue, message: "Testing...", backgroundColor: ConsoleColor.White);
			// This is OK, all arguments are in the correct order
			DisplayFancyMessage(textColor: ConsoleColor.White, backgroundColor: ConsoleColor.Blue,"Testing...");

			// This is an ERROR, as positional args are listed after named args.
			//DisplayFancyMessage(message: "Testing...", backgroundColor: ConsoleColor.White,ConsoleColor.Blue);

			DisplayFancyMessage2(message: "Hello!");
			DisplayFancyMessage2(backgroundColor: ConsoleColor.Green);
		}

		static void DisplayFancyMessage2(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test Message")
		{
			// Store old colors to restore after message is printed.
			ConsoleColor oldTextColor = Console.ForegroundColor;
			ConsoleColor oldbackgroundColor = Console.BackgroundColor;
			// Set new colors and print message.
			Console.ForegroundColor = textColor;
			Console.BackgroundColor = backgroundColor;
			Console.WriteLine(message);
			// Restore previous colors.
			Console.ForegroundColor = oldTextColor;
			Console.BackgroundColor = oldbackgroundColor;

		}
	}
}
