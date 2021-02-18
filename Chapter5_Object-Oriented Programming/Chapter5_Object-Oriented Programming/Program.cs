using System;

namespace Chapter5_Object_Oriented_Programming
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Class Types *****\n");
			// Allocate and configure a Car object.
			Car myCar = new Car();
			myCar.petName = "Henry";
			myCar.currSpeed = 10;
			// Speed up the car a few times and print out the
			// new state.
			for (int i = 0; i <= 10; i++)
			{
				myCar.SpeedUp(5);
				myCar.PrintState();
			}

			// Make a Car called Mary going 0 MPH.
			Car mary = new Car("Mary");
			mary.PrintState();
			// Make a Car called Daisy going 75 MPH.
			Car daisy = new Car("Daisy", 75);
			daisy.PrintState();

			Car john = new Car("John", 55, out bool dng);
			mary.PrintState();

			Motorcycle c = new Motorcycle(5);
			c.SetDriverName("Tiny");
			c.PopAWheely();
			Console.WriteLine("Rider name is {0}", c.driverName); // Prints an empty name value!
		}
	}
}
