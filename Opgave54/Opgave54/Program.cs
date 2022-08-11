using System;

namespace Opgave54
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Indtast højde på cylinder i cm: ");
            var højde = Double.Parse(Console.ReadLine());

            Console.Write("Indtast radius på cylinder i cm: ");
            var længde = Double.Parse(Console.ReadLine());

            Console.Write("Rumfanget af cylinder er {0} cm³", rumfang(højde, længde));
        }

        static public double rumfang(double h, double r)
        {
            return Math.PI * Math.Pow(r, 2) + h;
        }
    }
}