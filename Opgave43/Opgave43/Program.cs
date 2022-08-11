using System;

namespace Opgave43
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinks = new String[] { "Cola", "Fanta", "Vand", "Kaffe", "Te" };
            var prices = new double[] { 1.50, 1.50, 1.00, 2.00, 2.00 };
            var currentMenuItem = 0;
            var waitingForEnter = true;
            do
            {
                Console.WriteLine("Brug pil op ned for at navigere i menuen og enter for at vælge");
                for (int i = 0; i < drinks.Length; i++)
                {
                    Console.WriteLine(currentMenuItem == i ? $">{drinks[i]}" : drinks[i]);
                }

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    waitingForEnter = false;
                }
                else if (Console.ReadKey().Key == ConsoleKey.UpArrow)
                {
                    currentMenuItem--;
                    if (currentMenuItem < 0)
                    {
                        currentMenuItem = drinks.Length - 1;
                    }
                }
                else if (Console.ReadKey().Key == ConsoleKey.DownArrow)
                {
                    currentMenuItem++;
                    if (currentMenuItem > drinks.Length - 1)
                    {
                        currentMenuItem = 0;
                    }
                }

                Console.Clear();
            } while (waitingForEnter);
            
            Console.WriteLine($"Du har valgt {drinks[currentMenuItem]} til {prices[currentMenuItem]} kr.");
        }
    }
}