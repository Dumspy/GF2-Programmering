using System;

namespace Opgave40
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("[1] [2] [3]");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("Du har trykket på 1");
                    break;

                case ConsoleKey.D2:
                    Console.WriteLine("Du har trykket på 2");
                    break;

                case ConsoleKey.D3:
                    Console.WriteLine("Du har trykket på 3");
                    break;

                default:
                    Console.WriteLine("Du har ikke trykket 1,2 eller 3");
                    break;
            }
        }
    }
}