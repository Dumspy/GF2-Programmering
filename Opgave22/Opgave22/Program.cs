using System;

namespace Opgave22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Biograf bilet pris udregner");
            Console.Write("Indtast din alder");

            var alder = Convert.ToInt32(Console.ReadLine());

            if (alder < 18)
            {
                Console.WriteLine("Da du er under 18 koster din billet 45kr");
            }
            else if (alder >= 18 && alder <= 65)
            {
                Console.WriteLine("Da du er mellem 18 og 65 koster din billet 75");
            }
            else
            {
                Console.WriteLine("Da du er over 65 koster din billet 35");
            }
        }
    }
}