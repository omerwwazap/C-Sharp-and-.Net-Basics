﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5_Object_Oriented_Programming
{
	class Car
	{
		// The 'state' of the Car.
		public string petName;
		public int currSpeed;
		// A custom default constructor.
		public Car()
		{
			petName = "Chuck";
			currSpeed = 10;
		}
		// Here, currSpeed will receive the
		// default value of an int (zero).
		public Car(string pn) => petName = pn; 
		// Let caller set the full state of the Car.
		public Car(string pn, int cs)
		{
			petName = pn;
			currSpeed = cs;
		

		}

		public Car(string pn, int cs, out bool inDanger)
		{
			petName = pn;
			currSpeed = cs;
			if (cs > 100)
			{
				inDanger = true;
			}
			else
			{
				inDanger = false;
			}
		}

		public void PrintState()
		{
			Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
		}
		// The functionality of the Car.
		// Using the expression-bodied member syntax
		public void SpeedUp(int delta) => currSpeed += delta;
	}
}
