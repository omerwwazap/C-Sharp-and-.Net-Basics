using System;

namespace Ex2_ConstructorChaning
{
	class Program
	{
		static void Main(string[] args)
		{
			Motorcycle c = new Motorcycle(5);
			c.SetDriverName("Tiny");
			c.PopAWheely();
			Console.WriteLine("Rider name is {0}", c.driverName);
		}
	}
}
