using System;

namespace Ex9_Event
{
	/*
	 When the compiler processes the event keyword, you are automatically 
	provided with registration and unregistration methods, 
	as well as any necessary member variables for your delegate types.
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Car c1 = new Car("SlugBug", 100, 10);
			// Register event handlers.
			c1.AboutToBlow += CarIsAlmostDoomed;
			c1.AboutToBlow += CarAboutToBlow;
			
			Car.CarEngineHandler d = CarExploded;
			c1.Exploded += d;

			Console.WriteLine("***** Speeding up *****");
			for (int i = 0; i < 6; i++)
			{
				c1.Accelerate(20);
			}
			// Remove CarExploded method
			// from invocation list.
			c1.Exploded -= d;
			Console.WriteLine("\n***** Speeding up *****");
			for (int i = 0; i < 6; i++)
			{
				c1.Accelerate(20);
			}
		}
		public static void CarAboutToBlow(string msg)
		{
			Console.WriteLine("Car about to blow"+msg);
		}
		public static void CarIsAlmostDoomed(string msg)
		{
			Console.WriteLine("=> Critical Message from Car: {0}", msg);
		}
		public static void CarExploded(string msg)
		{ 
			Console.WriteLine("Car eploded"+msg);
		}
	}
}
