using System;

namespace Ex4_Pointers
{
	/*
	 If you have have some background in C++ pointer manipulation
	 value type, reference type, pointer type
	- To allow unsafe code: project properties > build> check allow unsafe code
	 */
	class Program
	{
		unsafe struct Node
		{
			public int Value;
			public Node* Left;
			public Node* Right;
		}
		public struct Node2
		{
			public int Value;
			// These can be accessed only in an unsafe context!
			public unsafe Node2* Left;
			public unsafe Node2* Right;
		}
		static unsafe void SquareIntPointer(int* myIntPointer)
		{
			// Square the value just for a test.
			*myIntPointer *= *myIntPointer;
		}
		public unsafe static void UnsafeSwap(int* i, int* j)
		{
			int temp = *i;
			*i = *j;
			*j = temp;
		}
		
		public static void SafeSwap(ref int i, ref int j)
		{
			int temp = i;
			i = j;
			j = temp;
		}
		
		static void Main(string[] args)
		{
			unsafe
			{
				// Work with pointer types here!
				int num = 5;
				int* p = &num;
				
				Console.WriteLine("num is {0},{1}", *p, num);
			
				SquareIntPointer(&num);
				Console.WriteLine("num is {0},{1}", *p, num);
			}


			int i = 10, j = 20;
			
			// Swap values "safely."
			Console.WriteLine("\n***** Safe swap *****");
			Console.WriteLine("Values before safe swap: i = {0}, j = {1}", i, j);
			SafeSwap(ref i, ref j);

			Console.WriteLine("Values after safe swap: i = {0}, j = {1}", i, j);
			// Swap values "unsafely."
			Console.WriteLine("\n***** Unsafe swap *****");
			Console.WriteLine("Values before unsafe swap: i = {0}, j = {1}", i, j);
			unsafe { 
				UnsafeSwap(&i, &j);
			}
			Console.WriteLine("Values after unsafe swap: i = {0}, j = {1}", i, j);

			UsePointerToPoint();

		}
		static unsafe void UsePointerToPoint()
		{
			// Access members via pointer.
			Point point;
			Point* p = &point;
			p->x = 100;
			p->y = 200;
			Console.WriteLine(p->ToString());
			// Access members via pointer indirection.
			Point point2;
			Point* p2 = &point2;
			(*p2).x = 100;
			(*p2).y = 200;
			Console.WriteLine((*p2).ToString());
		}
	}
}
