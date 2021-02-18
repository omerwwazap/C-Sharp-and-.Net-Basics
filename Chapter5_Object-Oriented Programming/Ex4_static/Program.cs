using System;

namespace Ex4_Static
{
	class Program
	{
		static void Main(string[] args)
		{
			SavingsAccount s1 = new SavingsAccount(50);
			SavingsAccount s2 = new SavingsAccount(100);
			SavingsAccount s3 = new SavingsAccount(10000.75);

			Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

			// This is just fine.
			TimeUtilClass.PrintDate();
			TimeUtilClass.PrintTime();
			// Compiler error! Can't create instance of static classes!
			//TimeUtilClass u = new TimeUtilClass();

		}

	}
}
