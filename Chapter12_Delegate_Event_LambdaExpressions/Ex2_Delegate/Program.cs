using System;

namespace Ex2_Delegate
{
	public delegate int BinaryOp(int x, int y);

	public class SimpleMath
	{
		//STEP 2: implement functions which will be pointed by del
		public static int Add(int x, int y)
		{
			return x + y;
		}
		public static int Subtract(int x, int y) => x - y;
		public static int SquareNumber(int a) => a * a;
		public int Multiply(int x, int y) => x * y;


	}
	class Program
	{
		static void Main(string[] args)
		{
			SimpleMath sm = new SimpleMath();

			BinaryOp b = new BinaryOp(sm.Multiply);
			// Add is the target method, only pass the name of the method,
			// Multiply is member method and it is called by using object sm.Multiply(10,20)

			//STEP4: Invoke the methods by using delegate object
			Console.WriteLine("Add result " + b.Invoke(10, 20));
			Console.WriteLine("Add result " + b(10, 20));

			// Compiler error! Method does not match delegate pattern!
			//BinaryOp b2 = new BinaryOp(SimpleMath.SquareNumber);


			DisplayDelegateInfo(b);

		}
		static void DisplayDelegateInfo(Delegate delObj)
		{
			// Print the names of each member in the
			// delegate's invocation list.
			foreach (Delegate d in delObj.GetInvocationList())
			{
				Console.WriteLine("Method Name: {0}, Type Name: {1} ", d.Method, d.Target);
			}
		}
	}
}
