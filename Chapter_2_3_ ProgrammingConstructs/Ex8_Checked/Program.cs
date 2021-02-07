using System;

namespace Ex8_Checked
{
    class Program
    {
        static void Main(string[] args)
        {

            //For more information https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/checked

            byte b1 = 100;
            byte b2 = 250;
            byte sum = (byte)Add(b1, b2);
            // sum should hold the value 350. However, we find the value 94!
            Console.WriteLine("sum = {0}", sum);


            int sum2 = b2 + b1;
            Console.WriteLine("sum = {0}", sum2);
            //byte sum2 = b1 + b2; actualy means
            //byte sum2 = (int) b1 + (int) b2;

            //Thats why byte sum3 = b1 + b2 is cast to --> byte sum3 = (byte)(b1 + b2)

            try
            {
                sum = checked((byte)Add(b1, b2));
                Console.WriteLine("sum = {0}", sum);
            }
            catch (OverflowException ex){
                Console.WriteLine(ex.Message);
            }

            try{
                checked{
                    sum = (byte)Add(b1, b2);
                    Console.WriteLine("sum = {0}", sum);
                }
            }
            catch (OverflowException ex){
                Console.WriteLine(ex.Message);
            }

            // Assuming /checked is enabled,
            // this block will not trigger
            // a runtime exception.
            unchecked{
                sum = (byte)(b1 + b2);
                Console.WriteLine("sum = {0} ", sum);
            }
        }

        static int Add(int x, int y){
            return x + y;
        }
    }
}
