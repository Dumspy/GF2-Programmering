using System;

namespace Opgave40
{
    class Program
    {
        static void Main(string[] args)

        {
            ConsoleKey key;
            do
            {
                Console.WriteLine("[1] [2] [3] [9]");
                key = Console.ReadKey().Key;
                switch (key)
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
                    case ConsoleKey.D9:
                        Console.WriteLine("Du har trykket på 9");
                        break;

                    default:
                        Console.WriteLine("Du har ikke trykket 1,2 eller 3");
                        break;
                }
            }while (key != ConsoleKey.D9);
        }
    }
}