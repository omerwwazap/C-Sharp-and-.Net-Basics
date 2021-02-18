using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ex5_SortList3
{
	class Person: IComparable<Person>
	{
		public int Age { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Person() { }
		public Person(string firstName, string lastName, int age)
		{
			Age = age;
			FirstName = firstName;
			LastName = lastName;
		}
		public override string ToString()
		{
			return $"Name: {FirstName} {LastName}, Age: {Age}";
		}

		public int CompareTo([AllowNull] Person other)
		{
			//return other.Age - Age;//for descending sort
			return Age - other.Age;//for ascending sort
		}
	}
}
