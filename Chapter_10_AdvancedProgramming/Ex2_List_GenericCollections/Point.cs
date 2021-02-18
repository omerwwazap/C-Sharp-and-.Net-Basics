using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2_List_GenericCollections
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public override string ToString()
		{
			return $"({X},{Y})";
		}
	}
}
