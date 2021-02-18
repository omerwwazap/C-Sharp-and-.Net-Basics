using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5_Object_Oriented_Programming
{
	class Motorcycle
	{
		public int driverIntensity;
		public string driverName;
	
		//Use  ctor code snippet. When you type ctor and press the Tab key twice to write constrctor. 
		public Motorcycle() { }
		// Our custom constructor.
		public Motorcycle(int intensity)
		{
			if (intensity > 10)
			{
				intensity = 10;
			}
			driverIntensity = intensity;
		}
		public Motorcycle(int intensity, string name)
		{
			if (intensity > 10)
			{
				intensity = 10;
			}
			driverIntensity = intensity;
			this.driverName = name;
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
