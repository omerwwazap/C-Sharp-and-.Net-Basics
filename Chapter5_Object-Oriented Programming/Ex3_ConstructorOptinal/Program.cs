using System;

namespace Ex3_ConstructorOptinal
{
	class Program
	{
		static void Main(string[] args)
		{
			// driverName = "", driverIntensity = 0
			Motorcycle m1 = new Motorcycle();
			Console.WriteLine("Name= {0}, Intensity= {1}", m1.driverName, m1.driverIntensity);
			
			// driverName = "Tiny", driverIntensity = 0
			Motorcycle m2 = new Motorcycle(name: "Tiny");
			Console.WriteLine("Name= {0}, Intensity= {1}", m2.driverName, m2.driverIntensity);
			
			
			// driverName = "", driverIntensity = 7
			Motorcycle m3 = new Motorcycle(7);
			Console.WriteLine("Name= {0}, Intensity= {1}",m3.driverName, m3.driverIntensity);
		}
	}
}
