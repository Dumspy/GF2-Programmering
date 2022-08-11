using System;

namespace Opgave50
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Checker om tekest1 er en del af tekst2");
            Console.WriteLine("Indtast tekst1");
            var tekst1 = Console.ReadLine();
            Console.WriteLine("Indtast tekst2");
            var tekst2 = Console.ReadLine();

            Console.WriteLine(tekst2.Contains(tekst1) ? "Teksten er en del af tekst2" : "Teksten er ikke en del af tekst2");
        }
    }
}