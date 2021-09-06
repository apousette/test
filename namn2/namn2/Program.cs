using System;

namespace namn2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej!");
            Console.WriteLine("Vad är ditt förnamn?");  

            string fnamn = Console.ReadLine();

            Console.WriteLine("Vad är ditt efternamn?");

            string enamn = Console.ReadLine();

            Console.WriteLine("Hej " + fnamn + " " + enamn + "!");

        }
    }
}
