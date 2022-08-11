using System;

namespace Opgave52
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(momsCalculation(5000));
        }

        private static double momsCalculation(double value)
        {
            return value * 1.25;
        }
    }
}