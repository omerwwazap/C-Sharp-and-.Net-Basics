using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9_Override
{
	class Person
	{
		public string FirstName { get; set; } = "";
		public string LastName { get; set; } = "";
		public int Age { get; set; }
		public string SSN { get; } = "";
		public Person(string fName, string lName, int personAge, string ssn)
		{
			FirstName = fName;
			LastName = lName;
			Age = personAge;
			SSN = ssn;
		}
		public Person() { }
		public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age:{Age}]";
		public override bool Equals(object obj)
		{
			if (!(obj is Person temp))
			{
				return false;
			}
			if (temp.FirstName == this.FirstName
			&& temp.LastName == this.LastName
			&& temp.Age == this.Age)
			{
				return true;
			}
			return false;
		}
		public override int GetHashCode() => SSN.GetHashCode();
		// or Return a hash code based on the person's ToString() value.
		//public override int GetHashCode() => ToString().GetHashCode();
	}
}
