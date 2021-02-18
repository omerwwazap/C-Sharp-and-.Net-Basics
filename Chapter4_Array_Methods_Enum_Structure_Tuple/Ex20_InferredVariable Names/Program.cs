using System;

namespace Ex20_InferredVariable_Names
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("=> Inferred Tuple Names");
			var foo = new { Prop1 = "first", Prop2 = "second" };
			var bar = (foo.Prop1, foo.Prop2);
			Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
		}
	}
}
