using System;

namespace Opgave58
{
    class Program
    {
        static void Main(string[] args)
        {
            var pets = new string[] { "Hund", "Kat", "Fugl", "Fisk", "Marsvin", "Giraff"};

            foreach (var pet in pets)
            {
                Console.WriteLine(pet);
            }
        }
    }
}