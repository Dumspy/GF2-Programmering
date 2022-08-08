using System;

namespace Opgave16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cirkel areal og omkreds beregner");
            
            Console.Write("Indtast radius:");
            var radius = double.Parse(Console.ReadLine());
            
            var areal = Math.PI * Math.Pow(radius, 2);
            var omkreds = 2 * Math.PI * radius;
            
            Console.WriteLine($"Arealet er {areal} og omkredsen er {omkreds}");
        }
    }
}