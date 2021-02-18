using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ex1_IndexerMethod
{
	class PersonCollectionStringIndexerr : IEnumerable
	{
		private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();
		// This indexer returns a person based on a string index.
		public Person this[string name]
		{
			get => (Person)listPeople[name];
			set => listPeople[name] = value;
		}
		public Person this[string name, string key]
		{
			get => (Person)listPeople[name];
			set => listPeople[name] = value;
		}
		public void ClearPeople()
		{ listPeople.Clear(); }
		public int Count => listPeople.Count;
		IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();
	}
}
