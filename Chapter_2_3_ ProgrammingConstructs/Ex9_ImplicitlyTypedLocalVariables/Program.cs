using System;
using System.Linq;

namespace Ex9_ImplicitlyTypedLocalVariables
{
	class Program
	{
		// Error! var cannot be used as field data!
		//private var myInt = 10;

		static void Main(string[] args)
		{
			// Explicitly typed local variables
			// are declared as follows:
			// dataType variableName = initialValue;
			int myInt = 0;
			bool myBool = true;
			string myString = "Time, marches on...";

			// Implicitly typed local variables
			// are declared as follows:
			// var variableName = initialValue;
		
			// Implicitly typed numeric variables.
			var myUInt = 0u;
			var vmyInt = 0;
			var myLong = 0L;
			var myDouble = 0.5;
			var myFloat = 0.5F;
			var myDecimal = 0.5M;
			// Print out the underlying type.
			Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
			Console.WriteLine("myInt is a: {0}", vmyInt.GetType().Name);
			Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
			Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
			Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
			Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);

			// Error! Must assign a value!
			//var myData;

			// Error! Must assign value at exact time of declaration!
			//var myInt;
			//myInt = 0;

			// Error! Can't assign null as initial value!
			//var myObj = null;

			// The compiler knows "s" is a System.String.
			var s = "This variable can only hold string data!";
			s = "This is fine...";
			// Can invoke any member of the underlying type.
			string upper = s.ToUpper();
			// Error! Can't assign numerical data to a string!
			//s = 44;

			

		}
		// Error! var cannot be used as a return value
		// or parameter type!
		//public var MyMethod(var x, var y) { }
		static int GetAnInt()
		{
			var retVal = 9;
			return retVal;
		}
	}
}
