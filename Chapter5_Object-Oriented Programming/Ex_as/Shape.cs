using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8_as
{
	abstract class Shape
	{
		protected Shape(string name = "NoName")
		{ PetName = name; }
		public string PetName { get; set; }
		// A single virtual method.
		// Force all child classes to define how to be rendered.
		public abstract void Draw();

	}

}
