using System;

namespace Ex3_CommandLineArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            //For test purposes
            //commandLineArgs: "Hello CTIS479 123" 
            //are sent by the launchSettings.json file

            foreach (string val in args)
                Console.WriteLine(val);

            //or

            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string val in theArgs)
                Console.WriteLine(val);

            // Use Environment class to get logical drives, os version, .net core version
            // Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Core Version: {0}", Environment.Version);

        }
    }
}
