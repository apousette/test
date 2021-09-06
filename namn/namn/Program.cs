using System;

namespace namn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej, vad heter du?");

            string namn = Console.ReadLine();

            Console.WriteLine("Hej " + namn + "!");
        }
    }
}
