
using System;


using Ex11_Model; // Add using statement for Ex11_Model namespace

namespace Ex11_AccessModifiers
{
	/*
	 public: The type or member can be accessed by any other code in the same assembly or another assembly that references it.
	 private: The type or member can be accessed only by code in the same class or struct.
	 protected: The type or member can be accessed only by code in the same class, or in a class that is derived from that class.
     internal: The type or member can be accessed by any code in the same assembly, but not from another assembly.
     protected internal: The type or member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
     private protected: The type or member can be accessed only within its declaring assembly, by code in the same class or in a type that is derived from that class

	Derived classes can't have greater accessibility than their base types.
	classs default visibility is internal
	interfaces default to internal access.
	data members default visibilty is private
	inner class default visibilty is private  
	
	 */
	class Program
	{
		// By default, type members are implicitly private, while types are implicitly internal. T
		// An internal class with a private default constructor.
		//internal: the type or member can be accessed by any code in the same assembly, but not from another assembly
		class Radio //internal visibility
		{
			int freq; //private by default.
			Radio() { } //while the type’s default constructor is automatically set to private
			public Radio(int f) { freq = f; }

			//Struct members, including nested classes and structs, can be declared public, internal, or private. have private access by default
			private class type
			{

			}
		}
		public class Motorcycle
		{
			int driverIntensity;
			protected int speed;
			public string driverName;

			void SetDriverIntensity(int intensity) => this.driverIntensity = intensity;
			protected void SetDriverName(string driverName) => this.driverName = driverName;
			public void SetDriverSpeed(int speed) => this.speed = speed;
		}
		static void Main(string[] args)
		{
			//Radio rd = new Radio();
			Radio rd = new Radio(99);
			//rd.freq = 99;

			Motorcycle mc = new Motorcycle();
			//mc.driverIntensity = 99;
			//mc.SetDriverSpeed = 100;
			mc.driverName = "John";

			//mc.SetDriverIntensity(99);
			//mc.SetDriverName("John");
			mc.SetDriverSpeed(100);

			Staff s = new Staff();  //using Ex11_Model statement addded
			s.id = "123";
			
		}
	}
}
