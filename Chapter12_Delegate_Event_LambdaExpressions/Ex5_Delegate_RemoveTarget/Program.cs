using System;

namespace Ex5_Delegate_RemoveTarget
{
	class Program
	{
		static void Main(string[] args)
		{
			Car c1 = new Car("SlugBug", 100, 10);

			// Now, tell the car which method to call
			// when it wants to send us messages.
			Car.CarEngineHandler handler1 = new Car.CarEngineHandler(OnCarEngineEvent);
			
			c1.RegisterWithCarEngine(handler1);
			c1.RegisterWithCarEngine(OnCarEngineEvent2);

			//c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

			Console.WriteLine("***** Speeding up *****");
			for (int i = 0; i < 6; i++)
			{
				c1.Accelerate(20);
			}
			
			c1.UnRegisterWithCarEngine(handler2);
			// We won't see the "uppercase" message anymore!
			Console.WriteLine("***** Speeding up *****");
			for (int i = 0; i < 6; i++)
			{
				c1.Accelerate(20);
			}
		}
		// This is the target for incoming events.
		public static void OnCarEngineEvent(string msg)
		{
			Console.WriteLine("\n*** Message From Car Object ***");
			Console.WriteLine("=> {0}", msg);
			Console.WriteLine("********************\n");
		}
		public static void OnCarEngineEvent2(string msg)
		{
			Console.WriteLine("=> {0}", msg.ToUpper());
		}
	}
}
