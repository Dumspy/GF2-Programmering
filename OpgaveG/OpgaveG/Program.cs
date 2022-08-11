using System;

namespace OpgaveG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast km til arbejde:");
            var km = int.Parse(Console.ReadLine());
            if (24 >= km)
            {
                Console.WriteLine("Da du har under 24km til arbejde får du ikke noget fradrag");
            }else if (km > 24 && km <= 100)
            {
                var fradrag = km * 1.54;
                Console.WriteLine("Du får {0:N2} kr. fradrag", fradrag);
            }
            else
            {
                var fradrag = km * 0.77;
                Console.WriteLine("Du får {0:N2} kr. fradrag", fradrag);
            }
        }
    }
}