﻿using System;

namespace Ex9_CreatingCustomGenericClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			// Point using ints.
			Point<int> p = new Point<int>(10, 10);
			Console.WriteLine("p.ToString()={0}", p.ToString());
			p.ResetPoint();
			Console.WriteLine("p.ToString()={0}", p.ToString());
			Console.WriteLine();
			
			// Point using double.
			Point<double> p2 = new Point<double>(5.4, 3.3);
			Console.WriteLine("p2.ToString()={0}", p2.ToString());
			p2.ResetPoint();
			Console.WriteLine("p2.ToString()={0}", p2.ToString());
			Console.WriteLine();
			
			// Point using strings.
			Point<string> p3 = new Point<string>("i", "3i");
			Console.WriteLine("p3.ToString()={0}", p3.ToString());
			p3.ResetPoint();
			Console.WriteLine("p3.ToString()={0}", p3.ToString());
		}
	}
}
