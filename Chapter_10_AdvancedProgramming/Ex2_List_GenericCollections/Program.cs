using System;


using System.Collections.Generic;

namespace Ex2_List_GenericCollections
{
	/*
	2)Generic collections: primarily found in the System.Collections.Generic namespace, type-safe, specify the type
		- Generics provide better performance because they do not result in boxing or
		unboxing penalties when storing value types.
		- Generics are type-safe because they can contain only the type of type you specify
		Generic Class :Dictionary<TKey, TValue>, LinkedList<T>, List<T>, Queue<T>, SortedDictionary<TKey,TValue>, SortedSet<T>, Stack<T>

		System.Collections.Generic Interface:ICollection<T>,IComparer<T>,IDictionary<TKey, TValue>,IEnumerable<T>, IAsyncEnumerable<T>,IEnumerator<T>,IList<T>, ISet<T>
	
	View >Object Browser > Find System.Collections to list the collection list
	*/
	class Program
	{
		static void Main(string[] args)
		{
			// This List<> can hold only Person objects.
			List<Person> morePeople = new List<Person>();

			morePeople.Add(new Person("Frank", "Black", 50));
			Console.WriteLine(morePeople[0]);
			
			// This List<> can hold only integers.
			List<int> moreInts = new List<int>();
			moreInts.Add(10);
			moreInts.Add(2);
			int sum = moreInts[0] + moreInts[1];

			// Compile-time error! Can't add Person object
			// to a list of ints!
			// moreInts.Add(new Person());

			// Init a generic List<> of ints.
			List<int> myGenericList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			List<Point> myListOfPoints = new List<Point>
			{
			 new Point { X = 2, Y = 2 },
			 new Point { X = 3, Y = 3 },
			 new Point { X = 4, Y = 4 }
			};
			foreach (var pt in myListOfPoints)
			{
				Console.WriteLine(pt);
			}

			Person[] arrayOfPeople = morePeople.ToArray();
			foreach (Person p in arrayOfPeople)
			{
				Console.WriteLine("First Names: {0}", p.FirstName);
			}
		}
	}
}
