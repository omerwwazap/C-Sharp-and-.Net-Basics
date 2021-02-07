using System;

namespace Ex2_GetReturnCode_BatchFile
{
    class Program
    {
        static int Main(string[] args)
        {
            // Display a message and wait for Enter key to be pressed.
            Console.WriteLine("***** My First C# App *****");
            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.ReadLine();
            // Return an arbitrary error code.
            return -1;

            //To use this code pls run the included bacth file
            //Chnage return value to see diffrent effects
        }
    }
}
