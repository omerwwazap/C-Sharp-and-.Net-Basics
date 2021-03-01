using System;

namespace EX16_LambdaExpressionBodiedmembers
{
	class SimpleMath
	{
		public int Add(int x, int y) => x + y;
		public void PrintSum(int x, int y) => Console.WriteLine(x + y);
	}
	class Program
	{
		static void Main(string[] args)
		{
			SimpleMath sm = new SimpleMath();
			sm.PrintSum(3,5);
		}
	}
}
