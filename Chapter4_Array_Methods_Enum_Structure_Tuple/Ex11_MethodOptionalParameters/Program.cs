using System;

namespace Ex11_MethodOptionalParameters
{
	class Program
	{
		static void EnterLogData(string message, string owner = "Programmer")
		{
			Console.Beep();
			Console.WriteLine("Error: {0}", message);
			Console.WriteLine("Owner of Error: {0}", owner);

		}
		static void Main(string[] args)
		{
			EnterLogData("Oh no! Grid can't find data");
			EnterLogData("Oh no! I can't find the payroll data", "CFO");
		}

		// Error! The default value for an optional arg must be known
		// at compile time!
		//static void EnterLogData(string message, string owner = "Programmer", DateTime timeStamp =DateTime.Now)
		//{
		//	Console.Beep();
		//	Console.WriteLine("Error: {0}", message);
		//	Console.WriteLine("Owner of Error: {0}", owner);
		//	Console.WriteLine("Time of Error: {0}", timeStamp);
		//}
	}
}
