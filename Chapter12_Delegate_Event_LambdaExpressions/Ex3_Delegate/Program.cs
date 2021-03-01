using System;

namespace Ex3_Delegate
{
	/*
	 use delegates to define a Car class that has the ability to inform external
	 sentities about its current engine state
		-Define a new delegate type that will be used to send notifications to the caller.
		-Declare a member variable of this delegate in the Car class.
		-Create a helper function on the Car that allows the caller to specify the method to
		call back on.
		-Implement the Accelerate() method to invoke the delegate’s invocation list
		under the correct circumstances
	*/
	class Program
	{
		static void Main(string[] args)
		{
			Car c1 = new Car("SlugBug", 100, 10);

			// Now, tell the car which method to call
			// when it wants to send us messages.
			Car.CarEngineHandler handler = new Car.CarEngineHandler(OnCarEngineEvent);

			c1.RegisterWithCarEngine(handler);

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
		
	}
}
