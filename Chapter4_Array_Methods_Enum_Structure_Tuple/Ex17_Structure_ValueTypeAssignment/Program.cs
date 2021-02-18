using System;

namespace Ex17_Structure_ValueTypeAssignment
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Assigning value types\n");
			Point p1 = new Point(10, 10);
			Point p2 = p1;

			// Print both points.
			p1.Display();
			p2.Display();

			// Change p1.X and print again. p2.X is not changed.
			p1.X = 100;
			Console.WriteLine("\n=> Changed p1.X\n");
			p1.Display();
			p2.Display();

			Console.WriteLine("Assigning reference types\n");
			PointRef pr1 = new PointRef(10, 10);
			PointRef pr2 = pr1;
			// Print both point refs.
			pr1.Display();
			pr2.Display();
			// Change p1.X and print again.
			pr1.X = 100;
			Console.WriteLine("\n=> Changed p1.X\n");
			pr1.Display();
			pr2.Display();

			Person fred = new Person("Fred", 12);
			Console.WriteLine("\nBefore by value call, Person is:");
			fred.Display();
			SendAPersonByValue(fred);
			Console.WriteLine("\nAfter by value call, Person is:");
			fred.Display();

			Person mel = new Person("Mel", 23);
			Console.WriteLine("Before by ref call, Person is:");
			mel.Display();
			SendAPersonByReference(ref mel);
			Console.WriteLine("After by ref call, Person is:");
			mel.Display();
		}
		static void SendAPersonByValue(Person p)
		{
			// Change the age of "p"?
			p.personAge = 99;
			// Will the caller see this reassignment?
			p = new Person("Nikki", 99);
		}

		static void SendAPersonByReference(ref Person p)
		{
			// Change some data of "p".
			p.personAge = 555;
			p = new Person("Nikki", 999);
		}
	}
}
