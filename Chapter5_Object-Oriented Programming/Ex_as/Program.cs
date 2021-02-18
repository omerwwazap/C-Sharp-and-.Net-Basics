using System;

namespace Ex8_as
{
	class Program
	{
		static void Main(string[] args)
		{
			Shape[] things = new Shape[5];
			things[0] = new Hexagon();
			things[1] = null;
			things[2] = new Circle();
			things[4] = new ThreeDCircle();

			foreach (Shape item in things)
			{
				ThreeDCircle tdh = item as ThreeDCircle;
				if (tdh == null)
				{
					if (item is Hexagon)
					{
						item.Draw();
					}
					else
						Console.WriteLine("Item is not a ThreeDCircle or Hexagon");
				}
				else
				{
					((Circle)tdh).Draw();
				}

			}

			Hexagon  h = new Hexagon();

			Console.WriteLine("ToString: {0}", h.ToString());
			Console.WriteLine("Hash code: {0}", h.GetHashCode());
			Console.WriteLine("Type: {0}", h.GetType());

		}
	}
}
