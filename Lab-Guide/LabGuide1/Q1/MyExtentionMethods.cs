using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
	static class MyExtentionMethods
	{
		public static double Average(this List<int> list)
		{
			double sum = 0;
			foreach(int item in list)
			{
				sum += item;
			}
			return sum / list.Count;
		}
	}
}
