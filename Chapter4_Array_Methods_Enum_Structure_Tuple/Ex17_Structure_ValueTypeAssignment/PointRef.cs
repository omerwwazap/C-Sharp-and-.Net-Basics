using System;
using System.Collections.Generic;
using System.Text;

namespace Ex17_Structure_ValueTypeAssignment
{
	class PointRef
	{
		public int X;
		public int Y;
		public PointRef(int xPos, int yPos)
		{
			X = xPos;
			Y = yPos;
		}
		public void Display()
		{
			Console.WriteLine("X = {0}, Y = {1}", X, Y);
		}

	}
}
