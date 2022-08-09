using System;

namespace Opgave23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tshirt købs beregner indtast størrelse (S/M/L)");
            var size = 0;
            while (size == 0)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.S:
                        Console.WriteLine("Du har valgt Small");
                        size = 1;
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine("Du har valgt Medium");
                        size = 2;
                        break;
                    case ConsoleKey.L:
                        Console.WriteLine("Du har valgt Large");
                        size = 3;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Tshirt købs beregner indtast størrelse (S/M/L)");
                        break;
                }
            }
            
            Console.WriteLine("Indtast antal");
            var quantity = 0;
            while (quantity == 0)
            {
                if (int.TryParse(Console.ReadLine(), out var parsedQuantity))
                {
                    quantity = parsedQuantity;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Indtast antal");
                }
            }
            
            var basePrice = 0;
            switch (size)
            {
                case 1:
                    basePrice = 120;
                    break;
                case 2:
                    basePrice = 160;
                    break;
                case 3:
                    basePrice = 185;
                    break;
            }
            
            var totalPrice = quantity >= 10 ? basePrice * quantity * 0.95 : basePrice * quantity;
            
            Console.WriteLine($"Total pris: {totalPrice}");
        }
    }
}