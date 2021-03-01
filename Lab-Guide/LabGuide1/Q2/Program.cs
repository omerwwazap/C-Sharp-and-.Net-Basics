using System;
using System.IO;

namespace Q2
{
	
	class Program
	{
		static Action<string> PrintActionDelegate;
		static Func<int> GetRandomNumberDelegate;

		static void Main(string[] args)
		{
			Product p1 = new Product(1111, "Bag", 40);
			Product p2 = new Product(2222, "Shoe", 40);
			Product p3 = new Product(3333, "Belt", 40);

			p1.LessStockEvent += new LessStockEventHandler(ProductStockAmountless);
			p2.LessStockEvent += new LessStockEventHandler(ProductStockAmountless);
			p3.LessStockEvent += new LessStockEventHandler(ProductStockAmountless);

			PrintActionDelegate = outputToDisplay => Console.WriteLine(outputToDisplay);

			GetRandomNumberDelegate = delegate ()
			{
				Random rnd = new Random();
				return rnd.Next(1, 10);
			};

			for (int i = 0; i < 5; i++)
			{
				p1.StockAmount = GetRandomNumberDelegate();
				p2.StockAmount = GetRandomNumberDelegate();
				p3.StockAmount = GetRandomNumberDelegate();
			}
		}
		public static void ProductStockAmountless(Product p, StockLessEventArgs arg)
		{
			PrintActionDelegate("WARNING, Following Product is under stock" + p+"Latest Purchased Amount "+arg.LatestPurchasedAmount+"\n");
			
			using (var destination = File.AppendText("stockDetails.txt"))
			{
				destination.WriteLine(p.ToString()+"Latest purchased amount "+arg.LatestPurchasedAmount);
			}
		}
	}
}
