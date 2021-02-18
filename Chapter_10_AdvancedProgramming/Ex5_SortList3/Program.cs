using System;
using System.Collections.Generic;

namespace Ex5_SortList3
{
	class Program
	{
		static void Main(string[] args)
		{

			List<Person> listOfPeople = new List<Person>()
			 {
				 new Person {FirstName= "Homer", LastName="Simpson", Age=47},
				 new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
				 new Person {FirstName= "Marge", LastName="Simpson", Age=45},
				 new Person {FirstName= "Bart", LastName="Simpson", Age=8}
			 };
			// Note the items are not sorted by age!
			foreach (Person p in listOfPeople)
			{
				Console.WriteLine(p);
			}
			// Call Sort on the list. This will use the
			// default comparer, which is the Compare method
			// implemented on Part.
			listOfPeople.Sort();

			Console.WriteLine("Sorted list(age)");

			// Note the items are sorted by age!
			foreach (Person p in listOfPeople)
			{
				Console.WriteLine(p);
			}
		}
	}
}
