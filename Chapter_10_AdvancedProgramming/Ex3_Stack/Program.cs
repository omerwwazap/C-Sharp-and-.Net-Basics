using System;
using System.Collections.Generic;

namespace Ex3_Stack
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack<Person> stackOfPeople = new Stack<Person>();
			stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
			stackOfPeople.Push(new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 });
			stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 });
			// Now look at the top item, pop it, and look again.
			Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
			Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
			Console.WriteLine("\nFirst person is: {0}", stackOfPeople.Peek());
			Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
			Console.WriteLine("\nFirst person item is: {0}", stackOfPeople.Peek());
			Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
			try
			{
				Console.WriteLine("\nnFirst person is: {0}", stackOfPeople.Peek());
				Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
			}
			catch (InvalidOperationException ex)
			{
				Console.WriteLine("\nError! {0}", ex.Message);
			}
		}
	}
}
