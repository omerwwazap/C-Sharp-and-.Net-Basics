using System;

namespace Ex14_LambdaWithDelegate
{
	public delegate string VerySimpleDelegate();

	public class SimpleMath
	{
		public delegate void MathMessage(string msg, int result);
		private MathMessage _mmDelegate;
		public void SetMathHandler(MathMessage target)
		{
			_mmDelegate = target;
		}
		public void Add(int x, int y)
		{
			_mmDelegate?.Invoke("Adding has completed!", x + y);
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			SimpleMath m = new SimpleMath();
			m.SetMathHandler((msg, result) =>{ Console.WriteLine("Message: {0}, Result: {1}", msg, result); });
			
			m.Add(10, 10);

			VerySimpleDelegate d = new VerySimpleDelegate(() => { return "Enjoy your string!"; });
			VerySimpleDelegate d2 = new VerySimpleDelegate(() => "Enjoy your string!");
			VerySimpleDelegate d3 = () => "Enjoy your string!";
		}
	}
}
