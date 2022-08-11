using System;

namespace OpgaveF
{
    class Program
    {
        static void Main(string[] args)
        {
            var done = false;
            do
            {
                Console.WriteLine("Har du bestået (Ja/Nej)");
                var input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "ja":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tillykke");
                        done = true;
                        break;
                    case "nej":
                        Console.ForegroundColor = ConsoleColor.Red;;
                        Console.WriteLine("Øv prøv igen");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Du skal skrive Ja eller Nej");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (!done);
        }
    }
}