using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ex5_SortList4
{
	class Person
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

	}
}
