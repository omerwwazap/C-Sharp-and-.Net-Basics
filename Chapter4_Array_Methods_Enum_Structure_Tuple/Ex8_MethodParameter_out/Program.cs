using System;

namespace Ex8_MethodParameter_out
{
	class Program
	{
		// Reference parameters.
		//Reference parameters MUST BE  initialized before they are passed to the method. 
		public static void SwapStrings(ref string s1, ref string s2)
		{
			string tempStr = s1;
			s1 = s2;
			s2 = tempStr;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Methods *****\n");
		
			Console.WriteLine("***** ref usage *****");
			string str1 = "Flip";
			string str2 = "Flop";
			Console.WriteLine("Before: {0}, {1} ", str1, str2);
			SwapStrings(ref str1, ref str2);
			Console.WriteLine("After: {0}, {1} ", str1, str2);
			Console.WriteLine();

			
		}
	}
}
