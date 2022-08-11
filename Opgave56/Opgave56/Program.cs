using System;

namespace Opgave56
{
    class Program
    {
        static void Main(string[] args)
        {
            var temps = new int[] { 24, 25, 24, 22, 27, 23, 24 };
            var days = new string[] {"Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fredag", "Lørdag", "Søndag" };
            var temp = 0;
            for (var i = 0; i < days.Length-1; i++)
            {
                Console.WriteLine($"{days[i]} - {temps[i]}°");
                temp += temps[i];
            }
            Console.WriteLine($"Gennemsnittet er {temp / days.Length}°");
        }
    }
}