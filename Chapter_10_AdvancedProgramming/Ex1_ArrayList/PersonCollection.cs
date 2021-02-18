using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;

namespace Ex1_ArrayList
{
	// IEnumerable interface, which allows a foreach-like iteration over each contained item.
	class PersonCollection: IEnumerable
	{
		private ArrayList arPeople = new ArrayList();

		// Cast for caller.
		public Person GetPerson(int pos) => (Person)arPeople[pos];
		// Insert only Person objects.
		public void AddPerson(Person p) => arPeople.Add(p);

		/*
		public void AddPerson(Person p){
		{ 
			arPeople.Add(p); 
		}
		*/
		public void ClearPeople(){ arPeople.Clear(); }
		public int Count => arPeople.Count;
	
		// Foreach enumeration support.
		IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();

		public static void UsePersonCollection()
		{
			Console.WriteLine("***** Custom Person Collection *****\n");
			PersonCollection myPeople = new PersonCollection();
			myPeople.AddPerson(new Person("Homer", "Simpson", 40));
			myPeople.AddPerson(new Person("Marge", "Simpson", 38));
			myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
			myPeople.AddPerson(new Person("Bart", "Simpson", 7));
			myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
			// This would be a compile-time error!
			// myPeople.AddPerson(new Car());
			foreach (Person p in myPeople)
				Console.WriteLine(p);
		}

	}
}
