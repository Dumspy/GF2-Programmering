using System;

namespace Opgave21
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyPressed = false;
            while (!keyPressed)
            {
                Console.WriteLine("Er du en del af en forening? (J/N)");
                switch(Console.ReadKey().Key)
                {
                    case ConsoleKey.J:
                        Console.Clear();
                        Console.WriteLine("Du er en del af en forening og får derfor 10% rabat");
                        keyPressed = true;
                        break;
                    case ConsoleKey.N:
                        Console.Clear();
                        Console.WriteLine("Du er ikke en del af en forening");
                        keyPressed = true;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
