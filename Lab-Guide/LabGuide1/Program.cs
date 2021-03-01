using System;

namespace LabGuide1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Product p1 = new Product(1111, "Bag", 40);
            Product p2 = new Product(2222, "Shoe", 40);
            Product p3 = new Product(3333, "Belt", 40);


            p1.LessStockEvent += new LessStockEventHandler();

        }
    }
}
