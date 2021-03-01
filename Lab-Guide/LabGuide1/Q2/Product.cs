using System;
using System.Collections.Generic;
using System.Text;

namespace Q2
{
	public delegate void LessStockEventHandler(Product sender, StockLessEventArgs arg);
	public class Product
	{
		static readonly int LIMIT = 10;
		public string Name { get; set; }
		public int Id { get; set; }
		private int stockAmount;

		public LessStockEventHandler LessStockEvent;
		public Product(int id, string name, int stockAmount)
		{
			Id = id;
			Name = name;
			this.stockAmount = stockAmount;
		}
		public int StockAmount {
			get { return stockAmount; }
			set {
				StockLessEventArgs arg = new StockLessEventArgs(value);
				
				stockAmount -= value;
				if (stockAmount < LIMIT && LessStockEvent != null)
				{
					LessStockEvent(this, arg); //3 STEP
				}
				
			}
		}

		public override string ToString()
		{
			return "\nId: " + Id + "\nName: " + Name + "\nStock Amount: " + StockAmount + "\n";
		}
	}
	public class StockLessEventArgs : EventArgs
	{
		public int LatestPurchasedAmount { get; set; }

		public StockLessEventArgs(int latestPurchasedAmount)
		{
			this.LatestPurchasedAmount = latestPurchasedAmount;
		}

	}
}
