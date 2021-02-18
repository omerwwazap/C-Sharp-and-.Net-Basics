using System;
using System.Collections.Generic;
using System.Text;

namespace Ex4_Static
{
	class SavingsAccount
	{
		// Instance-level data.
		public double currBalance;
		// A static point of data.
		public static double currInterestRate = 0.04;
		// A static constructor!
		static SavingsAccount()
		{
			
			Console.WriteLine("In static ctor!");
			Console.WriteLine(currInterestRate);
			currInterestRate = 0.05;
		}

		public SavingsAccount(double balance)
		{
			currBalance = balance;
		}
		// Static members to get/set interest rate.
		public static void SetInterestRate(double newRate) => currInterestRate = newRate;
		public static double GetInterestRate() => currInterestRate;

	}
}
