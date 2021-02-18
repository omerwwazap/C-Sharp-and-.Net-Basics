using System;

namespace Ex6_Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			Hexagon hex = new Hexagon("Beth");
			hex.Draw();
			Circle cir = new Circle("Cindy");
			// Calls base class implementation!
			cir.Draw();
		}
	}
}
