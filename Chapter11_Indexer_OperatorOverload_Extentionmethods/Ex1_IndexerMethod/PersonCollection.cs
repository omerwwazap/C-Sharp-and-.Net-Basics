using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;
using System.Data;

namespace Ex1_IndexerMethod
{
	// IEnumerable interface, which allows a foreach-like iteration over each contained item.
	class PersonCollection: IEnumerable
	{
		private ArrayList arPeople = new ArrayList();

		// Custom indexer for this class.
		// indexers allow you to manipulate the internal collection of subobjects just like a standard array.
		public Person this[int index]
		{
			get => (Person)arPeople[index];
			set => arPeople.Insert(index, value);
		}
		
		/*
		public Person GetPerson(int pos) => (Person)arPeople[pos];
		// Insert only Person objects.
		public void AddPerson(Person p) => arPeople.Add(p);
		*/

		public void ClearPeople(){ arPeople.Clear(); }
		public int Count => arPeople.Count;
	
		// Foreach enumeration support.
		IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();

	}
}
