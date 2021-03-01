using System;

namespace Ex1_Delegate
{
	/*
	 the .NET Core delegate type is a type-safe object that
	 “points to” a method or a list of methods that can be invoked at a later time. 
	 a delegate maintains three important pieces of information:
		- The address of the method on which it makes calls
		- The parameters (if any) of this method
		- The return type (if any) of this method
	
	After a delegate object has been created and given the necessary 
	information, it may dynamically invoke the method(s) it points to at runtime.
	
	.NET Core delegates can point to either static or instance methods.
	 */

	//STEP 1: Defining a Delegate Type
	/*
	Use the delegate keyword. The name of your delegate type can be 
	whatever you desire. However, you must define the delegate to match the 
	signature of the method(s) it will point to. 
	
	This delegate can point to any method, taking two integers and returning an integer.
	 */
	public delegate int BinaryOp(int x, int y);

	public class SimpleMath
	{
		//STEP 2: implement functions which will be pointed by del
		public static int Add(int x , int y)
		{
			Console.WriteLine(x+" + "+y+" = "+(x+y));
			return x+y;
		}
		public static int Subtract(int x, int y) => x - y;
		public static int SquareNumber(int a) => a * a;
		public int Multiply(int a, int b) => a * b;


	}

	class Program
	{
		static void Main(string[] args)
		{
			//STEP 3: Create delegate object that will points to method(s)
			BinaryOp b = new BinaryOp(SimpleMath.Add);
			// Add is the target method, only pass the name of the method,
			// Add is static method so SimpleMath.Add 

			b += SimpleMath.Subtract;

			SimpleMath sm = new SimpleMath();

			b += sm.Multiply;

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
				int res = (int)d.DynamicInvoke(10, 20);
				Console.WriteLine(res);
			}
		}
	}
}
