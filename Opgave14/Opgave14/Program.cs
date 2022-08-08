using System;

namespace Opgave14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trekant areal beregner");
            
            Console.WriteLine("Skriv højde");
            var højde = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv grundlinje");
            var grundlinje = double.Parse(Console.ReadLine());
            
            var areal = (højde * 0.5) * grundlinje;
            Console.WriteLine($"Arealet er {areal}");
        }
    }
}