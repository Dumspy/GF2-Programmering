using System;

namespace Opgave24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast ønsket værsel Enkeltværelse, Dobbeltværelse eller Familieværelse (E/D/F)");
            var roombBasePrice = 0;
            while (roombBasePrice == 0)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.E:
                        roombBasePrice = 765;
                        break;
                    case ConsoleKey.D:
                        roombBasePrice = 980;
                        break;
                    case ConsoleKey.F:
                        roombBasePrice = 1250;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Indtast ønsket værsel Enkeltværelse, Dobbeltværelse eller Familieværelse (E/D/F)");
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Indtast antal dage du ønsker at bo i værelset");
            var days = 0;
            while (days == 0)
            {
                days = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            
            var price = roombBasePrice * days;
            
            Console.WriteLine($"Du har valgt {days} dage og du skal betale {price} kr eller {Math.Floor(price/7.44)} euro");
        }
    }
}