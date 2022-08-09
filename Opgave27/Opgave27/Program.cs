using System;

namespace Opgave27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast købs total pris");
            double købsTotalPris = Convert.ToDouble(Console.ReadLine());

            if (købsTotalPris > 1000)
            {
                Console.WriteLine("Da du har købt for over 1000kr får du 5% rabat og dit total er istedet {0}kr", købsTotalPris * 0.95);
            }
            else
            {
                Console.WriteLine("Da dit køb er under 1000kr får du ikke 5% rabat og dit total er derfor {0}kr", købsTotalPris);
            }
        }
    }
}