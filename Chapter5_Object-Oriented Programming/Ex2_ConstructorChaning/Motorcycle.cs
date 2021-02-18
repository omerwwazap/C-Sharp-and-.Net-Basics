using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2_ConstructorChaning
{
	class Motorcycle
	{
		public int driverIntensity;
		public string driverName;

		//Use  ctor code snippet. When you type ctor and press the Tab key twice to write constrctor. 
		// Constructor chaining.
		public Motorcycle() { }
		public Motorcycle(int intensity) : this(intensity, "") { }
		public Motorcycle(string name) : this(0, name) { }
		// This is the 'master' constructor that does all the real work.
		public Motorcycle(int intensity, string name)
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
