﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8_as
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
