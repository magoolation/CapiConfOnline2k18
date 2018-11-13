using System;

namespace CapiConfOnline.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage("Hello World!");

            System.Console.ReadLine();
        }

        private static void PrintMessage(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
