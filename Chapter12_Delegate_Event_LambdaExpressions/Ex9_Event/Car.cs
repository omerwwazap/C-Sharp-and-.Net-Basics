using System;
using System.Collections.Generic;
using System.Text;

namespace Ex9_Event
{
	public class Car
	{
		public int CurrentSpeed { get; set; }
		public int MaxSpeed { get; set; } = 100;
		public string PetName { get; set; }

		private bool _carIsDead;

		public Car() { }
		public Car(string name, int maxSp, int currSp)
		{
			CurrentSpeed = currSp;
			MaxSpeed = maxSp;
			PetName = name;
		}

		// 1) Define a delegate type.
		public delegate void CarEngineHandler(string msgForCaller);
		
		// 2) Define events for car.
		public event CarEngineHandler Exploded;
		public event CarEngineHandler AboutToBlow;
		

		// 4) Implement the Accelerate() method to invoke the delegate's
		// invocation list under the correct circumstances.
		public void Accelerate(int delta)
		{
			// If this car is "dead," send dead message.
			if (_carIsDead)
			{
				Exploded?.Invoke("Sorry, this car is dead...");
			}
			else
			{
				CurrentSpeed += delta;
				// Is this car "almost dead"?
				if (10 == (MaxSpeed - CurrentSpeed))
				{
					AboutToBlow("Careful buddy! Gonna blow!");
				}
				if (CurrentSpeed >= MaxSpeed)
				{
					_carIsDead = true;
				}
				else
				{
					Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
				}
			}
		}
	}
}
