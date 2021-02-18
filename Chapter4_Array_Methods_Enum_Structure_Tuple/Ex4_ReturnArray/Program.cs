using System;

namespace Ex4_ReturnArray
{
	class Program
	{
		static void PrintArray(int[] myInts)
		{
			for (int i = 0; i < myInts.Length; i++)
			{
				Console.WriteLine("Item {0} is {1}", i, myInts[i]);
			}
		}
		static string[] GetStringArray()
		{
			string[] theStrings = { "Hello", "from", "GetStringArray" };
			return theStrings;
		}
		
		static void Main(string[] args)
		{
			Console.WriteLine("=> Arrays as params and return values.");
			// Pass array as parameter.
			int[] ages = { 20, 22, 23, 0 };
			PrintArray(ages);

			// Get array as return value.
			string[] strs = GetStringArray();
			foreach (string s in strs)
			{
				Console.WriteLine(s);
			}
			Console.WriteLine();
		}
	}
}
