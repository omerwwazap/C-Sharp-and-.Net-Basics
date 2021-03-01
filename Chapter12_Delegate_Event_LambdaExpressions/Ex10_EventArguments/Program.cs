using System;

namespace Ex10_EventArguments
{
	/*
	 For simple events, you can pass an instance of EventArgs directly.
	 */
	public class CarEventArgs : EventArgs
	{
		public readonly string msg;
		int delat;
		public CarEventArgs(string message, int delta)
		{
			msg = message;
			this.delat = delat;
		}
	}
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
		public static void CarAboutToBlow(object sender, CarEventArgs e)
		{
			if (sender is Car c)
			{
				Console.WriteLine(
				$"Critical Message from {c.PetName}: {e.msg}");
			}
		}
		public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
		{
			Car c = (Car)sender;

			Console.WriteLine("=> Critical Message from Car: {0} {1}",c.CurrentSpeed, e.msg);
		}
		public static void CarExploded(object sender, CarEventArgs e)
		{
			if (sender is Car c)
			{
				Console.WriteLine($"{c.PetName}: {e.msg}");
			}
		}
	}
}
