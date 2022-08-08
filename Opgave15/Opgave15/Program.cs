using System;

namespace Opgave15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fahrenheit til Celsius");
            Console.WriteLine("Skriv temperaturen i Fahrenheit");
            var fahrenheit = double.Parse(Console.ReadLine());
            var celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} grader Fahrenheit er {celsius} grader Celsius");
        }
    }
}