using System;


namespace Ex3_ExtentionMethods
{
	/*
	 extension methods allow you to add new methods or properties to a class or structure, without modifying the original type in any direct manner. S
	 */
	class Program
	{
		
		static void Main(string[] args)
		{
			// The int has assumed a new identity!
			int myInt = 12345678;
			myInt.DisplayDefiningAssembly();
			
			// So has the DataSet!
			System.Data.DataSet d = new System.Data.DataSet();
			d.DisplayDefiningAssembly();
			
			// Use new integer functionality.
			Console.WriteLine("Value of myInt: {0}", myInt);
			Console.WriteLine("Reversed digits of myInt: {0}",
			myInt.ReverseDigits());

			// System.Array implements IEnumerable!
			string[] data = { "Wow", "this", "is", "sort", "of", "annoying", "but", "in", "a", "weird", "way", "fun!"};
			data.PrintDataAndBeep();
		}
	}
}
