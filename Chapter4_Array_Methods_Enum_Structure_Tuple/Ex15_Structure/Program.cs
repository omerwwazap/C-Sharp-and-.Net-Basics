using System;

namespace Ex15_Structure
{
	struct Point
	{
		// Fields of the structure.
		public int X;
		public int Y;

		public Point(int xPos, int yPos)
		{
			X = xPos;
			Y = yPos;
		}
		// Add 1 to the (X, Y) position.
		public void Increment()
		{
			X++; Y++;
		}
		// Subtract 1 from the (X, Y) position.
		public void Decrement()
		{
			X--; Y--;
		}
		// Display the current position.
		public void Display()
		{
			Console.WriteLine("X = {0}, Y = {1}", X, Y);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			// Create an initial Point.
			Point myPoint;
			myPoint.X = 349;
			myPoint.Y = 76;
			myPoint.Display();
			// Adjust the X and Y values.
			myPoint.Increment();
			myPoint.Display();

			//If you do not assign each piece of public field data(X and Y in this case) before using the structure, you will receive a compiler error
			Point p1;
			p1.X = 10;
			//p1.Display();

			// OK! Both fields assigned before use.
			Point p2;
			p2.X = 10;
			p2.Y = 10;
			p2.Display();

			// Set all fields to default values using the default constructor.
			Point p3 = new Point();
			// Prints X=0,Y=0.
			p3.Display();

			Point p4 = new Point(50, 60);
			// Prints X=50,Y=60.
			p4.Display();
		}
	}
}
