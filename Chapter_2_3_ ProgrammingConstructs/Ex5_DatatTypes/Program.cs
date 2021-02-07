using System;
using System.Numerics;

namespace Ex5_DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			bool bo1 = true;
			Boolean bo2 = false;
			bool b03 = new bool(); //set to false

			sbyte sb1= 127;
			SByte sb2 = -128;

			byte b1 = 255;
			Byte b2 = 0;

			short s1 = 32767;
			Int16 s2 = -32768;

			ushort us1 = 65535;
			UInt16 us2 = 0;

			int i1 = 2147483647;
			Int32 i2 = -2147483648;
			int i3 = new int(); //set to 0

			uint ui1 = 4294967295;
			uint ui2 = 0;

			//Digit Separators
			long l1 = 9_223_372_036_854_775_807;
			Int64 l2 = -9_223_372_036_854_775_808;

			ulong ul1 = 18_446_744_073_709_551_615;
			ulong ul2 = 0;

			float f1 = 3.4f;
			Single f2 = 3.4f;

			double d1 = 5.5;
			Double d2 = 5.5;
			double d3 = new double(); //set to 0


			decimal dc1 = 6;
			Decimal dc2 = 6;

			string str1 = "ctis479";
			String str2 = "ctis479";

			object o1 = new object();
			Object o2 = new Object();

			char ch1 = 'a';
			Char ch2 = '\u006A';
			char ch3 = '\x006A';

			int myInt = default;
			Console.WriteLine(myInt);

			DateTime dt = new DateTime(); //set to 1/1/0001 12:00:00 AM


			Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
			Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
			Console.WriteLine("12.ToString() = {0}", 12.ToString());
			Console.WriteLine("12.GetType() = {0}", 12.GetType());
			Console.WriteLine();
			
			Console.WriteLine("{0}.GetHashCode() = {1}", i1, i1.GetHashCode());
			Console.WriteLine("{0}.Equals(23) = {1}", i1, i1.Equals(23));
			Console.WriteLine("{0}.ToString() = {1}",i1, i1.ToString());
			Console.WriteLine("{0}.GetType() = {1}",i1, i1.GetType());
			Console.WriteLine("{0}.GetType() = {1}", ui1, ui1.GetType());
			Console.WriteLine();

			Console.WriteLine("Max of int: {0}", int.MaxValue);
			Console.WriteLine("Min of int: {0}", int.MinValue);
			Console.WriteLine("Max of double: {0}", double.MaxValue);
			Console.WriteLine("Min of double: {0}", double.MinValue);
			Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
			Console.WriteLine("double.PositiveInfinity: {0}",double.PositiveInfinity);
			Console.WriteLine("double.NegativeInfinity: {0}",double.NegativeInfinity);
			Console.WriteLine();

			Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
			Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
			Console.WriteLine();

			char myChar = 'a';
			Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
			Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
			Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
			Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}", char.IsWhiteSpace("Hello There", 6));
			Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
			Console.WriteLine();

			Console.WriteLine("=> Data type PARSING:");
			bool b = bool.Parse("True");
			Console.WriteLine("Value of b: {0}", b);
			double d = double.Parse("99.884");
			Console.WriteLine("Value of d: {0}", d);
			int i = int.Parse("8");
			Console.WriteLine("Value of i: {0}", i);
			char c = Char.Parse("w");
			Console.WriteLine("Value of c: {0}", c);
			Console.WriteLine();

			//bool bl = bool.Parse("Hello"); //EXCEPTION

			if (bool.TryParse("True", out bool bl1))
			{
				Console.WriteLine("Value of b: {0}", bl1);
			}
			else
			{
				Console.WriteLine("Default value of b: {0}", bl1);
			}
			string value = "Hello";
			if (double.TryParse(value, out double db1))
			{
				Console.WriteLine("Value of d: {0}", db1);
			}
			else
			{
				Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value,db1);
		    }
			Console.WriteLine();


			Console.WriteLine("=> Dates and Times:");
			// This constructor takes (year, month, day).
			DateTime dt2 = new DateTime(2015, 10, 17);
			// What day of the month is this?
			Console.WriteLine("The day of {0} is {1}", dt2.Date, dt2.DayOfWeek);
			// Month is now December.
			dt2 = dt2.AddMonths(2);
			Console.WriteLine("Daylight savings: {0}", dt2.IsDaylightSavingTime());
			// This constructor takes (hours, minutes, seconds).
			TimeSpan ts = new TimeSpan(4, 30, 0);
			Console.WriteLine(ts);
			// Subtract 15 minutes from the current TimeSpan and
			// print the result.
			Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

			DateTime dt3 = new DateTime(2015, 8, 10);
			TimeSpan tsres = dt2.Subtract(dt3);
			Console.WriteLine(dt2.ToString()+" - "+dt3.ToString()+" Day difference "+tsres.Days.ToString());

			Console.WriteLine("=> Use BigInteger:");
			BigInteger biggy =BigInteger.Parse("9999999999999999999999999999999999999999999999");
			Console.WriteLine("Value of biggy is {0}", biggy);
			Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
			Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
			BigInteger reallyBig = BigInteger.Multiply(biggy,BigInteger.Parse("8888888888888888888888888888888888888888888"));
			Console.WriteLine("Value of reallyBig is {0}", reallyBig);
			Console.WriteLine();

		
		}
	}
}
