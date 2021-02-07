using System;

namespace Ex4_Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value 99999 in various formats:");

            //currency Format 
            Console.WriteLine("c format: {0:c}", 99999); //c format: £99,999.00
            //Decimal
            Console.WriteLine("d9 format: {0:d9}", 99999); //d9 format: 000099999
            //
            Console.WriteLine("f3 format: {0:f3}", 99999); //f3 format: 99999.000
            //Number
            Console.WriteLine("n format: {0:n}", 99999); //n format: 99,999.00


            // Notice that upper- or lowercasing for hex
            // determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 99999); //E format: 9.999900E+004
            Console.WriteLine("e format: {0:e}", 99999); //e format: 9.999900e+004
            Console.WriteLine("X format: {0:X}", 99999); //X format: 1869F
            Console.WriteLine("x format: {0:x}", 99999); //x format: 1869f

            //For more info https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

        }
    }
}
