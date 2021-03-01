using System;
using System.Collections.Generic;

namespace Ex12_LambdaExpression
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

			// Call FindAll() using traditional delegate syntax.
			Predicate<int> callback = IsEvenNumber; //public delegate bool Predicate<T>(T obj);
			List<int> evenNumbers = list.FindAll(callback); //FindAll() is a generic delegate 
			
			Console.WriteLine("Here are your even numbers:");
			foreach (int evenNumber in evenNumbers)
			{
				Console.Write("{0}\t", evenNumber);
			}
			/*******************************************/
			/*
			use anonymous method,your code would clean up considerable	
			In this case, rather than directly creating a Predicate<T> delegate object and then authoring a standalone method, you are able to inline a method anonymously. While this is a step in the right direction, you
			are still required to use the delegate keyword (or a strongly typed Predicate<T>), and you must ensure that
			the parameter list
			*/
			List<int> evenNumbers2 = list.FindAll(delegate (int i) { return (i % 2) == 0; });

			Console.WriteLine("Here are your even numbers:");
			foreach (int evenNumber in evenNumbers2)
			{
				Console.Write("{0}\t", evenNumber);
			}
			/*******************************************/
			/*
			-Lambda expressions can be used to simplify the call to FindAll() even more.
			-Lambda expressions can be used anywhere you would have used an anonymous 
			method or a strongly typed delegate
			-C# compiler translates the expression into a standard anonymous method 
			making use of the Predicate<T> delegate type 
			 */
			List<int> evenNumbers3 = list.FindAll(i => (i % 2) == 0);
			
			Console.WriteLine("Here are your even numbers:");
			foreach (int evenNumber in evenNumbers3)
			{
				Console.Write("{0}\t", evenNumber);
			}

			// Now, explicitly state the parameter type.
			List<int> evenNumbers4 = list.FindAll((int i) => (i % 2) == 0);

			//you can always wrap the parameter list within parentheses, leaving you with this expression:
			List<int> evenNumbers5 = list.FindAll((i) => (i % 2) == 0);

			// Now, wrap the expression as well.
			List<int> evenNumbers6 = list.FindAll((i) => ((i % 2) == 0));

		}
		// Target for the Predicate<> delegate.
		static bool IsEvenNumber(int i)
		{
			// Is it an even number?
			return (i % 2) == 0;
		}
	}
}
