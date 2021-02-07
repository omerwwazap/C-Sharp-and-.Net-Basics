using System;

namespace Ex8_Checked
{
	class Program
	{
		static void Main(string[] args)
		{
			byte b1 = 100;
			byte b2 = 250;
			byte sum = (byte)Add(b1, b2);
			// sum should hold the value 350. However, we find the value 94!
			Console.WriteLine("sum = {0}", sum);

			try
			{
				sum = checked((byte)Add(b1, b2));
				Console.WriteLine("sum = {0}", sum);
			}
			catch (OverflowException ex)
			{
				Console.WriteLine(ex.Message);
			}

			try
			{
				checked
				{
					sum = (byte)Add(b1, b2);
					Console.WriteLine("sum = {0}", sum);
				}
			}
			catch (OverflowException ex)
			{
				Console.WriteLine(ex.Message);
			}

			// Assuming /checked is enabled,
			// this block will not trigger
			// a runtime exception.
			unchecked
			{
				sum = (byte)(b1 + b2);
				Console.WriteLine("sum = {0} ", sum);
			}


		}
		static int Add(int x, int y)
		{
			return x + y;
		}
	}
}
