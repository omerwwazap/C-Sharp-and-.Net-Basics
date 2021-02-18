using System;

namespace Ex10_MethodParameter_params
{
	class Program
	{
		// Return average of "some number" of doubles.
		static double CalculateAverage(params double[] values)
		{
			Console.WriteLine("You sent me {0} doubles.", values.Length);
			double sum = 0;
			if (values.Length == 0)
			{
				return sum;
			}
			for (int i = 0; i < values.Length; i++)
			{
				sum += values[i];
			}
			return (sum / values.Length);
		}
		static void Main(string[] args)
		{
			// Pass in a comma-delimited list of doubles...
			double average;
			average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
			Console.WriteLine("Average of data is: {0}", average);

			// ...or pass an array of doubles.
			double[] data = { 4.0, 3.2, 5.7 };
			average = CalculateAverage(data);
			Console.WriteLine("Average of data is: {0}", average);
			
			// Average of 0 is 0!
			Console.WriteLine("Average of data is: {0}", CalculateAverage());
			Console.ReadLine();
		}
	}
}
