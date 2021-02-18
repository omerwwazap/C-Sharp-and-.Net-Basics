using System;
using System.Collections.Generic;
using System.Text;


using static System.Console;
using static System.DateTime;


namespace Ex4_Static
{
	// Static classes can only contain static members!
	static class TimeUtilClass
	{
		public static void PrintTime()
		=> Console.WriteLine(DateTime.Now.ToShortTimeString());
		public static void PrintDate()
		=> Console.WriteLine(DateTime.Today.ToShortDateString());

		public static void PrintTime2()=> WriteLine(Now.ToShortTimeString());
		public static void PrintDate2()=> WriteLine(Today.ToShortDateString());
	}
}
