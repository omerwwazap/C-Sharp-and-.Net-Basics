using System;

namespace Ex2_MultidimentionalArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Rectangular multidimensional array.");
			// A rectangular MD array.
			int[,] myMatrix;
			myMatrix = new int[3, 4];
			// Populate (3 * 4) array.
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					myMatrix[i, j] = i * j;
				}
			}
			// Print (3 * 4) array.
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 4; j++)
				{
					Console.Write(myMatrix[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();


		}
	}
}
