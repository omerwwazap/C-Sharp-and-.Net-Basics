using System;

namespace Ex8_BuildInFuncDelegate
{
	/*
	If you want to point to a method that does have a return value 
	(and don’t want to bother writing the custom delegate yourself), 
	you can use Func<>
	Func<> can save you the step of manually defining a custom delegate
    Func<> delegates, including the parallel programming framework and LINQ.
	*/
	class Program
	{
		static void Main(string[] args)
		{
			Func<int, int, int> funcTarget = Add;
			//funcTarget += Add2;
			int result = funcTarget.Invoke(40, 40);
			Console.WriteLine("40 + 40 = {0}", result);

			Func<int, int, string> funcTarget2 = SumToString;
			string sum = funcTarget2(90, 300);
			Console.WriteLine(sum);
		}
		// Target for the Func<> delegate.
		static int Add(int x, int y)
		{
			return x + y;
		}
		static int Add2(int x, int y)
		{
			return x + y+2;
		}
		static string SumToString(int x, int y)
		{
			return (x + y).ToString();
		}
	}
}
