using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Inheritance
{
	class Hexagon : Shape
	{
		public Hexagon() { }
		public Hexagon(string name) : base(name) { }
		public override void Draw()
		{
			Console.WriteLine("Drawing {0} the Hexagon", PetName);
		}
	}
}
