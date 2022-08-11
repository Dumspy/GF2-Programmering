using System;

namespace OpgaveH
{
    class Program
    {
        static void Main(string[] args)
        {
            var waitingForRespond = true;
            do
            {
                Console.WriteLine("Vælg billet type Studerende, Voksen eller Pensionits (S/V/P)");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.S:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Studerende billet 30kr");
                        waitingForRespond = false;
                        break;
                    case ConsoleKey.V:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Voksen billet 85kr");
                        waitingForRespond = false;
                        break;
                    case ConsoleKey.P:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Pensionist billet 20kr");
                        waitingForRespond = false;
                        break;
                    default:
                        Console.ResetColor();
                        Console.Clear();
                        break;
                }
            } while (waitingForRespond);
        }
    }
}