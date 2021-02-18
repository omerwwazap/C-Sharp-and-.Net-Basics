using System;

namespace Ex12_Property
{

	/*
	 A property is like a combination of a variable and a method, and it has two methods: a get and a set method:
	 */
	class Person
	{
		private string name; // field

		public string Name   // property
		{
			get { return name; }   // get method
			set { name = value; }  // set method
		}

		//write prop and press tab button twice to write property
		//Short Hand
		public string Surname { get; set; } // This property will alocate a string momory location. To access that location this property must be used. 
		public int Age { get; set; } = 18; // C# 6 or higher
		public int limit { get; } = 10;

	}
	class TimePeriod
	{
		private double _seconds;

		public double Hours
		{
			get { return _seconds / 3600; }
			set
			{
				if (value < 0 || value > 24)
					throw new ArgumentOutOfRangeException(
						  $"{nameof(value)} must be between 0 and 24.");

				_seconds = value * 3600;
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person();
			p.Name = "Liam";
		
			Console.WriteLine("name: "+p.Name);
			Console.WriteLine("Age"+p.Age);
			p.Age = 25;
			//p.limit = 100;// set not implemented so its value cannot be set
			Console.WriteLine("Age"+p.Age);

			TimePeriod t = new TimePeriod();
			// The property assignment causes the 'set' accessor to be called.
			t.Hours = 24;

			// Retrieving the property causes the 'get' accessor to be called.
			Console.WriteLine($"Time in hours: {t.Hours}");
		}
	}
}
