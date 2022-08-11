using System;

namespace Opgave45
{
    class Program
    {
        static void Main(string[] args)
        {
            var zones = new string[] {"Blå", "Rød", "Gul", "Pink"};
            var zonePrices = new int[] {190, 250, 280, 320};
            var zoneColors = new ConsoleColor[] {ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Magenta};
            var waitingForEnter = true;
            var menuIndex = 0;
            Console.WriteLine("Naviger menu ved brug af pil op/ned og enter for at vælge");
            do
            {
                Console.WriteLine("Vælg zone:");
                for (var i = 0; i < zones.Length; i++)
                {
                    if (i == menuIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(">");
                    }
                    Console.ForegroundColor = zoneColors[i];
                    Console.WriteLine(zones[i]);
                }
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        waitingForEnter = false;
                        break;
                    case ConsoleKey.DownArrow:
                        menuIndex++;
                        if(menuIndex > 3)
                        {
                            menuIndex = 0;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        menuIndex--;
                        if(menuIndex < 0)
                        {
                            menuIndex = 3;
                        }
                        break;
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            } while (waitingForEnter);
            Console.Write("Du har valgt zone: ");
            Console.ForegroundColor = zoneColors[menuIndex];
            Console.WriteLine(zones[menuIndex]);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"pris pr sæde er {zonePrices[menuIndex]}kr");
            Console.WriteLine("Indtast antal ønsked sæder");
            var seats = int.Parse(Console.ReadLine());
            Console.WriteLine($"Du har valgt {seats} sæder");
            Console.WriteLine($"Total pris er {seats * zonePrices[menuIndex]}kr");
        }
    }
}