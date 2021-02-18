using System;

namespace Ex8_MethodParameter_params
{
	class Program
	{
		static int Add2(int x, int y)
		{
			x = 10000;
			y = 88888;
			int ans = x + y;
			return ans;
		}
		static int AddReadOnly(in int x, in int y)
		{
			//Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
			//x = 10000;
			//y = 88888;
			int ans = x + y;
			return ans;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with in *****\n");
			int x = 10;
			int y = 100;

			AddReadOnly(in x, in y);
		}

	}
}
