using System;
using System.Collections.Generic;
using System.Text;

namespace LabGuide1
{


    class Product
    {
        private readonly int Limit = 10;
        private string Name { get; set; }
        private int Id { get; set; }
        private int stockAmount;



        public Product(int id, string name, int stockAmount)
        {
            Name = name;
            Id = id;
            this.stockAmount = stockAmount;
        }
        public int StockAmount
        {
            get { return stockAmount; }
            set
            {

            }
        }
    }
}
