using System;
using System.Collections.Generic;
using System.Text;

namespace Ex10_EventArguments
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
		public delegate void CarEngineHandler(object sender, CarEventArgs e);
		
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
				Exploded(this, new CarEventArgs("Sorry, this car is dead...", delta));
			}
			else
			{
				CurrentSpeed += delta;
				// Is this car "almost dead"?
				if (10 == (MaxSpeed - CurrentSpeed))
				{
					AboutToBlow(this, new CarEventArgs("Careful buddy! Gonna blow!", delta));
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
