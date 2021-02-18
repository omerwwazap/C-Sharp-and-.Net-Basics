using System;

namespace Ex1_Array
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] myInts = new int[3];
			
			myInts[0] = 100;
			myInts[1] = 200;
			myInts[2] = 300;
			// Now print each value.
			foreach (int i in myInts)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine();
			
			string[] booksOnDotNet = new string[100];
			
			Console.WriteLine("=> Array Initialization.");
			// Array initialization syntax using the new keyword.
			string[] stringArray = new string[]{ "one", "two", "three" };
			Console.WriteLine("stringArray has {0} elements", stringArray.Length);
			
			bool[] boolArray = { false, false, true };
			Console.WriteLine("boolArray has {0} elements", boolArray.Length);
			// Array initialization with new keyword and size.
			
			int[] intArray = new int[4] { 20, 22, 23, 0 };
			Console.WriteLine("intArray has {0} elements", intArray.Length);
			Console.WriteLine();


			Console.WriteLine("=> Implicit Array Initialization.");
			// a is really int[].
			var a = new[] { 1, 10, 100, 1000 };
			Console.WriteLine("a is a: {0}", a.ToString());
			// b is really double[].
			var b = new[] { 1, 1.5, 2, 2.5 };
			Console.WriteLine("b is a: {0}", b.ToString());
			// c is really string[].
			var c = new[] { "hello", null, "world" };
			Console.WriteLine("c is a: {0}", c.ToString());
			Console.WriteLine();

			// Error! Mixed types!
			//var d = new[] { 1, "one", 2, "two", false };

			Console.WriteLine("=> Array of Objects.");
			// An array of objects can be anything at all.
			object[] myObjects = new object[4];
			myObjects[0] = 10;
			myObjects[1] = false;
			myObjects[2] = new DateTime(1969, 3, 24);
			myObjects[3] = "Form & Void";
			foreach (object obj in myObjects)
			{
				// Print the type and value for each item in array.
				Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
			}
			Console.WriteLine();
		}
	}
}
