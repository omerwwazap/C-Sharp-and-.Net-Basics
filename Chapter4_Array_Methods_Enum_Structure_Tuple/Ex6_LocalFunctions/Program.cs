using System;

namespace Ex6_LocalFunctions
{
	class Program
	{
		static int AddWrapper(int x, int y)
		{
			//Do some validation here
			return Add();
			//local function for real goal of the method
			int Add() 
			{
				return x + y;
			}
			//The contained Add() method can be called only from the wrapping AddWrapper() method.
			//Benefit: used in asynchronous methods
		}
		static void Main(string[] args)
		{
			Console.WriteLine(	 AddWrapper(3, 5));
			
		}
	}
}
