using System;
using System.Collections.Generic;

namespace Ex5_SortedSet
{
	class Program
	{
		static void Main(string[] args)
		{
			SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
			 {
				 new Person {FirstName= "Homer", LastName="Simpson", Age=47},
				 new Person {FirstName= "Marge", LastName="Simpson", Age=45},
				 new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
				 new Person {FirstName= "Bart", LastName="Simpson", Age=8}
			 };
			// Note the items are sorted by age!
			foreach (Person p in setOfPeople)
			{
				Console.WriteLine(p);
			}
			
			Console.WriteLine();
			// Add a few new people, with various ages.
			setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 1 });
			setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 32 });
			// Still sorted by age!
			foreach (Person p in setOfPeople)
			{
				Console.WriteLine(p);
			}
		}
	}
}
