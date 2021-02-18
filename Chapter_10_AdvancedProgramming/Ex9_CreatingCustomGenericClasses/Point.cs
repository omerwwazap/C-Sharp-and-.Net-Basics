using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9_CreatingCustomGenericClasses
{
	class Point<T>
	{
		public T X { get; set; }
		public T Y { get; set; }

		// Generic constructor.
		public Point(T xVal, T yVal)
		{
			X = xVal;
			Y = yVal;
		}
		public override string ToString()
		{
			return $"({X},{Y})";
		}
		public void ResetPoint()
		{
			X = default(T);
			Y = default(T);
		}
	}
}
