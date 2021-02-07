using System;

namespace Ex7_NarrowingWideningDataType
{
	class Program
	{
		static void Main(string[] args)
		{
			//Widening
			short numb1 = 9, numb2 = 10;
			Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1, numb2));
			Console.ReadLine();

			byte myByte = 0;
			int myInt = 200;
			myByte = (byte)myInt; //narrowing
		}
		static int Add(int x, int y)
		{
			return x + y;
		}
	}
}
