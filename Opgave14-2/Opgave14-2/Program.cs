using System;

namespace Opgave14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rektangel areal og omkreds beregner");
            
            Console.WriteLine("Indtast højde");
            var højde = double.Parse(Console.ReadLine());
            Console.WriteLine("Indtast bredde");
            var bredde = double.Parse(Console.ReadLine());
            
            var areal = højde * bredde;
            var omkreds = (højde + bredde) * 2;
            
            Console.WriteLine($"Arealet er {areal} og omkredsen er {omkreds}");
        }
    }
}