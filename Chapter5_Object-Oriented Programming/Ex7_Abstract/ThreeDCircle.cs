using System;
using System.Collections.Generic;
using System.Text;

namespace Ex7_Abstract
{
	class ThreeDCircle : Circle
	{
		public new void Draw()
		{
			Console.WriteLine("Drawing a 3D Circle");
		}
	}
}
