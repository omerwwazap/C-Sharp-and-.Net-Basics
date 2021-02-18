using System;

namespace Ex5_SystemArrayBaseClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Working with System.Array.");
			// Initialize items at startup.
			string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy", "The Cure"	, "Joy Division" };
			
			// Print out names in declared order.
			Console.WriteLine("-> Here is the array:");
			for (int i = 0; i < gothicBands.Length; i++)
			{
				// Print a name.
				Console.Write(gothicBands[i] + ", ");
			}
			Console.WriteLine("\n");
			
			
			Console.WriteLine("-> Here is the array:");
			foreach (var itm in gothicBands[0..2])
			{
				// Print a name
				Console.Write(itm + ", ");
			}
			Console.WriteLine("\n");

			Console.WriteLine("-> Here is the array:");
			Range r = 0..2; //the end of the range is exclusive
			foreach (var itm in gothicBands[r])
			{
				// Print a name
				Console.Write(itm + ", ");
			}
			Console.WriteLine("\n");

			Index idx1 = 0;
			Index idx2 = 2;
			r = idx1..idx2; //the end of the range is exclusive
			foreach (var itm in gothicBands[r])
			{
				// Print a name
				Console.Write(itm + ", ");
			}
			Console.WriteLine("\n");


			// Reverse them...
			Array.Reverse(gothicBands);
			Console.WriteLine("-> The reversed array");
			
			// ... and print them.
			for (int i = 0; i < gothicBands.Length; i++)
			{
				// Print a name.
				Console.Write(gothicBands[i] + ", ");
			}
			Console.WriteLine("\n");

			Console.WriteLine("-> Here is the sorted array:");
			//Sort the array
			Array.Sort(gothicBands);
			for (int i = 0; i < gothicBands.Length; i++)
			{
				// Print a name.
				Console.Write(gothicBands[i] + ", ");
			}
			Console.WriteLine();


			// Clear out all but the first member.
			//This static method sets a range of elements in the array to empty values (0 for numbers, null for object references, false for Booleans).
			Console.WriteLine("-> Cleared ..");
			Array.Clear(gothicBands, 1, 2);
			for (int i = 0; i < gothicBands.Length; i++)
			{
				// Print a name.
				Console.Write(gothicBands[i] + ", ");
			}
			Console.WriteLine();



			


		}
	}
}
