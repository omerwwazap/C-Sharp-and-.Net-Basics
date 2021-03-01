using System;

namespace Ex7_BuildInDelegates
{
	/*
	 The generic Action<> delegate is defined in the System namespace,
	and you can use this generic delegate to “point to” a method that takes 
	up to 16 arguments and returns void.
	
	using the Action<> delegate saves you the bother of defining a custom delegate type.
	Action<> delegates, including the parallel programming framework and LINQ.
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Action<string, ConsoleColor, int> actionTarget = DisplayMessage;
			
			actionTarget("Action Message!", ConsoleColor.Yellow, 5);
		}
		static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
		{
			// Set color of console text.
			ConsoleColor previous = Console.ForegroundColor;
			Console.ForegroundColor = txtColor;
			for (int i = 0; i < printCount; i++)
			{
				Console.WriteLine(msg);
			}
			// Restore color.
			Console.ForegroundColor = previous;
		}
	}
}
