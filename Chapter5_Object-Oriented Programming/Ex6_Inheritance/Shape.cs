using System;
using System.Collections.Generic;
using System.Text;

namespace Ex6_Inheritance
{
	class Shape
	{
		protected Shape(string name = "NoName")
		{ PetName = name; }
		public string PetName { get; set; }
		// A single virtual method.
		public virtual void Draw()
		{
			Console.WriteLine("Inside Shape.Draw()");
		}
	}

}
