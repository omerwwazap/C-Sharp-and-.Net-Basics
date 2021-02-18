using System;
using System.Collections.Generic;
using System.Text;

namespace Ex1_IndexerMethod
{
	class SomeContainer
	{
		private int[,] my2DintArray = new int[10, 10];
		public int this[int row, int column]
		{
			get { return my2DintArray[row, column]; }
			set { my2DintArray[row, column] = value; }
		}
	}
}
