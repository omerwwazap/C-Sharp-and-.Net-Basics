using System;

namespace Ex14_Enum
{
	// A custom enumeration.
	enum EmpTypeEnum
	{
		Manager, // = 0
		Grunt, // = 1
		Contractor, // = 2
		VicePresident // = 3
	}

	// Begin with 102.
	enum EmpTypeEnum2
	{
		Manager = 102,
		Grunt, // = 103
		Contractor, // = 104
		VicePresident // = 105
	}
	// Elements of an enumeration need not be sequential!
	enum EmpType
	{
		Manager = 10,
		Grunt = 1,
		Contractor = 100,
		VicePresident = 9
	}

	// Compile-time error! 999 is too big for a byte!
	//enum EmpTypeEnum : byte
	//{
	//	Manager = 10,
	//	Grunt = 1,
	//	Contractor = 100,
	//	VicePresident = 999
	//}
	class Program
	{
		
		static void Main(string[] args)
		{
			EmpTypeEnum emp = EmpTypeEnum.Contractor;
			AskForBonus(emp);

			// Print storage for the enum.
			Console.WriteLine("Information about {0}", emp.GetType().Name);
			Console.WriteLine("EmpTypeEnum uses a {0} for storage",Enum.GetUnderlyingType(emp.GetType()));
			Console.WriteLine("emp is a {0}.", emp.ToString());
			Console.WriteLine("emp is {0}", (int)emp);

			Array enumData = Enum.GetValues(emp.GetType());
			for (int i = 0; i < enumData.Length; i++)
			{
				Console.WriteLine("Name: {0}, Value: {0:D}",enumData.GetValue(i));
			}
			Console.WriteLine();

			// These types are enums in the System namespace.
			DayOfWeek day = DayOfWeek.Monday;
			ConsoleColor cc = ConsoleColor.Gray;

			Console.WriteLine("Information about {0}", day.GetType().Name);
			Console.WriteLine("day is a {0}.", day.ToString());

			Console.WriteLine("Information about {0}", cc.GetType().Name);
			Console.WriteLine("ConsoleColor is a {0}.", cc.ToString());
		}
		// Enums as parameters.
		static void AskForBonus(EmpTypeEnum e)
		{
			switch (e)
			{
				case EmpTypeEnum.Manager:
					Console.WriteLine("How about stock options instead?");
					break;
				case EmpTypeEnum.Grunt:
					Console.WriteLine("You have got to be kidding...");
					break;
				case EmpTypeEnum.Contractor:
					Console.WriteLine("You already get enough cash...");
					break;
				case EmpTypeEnum.VicePresident:
					Console.WriteLine("VERY GOOD, Sir!");
					break;
			}
		}
	}
}
