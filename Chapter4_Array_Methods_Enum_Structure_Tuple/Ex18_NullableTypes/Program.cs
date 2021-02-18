using System;

namespace Ex18_NullableTypes
{
	class Program
	{
		// Nullable data field.
		public int? numericValue = null;
		public bool? boolValue = true;

		static void Main(string[] args)
		{
			// Compiler errors!
			// Value types cannot be set to null!
			//bool myBool = null;
			//int myInt = null;

			// Define some local nullable variables.
			int? nullableInt = 10;
			double? nullableDouble = 3.14;
			bool? nullableBool = null;
			char? nullableChar = 'a';
			int?[] arrayOfNullableInts = new int?[10];

			Nullable<int> _nullableInt = 10;
			Nullable<double> _nullableDouble = 3.14;
			Nullable<bool> _nullableBool = null;
			Nullable<char> _nullableChar = 'a';
			Nullable<int>[] _arrayOfNullableInts = new Nullable<int>[10];

		    int numofrecords = GetRecordsFromDatabase() ?? 100;
			Console.WriteLine("Number of records {0}", numofrecords);


		}
		// Note the nullable return type.
		public int? GetIntFromDatabase() { return numericValue; }
		// Note the nullable return type.
		public bool? GetBoolFromDatabase() { return boolValue; }

		static int? GetRecordsFromDatabase()
		{
			//return null;
			return 5;
		}
	}
}
