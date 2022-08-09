using System;

namespace Opgave35
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var numbers = new int[6];
            var i = 0;
            while (i<1000)
            {
                var randomNumber = random.Next(1, 7);
                numbers[randomNumber - 1]++;
                i++;
            }

            for (var j = 0; j < numbers.Length; j++)
            {
                Console.WriteLine($"Slog {numbers[j]} {j + 1}er");
            }
        }
    }
}