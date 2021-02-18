using System;
using System.Collections;

namespace Ex1_ArrayList
{

	/*
	
	1)Nongeneric collections: primarily found in the System.Collections namespace, designed to operate on System.Object type
		System.Collections Class: ArrayList,BitArray, Hashtable, Queue, SortedList, Stack
		System.Collections Interface: ICollection, ICloneable,IDictionary, IEnumerable, IEnumerator, IList
		System.Collections.Specialized Type: HybridDictionary, ListDictionary, StringCollection,BitVector32 
		
		some poorly performing code: especially when you are manipulating numerical data (e.g., value types). the CoreCLR must perform a number of memory transfer operations
		when you store structures in any nongeneric collection class prototyped to operate on System.Objects,
		which can hurt runtime execution speed. 
		
		Boxing : process of assigning value type to Object (int value type stored in an ArrayList). 
		During boxing, CLR allocates a new object on the heap and copies the value type vlaue into that instance. 
		new allocated heap based object
		int myInt = 25;
			// Box the int into an object reference.
				object boxedInt = myInt;

			// Value types are automatically boxed when
			// passed to a method requesting an object.
				ArrayList myInts = new ArrayList();
				myInts.Add(10);
				myInts.Add(20);
				myInts.Add(35);

	    Unboxing: converting the value held in the object reference back to corresponding value type on the stack.
	    CLR copies the value back to local stack based variable
			// Unbox the reference back into a corresponding int.
				int unboxedInt = (int)boxedInt;

			// Unboxing occurs when an object is converted back to
			// stack-based data.
			int i = (int)myInts[0];
	
	2)Generic collections: primarily found in the System.Collections.Generic namespace, type-safe, specify the type

	 */
	class Program
	{

		static void Main(string[] args)
		{
			//In some cases, you will require an extremely flexible container that can hold literally anything
			///The ArrayList can hold anything
			ArrayList strArray = new ArrayList(); 

			strArray.AddRange(new string[] { "First", "Second", "Third" });
			strArray.Add(true);
			strArray.Add(66);

			// Show number of items in ArrayList.
			Console.WriteLine("This collection has {0} items.", strArray.Count);
			Console.WriteLine();
			
			// Add a new item and display current count.
			strArray.Add("Fourth!");
			Console.WriteLine("This collection has {0} items.", strArray.Count);
			
			// Display contents.
			foreach (object s in strArray)
			{
				Console.WriteLine("Entry: {0}", s); 
			}
			/*
			foreach (string s in strArray)
			{
				Console.WriteLine("Entry: {0}", s);
			}
			*/

			PersonCollection.UsePersonCollection();

			// Init an ArrayList with numerical data.
			ArrayList myList = new ArrayList { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		}
	}
}
