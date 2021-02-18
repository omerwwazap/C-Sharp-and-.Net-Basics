using System;

namespace Ex7_Abstract
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Polymorphism *****\n");
			// Make an array of Shape-compatible objects.
			Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Mick"), new Circle("Beth"), new Hexagon("Linda"), new ThreeDCircle()};
			// Loop over each item and interact with the
			// polymorphic interface.
			foreach (Shape s in myShapes)
			{
				s.Draw();
			}
			
			
			// This calls the Draw() method of the ThreeDCircle.
			ThreeDCircle o = new ThreeDCircle();
			o.Draw();
			// This calls the Draw() method of the parent!
			((Circle)o).Draw();
		}
	}
}
