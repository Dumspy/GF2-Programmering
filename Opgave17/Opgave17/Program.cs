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
            
            var omkreds = Math.Sqrt(Math.Pow(højde, 2) + Math.Pow(grundlinje, 2));
            Console.WriteLine($"Omkredsen er {omkreds}");
        }
    }
}