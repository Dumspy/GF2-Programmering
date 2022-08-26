using System;

namespace Opgave42
{
    class Program
    {
        static void Main(string[] args)
        {
            var drinks = new String[] { "Cola", "Fanta", "Vand", "Kaffe", "Te" };
            var prices = new double[] { 21.50, 21.50, 12.00, 10.00, 8.00 };
            var currentMenuItem = 0;
            var waitingForEnter = true;
            do
            {
                Console.WriteLine("Brug pil op ned for at navigere i menuen og enter for at vælge");
                for (int i = 0; i < drinks.Length; i++)
                {
                    Console.WriteLine(currentMenuItem == i ? $">{drinks[i]}" : drinks[i]);
                }

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        waitingForEnter = false;
                        break;
                    case ConsoleKey.UpArrow:
                        currentMenuItem--;
                        if (currentMenuItem < 0)
                        {
                            currentMenuItem = drinks.Length - 1;
                        }

                        break;
                    case ConsoleKey.DownArrow:
                        currentMenuItem++;
                        if (currentMenuItem > drinks.Length - 1)
                        {
                            currentMenuItem = 0;
                        }

                        break;
                }

                Console.Clear();
            } while (waitingForEnter);
            
            Console.WriteLine($"Du har valgt {drinks[currentMenuItem]} til {prices[currentMenuItem]} kr.");
        }
    }
}