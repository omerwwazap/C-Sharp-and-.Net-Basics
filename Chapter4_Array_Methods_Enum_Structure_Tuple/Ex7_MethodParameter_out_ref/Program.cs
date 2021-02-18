using System;

namespace Ex7_MethodParameter_out_ref
{
	class Program
	{
		// Value type arguments are passed by value by default.
		static int Add(int x, int y)
		{
			int ans = x + y;
			// Caller will not see these changes
			// as you are modifying a copy of the
			// original data.
			x = 10000;
			y = 88888;
			return ans;
		}
		//Output parameters DO NOT need to be initialized before they are passed to the method..
		static void Add(int x, int y, out int ans)
		{
			ans = x + y;
		}
		// Returning multiple output parameters.
		static void FillTheseValues(out int a, out string b, out bool c)
		{
			a = 9;
			b = "Enjoy your string.";
			c = true;
		}

		
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Methods *****\n");
			// Pass two variables in by value.
			int x = 9, y = 10;
			Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
			Console.WriteLine("Answer is: {0}", Add(x, y));
			Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
			Console.WriteLine();

			int ans; //Not initialized, its value wil be assigned through method
			Add(90, 90, out ans);
			Add(90, 90, out int answ);
			Console.WriteLine("90 + 90 = {0}", ans);
			Console.WriteLine("90 + 90 = {0}", answ);
			Console.WriteLine();

			FillTheseValues(out int i, out string str, out bool b);
			Console.WriteLine("Int is: {0}", i);
			Console.WriteLine("String is: {0}", str);
			Console.WriteLine("Boolean is: {0}", b);
			Console.WriteLine();

			//This only gets the value for a, and ignores the other two parameters
			FillTheseValues(out int a, out _, out _);
			
		}
	}
}
