using System;

namespace Ex16_ReadOnlyStructure
{
	//Structs can also be marked as readonly if there is a need for them to be immutable. I
	readonly struct ReadOnlyPoint
	{
		// Fields of the structure.
		public int X { get; }
		public int Y { get; }
		// Display the current position and name.
		public void Display()
		{
			Console.WriteLine($"X = {X}, Y = {Y}");
		}
		public ReadOnlyPoint(int xPos, int yPos, string name)
		{
			X = xPos;
			Y = yPos;
		}
	}

	struct PointWithReadOnly
	{
		// Fields of the structure.
		public int X;
		public readonly int Y;
		public readonly string Name;
		// Display the current position and name.
		public readonly void Display()
		{
			Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
		}
		// A custom constructor.
		public PointWithReadOnly(int xPos, int yPos, string name)
		{
			X = xPos;
			Y = yPos;
			Name = name;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			ReadOnlyPoint p = new ReadOnlyPoint(50, 60, "Point w/RO");
			p.Display();
		}
	}
}
