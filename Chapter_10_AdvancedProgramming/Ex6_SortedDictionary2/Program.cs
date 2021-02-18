using System;
using System.Collections.Generic;

namespace Ex6_SortedDictionary2
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedDictionary<string, Person> peopleB = new SortedDictionary<string, Person>()
			 {
				{ "Marge", new Person { FirstName = "Marge", LastName = "Simpson", Age = 45 } },
				{ "Lisa", new Person { FirstName = "Lisa", LastName = "Simpson", Age = 9 } }
				{ "Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 } },
			 };
			
			// the elements are retrieved as KeyValuePair objects.
			Console.WriteLine();
			// Display the key/value pairs 
			foreach (KeyValuePair<string, Person> pair in peopleB)
			{
				Console.WriteLine("Key: {0} and Value: {1}", pair.Key, pair.Value);
			}
		}
	}
}
