using System;
using System.Collections.Generic;
using System.Text;

namespace Ex5_SortList4
{
	class SortPeopleByAge : IComparer<Person>
	{
		public int Compare(Person firstPerson, Person secondPerson)
		{
			return firstPerson.Age - secondPerson.Age;
		}
	}
}
