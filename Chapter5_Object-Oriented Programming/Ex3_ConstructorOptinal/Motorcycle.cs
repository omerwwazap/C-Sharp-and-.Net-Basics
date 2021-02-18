using System;
using System.Collections.Generic;
using System.Text;

namespace Ex3_ConstructorOptinal
{
	class Motorcycle
	{
		public int driverIntensity;
		public string driverName;

		//Use  ctor code snippet. When you type ctor and press the Tab key twice to write constrctor. 
		// Constructor chaining.
		// Single constructor using optional args.
		public Motorcycle(int intensity = 0, string name = "")
		{
			if (intensity > 10)
			{
				intensity = 10;
			}
			driverIntensity = intensity;
			driverName = name;
		}

		public void PopAWheely()
		{
			for (int i = 0; i <= driverIntensity; i++)
			{
				Console.WriteLine("Haaaaaeewww!");
			}
		}
		public void SetDriverName(string driverName) => this.driverName = driverName;
	}
}
